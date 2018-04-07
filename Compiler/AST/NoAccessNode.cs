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
    public class NoAccessNode : AccessNode
    {
        public NoAccessNode(IToken token)
            : base(token)
        {

        }

        public ExpressionNode AssignableExpression { get { return GetChild(0) as ExpressionNode; } }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            //chequeamos el AssignableExpression(la parte izquierda)
            AssignableExpression.CheckSemantic(symbolTable, errors);

            //chequeamos que AssignableExpression no haya evaluado de error
            if (AssignableExpression.NodeInfo.Equals(SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            //seteamos los campos necesarios
            NodeInfo.BuiltInType = AssignableExpression.NodeInfo.BuiltInType;
            NodeInfo.ElementsType = AssignableExpression.NodeInfo.ElementsType;
            NodeInfo.Fields = AssignableExpression.NodeInfo.Fields;
            NodeInfo.Type = AssignableExpression.NodeInfo.Type;
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            AssignableExpression.GenerateCode(cg);
        }
    }
}
