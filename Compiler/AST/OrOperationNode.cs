using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;

using Antlr.Runtime;

using Compiler.CodeGenerators;

namespace Compiler.AST
{
    public class OrOperationNode : LogicalOperationNode
    {
        public OrOperationNode(IToken token):base(token)
        {

        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            Label trueLabel = cg.ILGenerator.DefineLabel();
            Label falseLabel = cg.ILGenerator.DefineLabel();

            ///evalúo el operando izquierdo 
            LeftOperand.GenerateCode(cg);
            
            ///si fue true salto para el final de la operación
            cg.ILGenerator.Emit(OpCodes.Brtrue, trueLabel);

            ///evalúo el operando derecho
            RightOperand.GenerateCode(cg);

            ///si fue true salto para el final de la operación
            cg.ILGenerator.Emit(OpCodes.Brtrue, trueLabel);

            ///el resultado del | fue false
            cg.ILGenerator.Emit(OpCodes.Ldc_I4_0);

            ///salto para el false
            cg.ILGenerator.Emit(OpCodes.Br, falseLabel);

            ///marcamos el fin de la operación
            cg.ILGenerator.MarkLabel(trueLabel);
            
            ///pongo true en la pila
            cg.ILGenerator.Emit(OpCodes.Ldc_I4_1);

            ///marcamos el false
            cg.ILGenerator.MarkLabel(falseLabel);
        }
    }
}
