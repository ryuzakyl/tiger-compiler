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
    public class ArrayIndexAccessNode : AccessNode
    {
        public ArrayIndexAccessNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// Exresion a la que se le hace []
        /// </summary>
        public ExpressionNode IndexedExpression
        {
            get { return GetChild(0) as ExpressionNode; }
        }

        /// <summary>
        /// Representa el indice con el que se indexa el array
        /// </summary>
        public ExpressionNode Index
        {
            get { return GetChild(1) as ExpressionNode; }
        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            //la politica que se siguio fue al encontrar un error en el array access no seguir buscando errores
            //al modo de C#

            //chequeamos la IndexedExpression
            IndexedExpression.CheckSemantic(symbolTable, errors);

            //chequeamos el Index
            Index.CheckSemantic(symbolTable, errors);

            //si alguno evalua de error entonces este tambien
            if (IndexedExpression.NodeInfo.Equals(SemanticInfo.SemanticError) || Index.NodeInfo.Equals(SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            //si IndexedExpression no evaluo de error
            if (!Object.Equals(IndexedExpression.NodeInfo, SemanticInfo.SemanticError))
            {
                //IndexedExpression tiene que ser compatible con array
                if (!IndexedExpression.NodeInfo.Type.BuiltInType.IsCompatibleWith(BuiltInType.Array))
                {
                    errors.Add(new CompileError
                    {
                        Line = IndexedExpression.Line,
                        Column = IndexedExpression.CharPositionInLine,
                        ErrorMessage = string.Format("Cannot apply indexing with [] to an expression of type '{0}'", IndexedExpression.NodeInfo.Type.Name),
                        Kind = ErrorKind.Semantic
                    });

                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }
            }

            //si Index no evaluo de error
            if (!Object.Equals(Index.NodeInfo, SemanticInfo.SemanticError))
            {
                //Index tiene que ser compatible con int
                if (!Index.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Int))
                {
                    errors.Add(new CompileError
                    {
                        Line = Index.Line,
                        Column = Index.CharPositionInLine,
                        ErrorMessage = string.Format("Cannot implicitly convert type '{0}' to 'int'", Index.NodeInfo.Type.Name),
                        Kind = ErrorKind.Semantic
                    });

                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }
            }

            //seteamos los campos necesarios
            if (!Object.Equals(NodeInfo, SemanticInfo.SemanticError))
            {
                NodeInfo.Name = SemanticInfo.NoName;
                NodeInfo.ElementKind = SymbolKind.NoSymbol;

                NodeInfo.BuiltInType = IndexedExpression.NodeInfo.ElementsType.BuiltInType;

                NodeInfo.ElementsType = IndexedExpression.NodeInfo.ElementsType.ElementsType;
                NodeInfo.Fields = IndexedExpression.NodeInfo.ElementsType.Fields;

                NodeInfo.Type = IndexedExpression.NodeInfo.ElementsType;
                
                //esta linea me parece que no es necesaria
                NodeInfo.ILType = IndexedExpression.NodeInfo.ElementsType.ILType;
            }
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {

            //generamos la expresion a la que se le hace []
            IndexedExpression.GenerateCode(cg);

            //generamos el indice
            Index.GenerateCode(cg);

            //cargamos el elemento del array
            if (LoadVariableInTheStack)
                cg.ILGenerator.Emit(OpCodes.Ldelem, IndexedExpression.NodeInfo.ElementsType.ILType);
        }
    }
}
