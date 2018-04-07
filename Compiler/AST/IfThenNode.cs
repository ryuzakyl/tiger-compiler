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
    public class IfThenNode : ControlNode
    {
        public IfThenNode(IToken token) : base(token)
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

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///check semantics al Condition
            Condition.CheckSemantic(symbolTable, errors);

            ///check semantics al body del Then
            ThenBody.CheckSemantic(symbolTable, errors);

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

            //si ThenBody evalúa de error este también
            if (Object.Equals(ThenBody.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            ///seteamos la información del NodeInfo
            NodeInfo.BuiltInType = BuiltInType.Void;
            NodeInfo.Type = SemanticInfo.Void;

            //el cuerpo de ThenBody no puede retornar valor
            if (ThenBody.NodeInfo.BuiltInType.IsReturnType())
            {
                errors.Add(new CompileError
                {
                    Line = ThenBody.Line,
                    Column = ThenBody.CharPositionInLine,
                    ErrorMessage = "Body of control instruction 'if-then' cannot return value",
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            Label falseLabel = cg.ILGenerator.DefineLabel();

            ///gen code al Condition
            Condition.GenerateCode(cg);

            cg.ILGenerator.Emit(OpCodes.Ldc_I4_0);
            cg.ILGenerator.Emit(OpCodes.Ceq);
            cg.ILGenerator.Emit(OpCodes.Brtrue, falseLabel);

            ///gen code al ThenBody
            ThenBody.GenerateCode(cg);
            
            cg.ILGenerator.MarkLabel(falseLabel);
        }
    }
}
