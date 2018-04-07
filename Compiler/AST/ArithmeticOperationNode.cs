using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.Errors;
using Compiler.CodeGenerators;

namespace Compiler.AST
{
    public abstract class ArithmeticOperationNode : ValueOperationNode
    {
        public ArithmeticOperationNode(IToken token) : base(token)
        {

        }


        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///check semantics al ValueOperationNode
            base.CheckSemantic(symbolTable, errors);

            ///si el ValueOperationNode evalúa de error este también
            if (Object.Equals(base.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            ///el tipo de la expresión va a ser el tipo de los operandos, en caso de ser iguales, 'int' en otro caso
            if (Object.Equals(LeftOperand.NodeInfo.Type, RightOperand.NodeInfo.Type))
                NodeInfo.Type = LeftOperand.NodeInfo.Type;
            else
                NodeInfo.Type = SemanticInfo.Int;

            ///el BuiltIn siempre es 'int'
            NodeInfo.BuiltInType = BuiltInType.Int;

        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///gen code al LeftOperand
            LeftOperand.GenerateCode(cg);

            ///gen code al RightOperand
            RightOperand.GenerateCode(cg);
        }
    }
}
