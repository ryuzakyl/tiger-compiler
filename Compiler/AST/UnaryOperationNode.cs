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
    public abstract class UnaryOperationNode : OperationNode
    {
        public UnaryOperationNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// Represents the operand of an unary operation
        /// </summary>
        public ExpressionNode Operand
        {
            get { return GetChild(0) as ExpressionNode; }
        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///hacemos check semantic al operador
            Operand.CheckSemantic(symbolTable, errors);
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///gen code al operando
            Operand.GenerateCode(cg);
        }
    }
}
