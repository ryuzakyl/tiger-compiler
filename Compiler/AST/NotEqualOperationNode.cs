using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.CodeGenerators;

namespace Compiler.AST
{
    public class NotEqualOperationNode : EqualityValueOperationNode
    {
        public NotEqualOperationNode(IToken token) : base(token)
        {

        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///gen code al EqualityValueOperationNode
            base.GenerateCode(cg);

            if (LeftOperand.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Int))
            {
                cg.ILGenerator.Emit(OpCodes.Ceq);
                cg.ILGenerator.Emit(OpCodes.Ldc_I4_0);
                cg.ILGenerator.Emit(OpCodes.Ceq);

            }
            else
            {
                MethodInfo objectEquals = typeof(Object).GetMethod("Equals", new Type[] { typeof(object), typeof(object) });
                cg.ILGenerator.Emit(OpCodes.Call, objectEquals);
                cg.ILGenerator.Emit(OpCodes.Ldc_I4_0);
                cg.ILGenerator.Emit(OpCodes.Ceq);
            }
        }
    }
}
