using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.Errors;

namespace Compiler.AST
{
    public abstract class LogicalOperationNode : ValueOperationNode
    {
        public LogicalOperationNode(IToken token) : base(token)
        {

        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///check semantics al ValueOperationNode
            base.CheckSemantic(symbolTable, errors);

            ///si el ValueOperationNode evalúa de error este nodo también
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
    }
}
