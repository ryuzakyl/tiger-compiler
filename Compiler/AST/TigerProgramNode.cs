using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;
using Antlr.Runtime.Tree;

using Compiler.SemanticStructures;
using Compiler.Errors;
using Compiler.CodeGenerators;

namespace Compiler.AST
{
    public abstract class TigerProgramNode : CommonTree
    {
        public TigerProgramNode(IToken token) : base(token) { }

        /// <summary>
        /// Check semantics of Tiger code
        /// </summary>
        /// <param name="symbolTable">Compiler symbol table</param>
        /// <param name="errors">List of compile errors</param>
        public abstract void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors);

        /// <summary>
        /// Generates MSIL code
        /// </summary>
        /// <param name="cg">MSIL code generator</param>
        public abstract void GenerateCode(ILCodeGenerator cg);
    }
}
