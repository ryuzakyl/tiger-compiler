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
    public abstract class ValueRefOperationNode : BinaryOperationNode
    {
        public ValueRefOperationNode(IToken token) : base(token)
        {

        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            //check semantics al BinaryOperationNode
            base.CheckSemantic(symbolTable, errors);

            ///si el BinaryOperationNode evalúa de error este también
            if (Object.Equals(base.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            ///ambos operandos no pueden ser 'nil'
            if (LeftOperand.NodeInfo.BuiltInType == BuiltInType.Nil && RightOperand.NodeInfo.BuiltInType == BuiltInType.Nil)
            {
                errors.Add(new CompileError
                {
                    Line = RightOperand.Line,
                    Column = RightOperand.CharPositionInLine,
                    ErrorMessage = "Cannot determine wether nil is 'array', 'record' or 'string'",
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///gen code al LeftOperand
            LeftOperand.GenerateCode(cg);

            ///gen code al RightOperand
            RightOperand.GenerateCode(cg);
        }
    }
}
