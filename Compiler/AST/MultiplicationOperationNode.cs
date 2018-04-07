using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;

using Antlr.Runtime;

using Compiler.CodeGenerators;

namespace Compiler.AST
{
    public class MultiplicationOperationNode : ArithmeticOperationNode
    {
        public MultiplicationOperationNode(IToken token) : base(token)
        {

        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///gen code al ArithmeticOperationNode
            base.GenerateCode(cg);

            ///los multiplicamos
            cg.ILGenerator.Emit(OpCodes.Mul);
        }
    }
}
