using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.CodeGenerators;
using System.Reflection;
using System.Reflection.Emit;

namespace Compiler.AST
{
    public class GreaterThanOperationNode : RelationalOperationNode
    {
        public GreaterThanOperationNode(IToken token) : base(token)
        {

        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///gen code al RelationalOperationNode
            base.GenerateCode(cg);

            if (LeftOperand.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Int))
                cg.ILGenerator.Emit(OpCodes.Cgt);
            else
            {
                MethodInfo method = typeof(string).GetMethod("Compare", new Type[] { typeof(string), typeof(string) });
                cg.ILGenerator.Emit(OpCodes.Call, method);

                cg.ILGenerator.Emit(OpCodes.Ldc_I4_1);
                cg.ILGenerator.Emit(OpCodes.Ceq);
            }
        }
    }
}
