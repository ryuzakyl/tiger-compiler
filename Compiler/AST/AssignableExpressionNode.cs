using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;

namespace Compiler.AST
{
    public abstract class AssignableExpressionNode : ExpressionNode
    {
        public AssignableExpressionNode(IToken token) : base(token)
        {

        }
    }
}
