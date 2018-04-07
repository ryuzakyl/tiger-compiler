using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.Errors;
using Compiler.CodeGenerators;

using System.Reflection.Emit;


namespace Compiler.AST
{
    public class UnaryMinusOperationNode : UnaryOperationNode
    {
        public UnaryMinusOperationNode(IToken token) : base(token)
        {

        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///check semantics a UnaryOperationNode
            base.CheckSemantic(symbolTable, errors);

            ///si el Operand evaluó de error
            if (Object.Equals(Operand.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            ///si no es compatible con 'int'
            if (!Operand.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Int))
            {
                errors.Add(new CompileError
                {
                    Line = Operand.Line,
                    Column = Operand.CharPositionInLine,
                    ErrorMessage = string.Format("Operator '-' cannot be applied to operand of type '{0}'", Operand.NodeInfo.Type.Name),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }
            else
            {
                ///seteamos la información del NodeInfo
                NodeInfo.Name = SemanticInfo.NoName;
                NodeInfo.Type = Operand.NodeInfo.Type;
                NodeInfo.BuiltInType = BuiltInType.Int;
                NodeInfo.ElementKind = SymbolKind.NoSymbol;
                
                //change
                NodeInfo.ILType = Operand.NodeInfo.ILType;
            }
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///gen code a UnaryOperationNode
            base.GenerateCode(cg);

            ///negamos el valor
            cg.ILGenerator.Emit(OpCodes.Neg);
        }
    }
}
