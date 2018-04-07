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
    public class BreakNode : ControlNode
    {
        public BreakNode(IToken token) : base(token)
        {

        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///seteamos la información del NodeInfo
            NodeInfo.Type = SemanticInfo.Void;
            NodeInfo.BuiltInType = BuiltInType.Void;

            ExpressionNode current = this;
            bool isFirstExpressionSequence = true;

            ///vamos subiendo en el AST hasta encontrar un ciclo
            while ((current = current.Parent as ExpressionNode) != null)
            {
                ///no se permiten break en function que no estén dentro de un ciclo
                if (current is CallableDeclarationNode)
                {
                    errors.Add(new CompileError
                    {
                        Line = this.Line,
                        Column = this.CharPositionInLine,
                        ErrorMessage = "No enclosing loop out of which to break or continue",
                        Kind = ErrorKind.Semantic
                    });

                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                    return;
                }

                ///si nos encontramos el enclosing loop el break está correcto
                if (current is ForLoopNode || current is WhileLoopNode)
                    return;

                ///si nos encontramos con un expression sequence
                if (isFirstExpressionSequence && current is ExpressionSequenceNode)
                {
                    ExpressionSequenceNode expr_seq = (ExpressionSequenceNode)current;
                    expr_seq.AnyExpressionContainsBreak = true;
                    isFirstExpressionSequence = false;
                }
            }

            ///si no nos encontramos  un ciclo el break no es correcto
            errors.Add(new CompileError
            {
                Line = this.Line,
                Column = this.CharPositionInLine,
                ErrorMessage = "No enclosing loop out of which to break or continue",
                Kind = ErrorKind.Semantic
            });

            ///el nodo evalúa de error
            NodeInfo = SemanticInfo.SemanticError;
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///rompemos el ciclo más cercano
            cg.ILGenerator.Emit(OpCodes.Br, cg.EndLoopLabelStack.Peek());
        }
    }
}
