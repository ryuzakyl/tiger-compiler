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
    public abstract class EqualityValueOperationNode : ValueRefOperationNode
    {
        public EqualityValueOperationNode(IToken token) : base(token)
        {

        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            //check semantics al ValueRefOperationNode
            base.CheckSemantic(symbolTable, errors);

            //si el ValueRefOperationNode evalúa de error este también
            if (Object.Equals(base.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            ///el resultado siempre tiene que ser 'int'
            NodeInfo.BuiltInType = BuiltInType.Int;
            NodeInfo.Type = SemanticInfo.Int;
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///gen code al ValueRefOperationNode
            base.GenerateCode(cg);
        }
    }
}
