using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;
using Compiler.SemanticStructures;
using Compiler.Errors;

namespace Compiler.AST
{
    public abstract class ValueOperationNode : BinaryOperationNode
    {
        public ValueOperationNode(IToken token) : base(token)
        {

        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///check semantics al BinaryOperationNode
            base.CheckSemantic(symbolTable, errors);

            ///si el BinaryOperationNode evalúa de error este también
            if (Object.Equals(base.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            ///el 1er operando tiene que ser compatible con 'int'
            if (!LeftOperand.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Int))
            {
                errors.Add(new CompileError
                {
                    Line = LeftOperand.Line,
                    Column = LeftOperand.CharPositionInLine,
                    ErrorMessage = string.Format("Cannot implicitly convert type '{0}' to 'int'", LeftOperand.NodeInfo.Type.Name),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            ///el 2do operando tiene que ser compatible con 'int'
            if (!RightOperand.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Int))
            {
                errors.Add(new CompileError
                {
                    Line = RightOperand.Line,
                    Column = RightOperand.CharPositionInLine,
                    ErrorMessage = string.Format("Cannot implicitly convert type '{0}' to 'int'", RightOperand.NodeInfo.Type.Name),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }
        }
    }
}
