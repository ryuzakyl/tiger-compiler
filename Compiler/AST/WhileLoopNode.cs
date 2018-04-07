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
    public class WhileLoopNode : ControlNode
    {
        public WhileLoopNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// While loop condition
        /// </summary>
        public ExpressionNode Condition 
        { 
            get { return GetChild(0) as ExpressionNode; } 
        }

        /// <summary>
        /// Represents the 'while' executable body
        /// </summary>
        public ExpressionNode WhileBody 
        { 
            get { return GetChild(1) as ExpressionNode; }
        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///check semantics al Condition
            Condition.CheckSemantic(symbolTable, errors);

            ///si Condition evaluó de error este también
            if (!Object.Equals(Condition.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el tipo de Condition tiene que ser compatible con 'int'
                if (!Condition.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Int))
                {
                    errors.Add(new CompileError
                    {
                        Line = Condition.Line,
                        Column = Condition.CharPositionInLine,
                        ErrorMessage = string.Format("Cannot implicitly convert type '{0}' to 'int'", Condition.NodeInfo.Type.Name),
                        Kind = ErrorKind.Semantic
                    });

                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }
            }

            ///check semantics al WhileBody
            WhileBody.CheckSemantic(symbolTable, errors);

            ///si WhileBody evaluó de error este también
            if (Object.Equals(WhileBody.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            ///seteamos la información del NodeInfo
            NodeInfo.BuiltInType = BuiltInType.Void;
            NodeInfo.Type = SemanticInfo.Void;

            ///el WhileBody no puede retornar valor
            if (WhileBody.NodeInfo.BuiltInType.IsReturnType())
            {
                errors.Add(new CompileError
                {
                    Line = WhileBody.Line,
                    Column = WhileBody.CharPositionInLine,
                    ErrorMessage = "Body of control instruction 'while' cannot return value",
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            Label condLabel = cg.ILGenerator.DefineLabel();
            Label endLabel = cg.ILGenerator.DefineLabel();

            ///guardamos el label del fin del while
            cg.EndLoopLabelStack.Push(endLabel);

            ///marcamos la condición del while
            cg.ILGenerator.MarkLabel(condLabel);

            ///gen code del Condition
            Condition.GenerateCode(cg);

            ///si condition es false nos salimos del while
            cg.ILGenerator.Emit(OpCodes.Ldc_I4_0);
            cg.ILGenerator.Emit(OpCodes.Beq, endLabel);

            ///gen code del WhileBody
            WhileBody.GenerateCode(cg);

            ///volvemos a chequear la Condition
            cg.ILGenerator.Emit(OpCodes.Br, condLabel);

            ///marcamos el fin del while
            cg.ILGenerator.MarkLabel(endLabel);

            ///sacamos el label del fin del while
            cg.EndLoopLabelStack.Pop();
        }
    }
}
