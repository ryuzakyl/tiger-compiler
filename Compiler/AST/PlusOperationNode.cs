using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;

using Antlr.Runtime;

using Compiler.CodeGenerators;

namespace Compiler.AST
{
    public class PlusOperationNode : ArithmeticOperationNode
    {
        public PlusOperationNode(IToken token) : base(token)
        {

        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///gen code al ArithmeticOperationNode
            base.GenerateCode(cg);

            ///los sumamos
            cg.ILGenerator.Emit(OpCodes.Add);
        }
    }
}
