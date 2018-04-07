using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.Errors;
using Compiler.CodeGenerators;

namespace Compiler.AST
{
    public abstract class RelationalOperationNode : ValueRefOperationNode
    {
        public RelationalOperationNode(IToken token) : base(token)
        {

        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///check semantics al ValueRefOperationNode
            base.CheckSemantic(symbolTable, errors);

            ///si el ValueRefOperationNode evalúa de error este también
            if (Object.Equals(base.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            ///seteamos la información del NodeInfo
            NodeInfo.BuiltInType = BuiltInType.Int;
            NodeInfo.Type = SemanticInfo.Int;

            ///el 1er operando debe ser compatible con 'int' o 'string'
            if (!LeftOperand.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Int) && 
                !LeftOperand.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.String))
            {
                errors.Add(new CompileError
                {
                    Line = LeftOperand.Line,
                    Column = LeftOperand.CharPositionInLine,

                    ErrorMessage = string.Format("Cannot implicitly convert type '{0}' to 'int' or 'string'", LeftOperand.NodeInfo.Type.Name),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            ///el 2do operando debe ser compatible con 'int' o 'string'
            if (!RightOperand.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Int) && 
                !RightOperand.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.String))
            {
                errors.Add(new CompileError
                {
                    Line = RightOperand.Line,
                    Column = RightOperand.CharPositionInLine,
                    ErrorMessage = string.Format("Cannot implicitly convert type '{0}' to 'int' or 'string'", RightOperand.NodeInfo.Type.Name),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///gen code al ValueRefOperationNode
            base.GenerateCode(cg);
        }
    }
}
