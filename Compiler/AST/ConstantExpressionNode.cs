using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;

namespace Compiler.AST
{
    public abstract class ConstantExpressionNode : ExpressionNode
    {
        public ConstantExpressionNode(IToken token) : base(token)
        {

        }
    }
}
