using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.Errors;
using Compiler.CodeGenerators;
using System.Reflection;

namespace Compiler.AST
{
    public class AssignInstructionNode : ExpressionNode
    {
        public AssignInstructionNode(IToken token)
            : base(token)
        {

        }

        public ExpressionNode LValue
        {
            get { return GetChild(0) as ExpressionNode; }
        }

        public ExpressionNode Expression
        {
            get { return GetChild(1) as ExpressionNode; }
        }


        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///chequeamos la semántica del LValue
            LValue.CheckSemantic(symbolTable, errors);

            ///chequeamos la semántica de la Expression
            Expression.CheckSemantic(symbolTable, errors);

            ///si LValue o Expression evalúan de error este evalua de error
            if (Object.Equals(LValue.NodeInfo, SemanticInfo.SemanticError) ||
                Object.Equals(Expression.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            ///si Expression no evaluó de error
            if (!Object.Equals(Expression.NodeInfo, SemanticInfo.SemanticError))
            {
                //Expression debe retornar valor
                if (Expression.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Void))
                {
                    errors.Add(new CompileError
                    {
                        Line = Expression.Line,
                        Column = Expression.CharPositionInLine,
                        ErrorMessage = "Assignation expression must return value",
                        Kind = ErrorKind.Semantic
                    });

                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }
            }

            //si LValue no evaluó de error
            if (!Object.Equals(LValue.NodeInfo, SemanticInfo.SemanticError))
            {
                //el tipo de Expresion y del LValue tienen que ser compatibles
                if (!LValue.NodeInfo.Type.IsCompatibleWith(Expression.NodeInfo.Type))
                {
                    errors.Add(new CompileError
                    {
                        Line = Expression.Line,
                        Column = Expression.CharPositionInLine,
                        ErrorMessage = string.Format("Cannot implicitly convert type '{0}' to '{1}'", Expression.NodeInfo.Type.Name, LValue.NodeInfo.Type.Name),
                        Kind = ErrorKind.Semantic
                    });

                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }

                ///si es solamente un id
                if (LValue is LValueIdNode)
                {
                    SemanticInfo variable;
                    LValueIdNode lvalueId = LValue as LValueIdNode;

                    if (symbolTable.GetDefinedVariableDeep(lvalueId.VariableName, out variable) && variable.IsReadOnly)
                    {
                        //no podemos modificar una variable readonly(en nuestro caso la de un for)
                        errors.Add(new CompileError
                        {
                            Line = LValue.Line,
                            Column = LValue.CharPositionInLine,
                            ErrorMessage = "A readonly field cannot be assigned to",
                            Kind = ErrorKind.Semantic
                        });

                        ///el nodo evalúa de error
                        NodeInfo = SemanticInfo.SemanticError;
                    }

                }
            }

            ///el lvalue solo puede ser una variable, el campo de un record o el elemento de un array
            if (!IsLValueAssignable())
            {
                errors.Add(new CompileError 
                {
                    Line = LValue.Line,
                    Column = LValue.CharPositionInLine,
                    ErrorMessage = "The left-hand side of an assignment must be a variable, field or indexer",
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            ///seteamos los campos necesarios
            if (!Object.Equals(NodeInfo, SemanticInfo.SemanticError))
            {
                NodeInfo.Type = SemanticInfo.Void;
                NodeInfo.BuiltInType = BuiltInType.Void;

                NodeInfo.ILType = Expression.NodeInfo.ILType;
            }
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            LValue.LoadVariableInTheStack = false;
            LValue.GenerateCode(cg);
            LValue.LoadVariableInTheStack = true;

            //generamos Expression
            Expression.GenerateCode(cg);

            if (LValue is LValueIdNode)
            {
                LValueIdNode id = LValue as LValueIdNode;
                ILElementInfo ile = cg.ILContextTable.GetDefinedVarOrFunction(id.VariableName);

                if (!Object.Equals(ile.FieldBuilder, null))
                    cg.ILGenerator.Emit(OpCodes.Stsfld, ile.FieldBuilder);
                else if (!Object.Equals(ile.LocalBuilder, null))
                    cg.ILGenerator.Emit(OpCodes.Stloc, ile.LocalBuilder);
            }
            else if (LValue is ArrayIndexAccessNode)
            {
                ArrayIndexAccessNode arrayElement = LValue as ArrayIndexAccessNode;
                cg.ILGenerator.Emit(OpCodes.Stelem, arrayElement.NodeInfo.Type.ILType);
            }
            else
            {
                RecordDotAccessNode recordAccess = (LValue as RecordDotAccessNode);
                ILElementInfo ile = cg.ILContextTable.GetDefinedType(recordAccess.RecordName);
                FieldInfo fi = ile.TypeBuilder.GetField(recordAccess.ID);
                cg.ILGenerator.Emit(OpCodes.Stfld, fi);
            }

        }

        private bool IsLValueAssignable()
        {
            return LValue is LValueIdNode || LValue is ArrayIndexAccessNode || LValue is RecordDotAccessNode;
        }

    }
}
