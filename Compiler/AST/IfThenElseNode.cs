using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.Errors;
using Compiler.CodeGenerators;

namespace Compiler.AST
{
    public class IfThenElseNode : ControlNode
    {
        public IfThenElseNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// Represents the 'if' condition 
        /// </summary>
        public ExpressionNode Condition
        {
            get { return GetChild(0) as ExpressionNode; }
        }

        /// <summary>
        /// Represents the 'then' executable body
        /// </summary>
        public ExpressionNode ThenBody
        {
            get { return GetChild(1) as ExpressionNode; }
        }

        /// <summary>
        /// Represents the 'else' executable body
        /// </summary>
        public ExpressionNode ElseBody
        {
            get { return GetChild(2) as ExpressionNode; }
        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///check semantics al Condition
            Condition.CheckSemantic(symbolTable, errors);

            ///check semantics al body del Then
            ThenBody.CheckSemantic(symbolTable, errors);

            ///check semantics al body del Else
            ElseBody.CheckSemantic(symbolTable, errors);

            ///seteamos la información del NodeInfo
            NodeInfo.Type = ThenBody.NodeInfo.Type;
            NodeInfo.BuiltInType = ThenBody.NodeInfo.BuiltInType;
            NodeInfo.ElementsType = ThenBody.NodeInfo.ElementsType;
            NodeInfo.Fields = ThenBody.NodeInfo.Fields;
            NodeInfo.ILType = ThenBody.NodeInfo.ILType;

            ///si Condition no evaluó de error
            if (!Object.Equals(Condition.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el tipo de Condition tiene que ser compatible con 'int'
                if (!Condition.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Int))
                {
                    errors.Add(new CompileError
                    {
                        Line = Condition.Line,
                        Column = Condition.CharPositionInLine,
                        ErrorMessage = string.Format("Cannot implicitly convert type '{0}' to int", Condition.NodeInfo.Type.Name),
                        Kind = ErrorKind.Semantic
                    });

                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }
            }

            ///si ThenBody o ElseBody evalúan de error este también
            if (Object.Equals(ThenBody.NodeInfo, SemanticInfo.SemanticError) || 
                Object.Equals(ElseBody.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            ///los tipos de retorno de ThenBody y ElseBody tienen que ser compatibles
            if (!ThenBody.NodeInfo.Type.IsCompatibleWith(ElseBody.NodeInfo.Type))
            {
                errors.Add(new CompileError
                {
                    Line = ElseBody.Line,
                    Column = ElseBody.CharPositionInLine,
                    ErrorMessage = "'Then' and 'Else' expresisons must have compatible types",
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            Label elseLabel = cg.ILGenerator.DefineLabel();
            Label endLabel = cg.ILGenerator.DefineLabel();

            ///gen code al Condition
            Condition.GenerateCode(cg);

            //si fue verdadera hago la parte del then en otro caso hago la parte del else
            cg.ILGenerator.Emit(OpCodes.Brfalse, elseLabel);
            
            ///gen code al ThenBody
            ThenBody.GenerateCode(cg);

            ///saltamos al fin de la instrucción
            cg.ILGenerator.Emit(OpCodes.Br, endLabel);

            ///marcamos el 'else'
            cg.ILGenerator.MarkLabel(elseLabel);
            
            ///gen code al ElseBody
            ElseBody.GenerateCode(cg);

            ///marcamos el fin de la instrucción
            cg.ILGenerator.MarkLabel(endLabel);
        }
    }
}
