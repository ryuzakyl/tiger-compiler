using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.Errors;


namespace Compiler.AST
{
    public abstract class BinaryOperationNode : OperationNode
    {
        public BinaryOperationNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// Represents the left operand
        /// </summary>
        protected ExpressionNode LeftOperand
        {
            get { return GetChild(0) as ExpressionNode; }

        }

        /// <summary>
        /// Represents the right operand
        /// </summary>
        protected ExpressionNode RightOperand
        {
            get { return GetChild(1) as ExpressionNode; }
        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///check semantics al operando izquierdo
            LeftOperand.CheckSemantic(symbolTable, errors);

            ///check semantics al operando derecho
            RightOperand.CheckSemantic(symbolTable, errors);

            ///si alguno de los operandos evalúa de error este nodo también
            if (Object.Equals(LeftOperand.NodeInfo, SemanticInfo.SemanticError) || 
                Object.Equals(RightOperand.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            //los operandos tienen que ser compatibles
            if (!LeftOperand.NodeInfo.Type.IsCompatibleWith(RightOperand.NodeInfo.Type))
            {
                errors.Add(new CompileError
                {
                    Line = LeftOperand.Line,
                    Column = LeftOperand.CharPositionInLine,
                    ErrorMessage = string.Format("Operand '{0}' cannot be applied to operands of type '{1}' and '{2}'", this.Text, LeftOperand.NodeInfo.Type.Name, RightOperand.NodeInfo.Type.Name),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            ///seteamos la información del NodeInfo
            NodeInfo.BuiltInType = BuiltInType.Int;
            NodeInfo.Type = SemanticInfo.Int;
            NodeInfo.ILType = typeof(int);
        }
    }
}
