using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;

using Antlr.Runtime;

using Compiler.CodeGenerators;

namespace Compiler.AST
{
    public class MinusOperationNode : ArithmeticOperationNode
    {
        public MinusOperationNode(IToken token) : base(token)
        {

        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///gen code al ArithmeticOperationNode
            base.GenerateCode(cg);

            ///los restamos
            cg.ILGenerator.Emit(OpCodes.Sub);
        }
    }
}
