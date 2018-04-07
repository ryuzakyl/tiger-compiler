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
    public class ExpressionSequenceNode : AssignableExpressionNode
    {
        public ExpressionSequenceNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// Expressions Count
        /// </summary>
        public int ExpressionCount
        {
            get { return ChildCount; }
        }

        /// <summary>
        /// Gets an expression of the expression sequence
        /// </summary>
        /// <param name="i">index of the expression</param>
        /// <returns>the expression</returns>
        /// <remarks>Count starts at index 0</remarks>
        public ExpressionNode ExpressionAt(int i)
        {
            return GetChild(i) as ExpressionNode;
        }

        /// <summary>
        /// Indicates if any expression of the expression sequence contains break
        /// </summary>
        public bool AnyExpressionContainsBreak { get; set; }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///seteamos los campos necesarios
            NodeInfo = new SemanticInfo
            {
                BuiltInType = BuiltInType.Void,
                Type = SemanticInfo.Void
            };

            ExpressionNode currentExpression = null;

            //check semantics a cada una de las expresiones
            for (int i = 0; i < ExpressionCount; i++)
            {
                currentExpression = ExpressionAt(i);

                ///check semantics a la currentExpression
                currentExpression.CheckSemantic(symbolTable, errors);

                ///si alguna de las expresiones evalúa de error este también
                if (Object.Equals(currentExpression.NodeInfo, SemanticInfo.SemanticError))
                {
                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }
            }

            ///si este no ha evaluado de error
            if (!Object.Equals(NodeInfo, SemanticInfo.SemanticError))
            {
                ///si hay mas de una expresión y ninguna tiene break
                if (ExpressionCount > 0 && !AnyExpressionContainsBreak)
                {
                    //NodeInfo.BuiltInType = currentExpression.NodeInfo.BuiltInType;
                    //NodeInfo.Type = currentExpression.NodeInfo.Type;

                    //NodeInfo.ElementsType = currentExpression.NodeInfo.ElementsType;
                    //NodeInfo.Fields = currentExpression.NodeInfo.Fields;
                    //NodeInfo.ILType = currentExpression.NodeInfo.ILType;
                    NodeInfo = currentExpression.NodeInfo;
                }
            }

        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ExpressionNode currentExpression = null;

            for (int i = 0; i < ExpressionCount - 1; i++)
            {
                currentExpression = ExpressionAt(i);

                ///gen code a la currentExression
                currentExpression.GenerateCode(cg);

                ///si devuelve valor no lo usamos
                if (!currentExpression.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Void))
                    cg.ILGenerator.Emit(OpCodes.Pop);
            }

            ///gen code a la última expression
            if (ExpressionCount > 0)
            {
                currentExpression = ExpressionAt(ExpressionCount - 1);
                currentExpression.GenerateCode(cg);

                ///si alguna expression contiene break y retorna valor la última expression
                if (AnyExpressionContainsBreak && currentExpression.NodeInfo.BuiltInType.IsReturnType())
                    cg.ILGenerator.Emit(OpCodes.Pop);
            }

            
        }
    }
}
