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
    public class LessEqualThanOperationNode : RelationalOperationNode
    {
        public LessEqualThanOperationNode(IToken token) : base(token)
        {

        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///gen code al RelationalOperationNode
            base.GenerateCode(cg);

            if (LeftOperand.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Int))
            {
                cg.ILGenerator.Emit(OpCodes.Cgt);
                cg.ILGenerator.Emit(OpCodes.Ldc_I4_0);
                cg.ILGenerator.Emit(OpCodes.Ceq);
            }
            else
            {
                MethodInfo method = typeof(string).GetMethod("Compare", new Type[] { typeof(string), typeof(string) });
                cg.ILGenerator.Emit(OpCodes.Call, method);

                cg.ILGenerator.Emit(OpCodes.Ldc_I4_1);
                cg.ILGenerator.Emit(OpCodes.Clt);
            }
        }
    }
}
