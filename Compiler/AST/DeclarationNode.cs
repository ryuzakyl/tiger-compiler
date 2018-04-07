using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.Errors;

namespace Compiler.AST
{
    public abstract class DeclarationNode : ExpressionNode
    {
        public DeclarationNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// Preprocess semantics declarations
        /// </summary>
        /// <param name="symbolTable">symbol table</param>
        /// <param name="errors">list of errors</param>
        public virtual void CheckSignatureSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            //DO NOTHING
        }

    }
}
