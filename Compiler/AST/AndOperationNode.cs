using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;

using Antlr.Runtime;

using Compiler.CodeGenerators;

namespace Compiler.AST
{
    public class AndOperationNode : LogicalOperationNode
    {
        public AndOperationNode(IToken token) : base(token)
        {

        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            Label falseLabel = cg.ILGenerator.DefineLabel();
            Label trueLabel = cg.ILGenerator.DefineLabel();

            ///evalúo el operando izquierdo 
            LeftOperand.GenerateCode(cg);

            ///si fue false salto al fin de la operación
            cg.ILGenerator.Emit(OpCodes.Brfalse, falseLabel);

            ///evalúo el operando derecho
            RightOperand.GenerateCode(cg);
            
            ///si fue false salto al fin de la operación
            cg.ILGenerator.Emit(OpCodes.Brfalse, falseLabel);

            ///el resultado del & fue true
            cg.ILGenerator.Emit(OpCodes.Ldc_I4_1);

            ///salto para el true
            cg.ILGenerator.Emit(OpCodes.Br, trueLabel);

            ///marcamos el fin de la operación
            cg.ILGenerator.MarkLabel(falseLabel);
            
            ///pongo false en la pila
            cg.ILGenerator.Emit(OpCodes.Ldc_I4_0);

            ///marcamos el true
            cg.ILGenerator.MarkLabel(trueLabel);
        }
    }
}
