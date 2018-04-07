using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.Errors;
using Compiler.CodeGenerators;

namespace Compiler.AST
{
    public class IntConstantNode : ConstantExpressionNode
    {
        public IntConstantNode(IToken token) : base(token)
        {

        }

        private int IntValue { get; set; }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            int intValue;

            ///tratamos de parsear el entero
            if (!int.TryParse(this.Text, out intValue))
            {
                errors.Add(new CompileError
                {
                    Line = this.Line,
                    Column = this.CharPositionInLine,
                    ErrorMessage = "Integral constant is too large",
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }
            else
            {
                ///seteamos la información del NodeInfo
                NodeInfo.Type = SemanticInfo.Int;
                NodeInfo.BuiltInType = BuiltInType.Int;
                NodeInfo.ILType = typeof(int);
            }

            IntValue = intValue;
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///cargamos el entero en la pila
            cg.ILGenerator.Emit(OpCodes.Ldc_I4, IntValue);
        }
    }
}
