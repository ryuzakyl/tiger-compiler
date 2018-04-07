using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.Errors;

namespace Compiler.AST
{
    class FunctionDeclarationNode : CallableDeclarationNode
    {
        public FunctionDeclarationNode(IToken token) : base(token)
        {

        }

        public SemanticInfo functionParche;

        /// <summary>
        /// Return type of the function
        /// </summary>
        public string ReturnType
        {
            get { return GetChild(ChildCount - 2).Text; }
        }

        public override void CheckSignatureSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///check signature semantics al CallableDeclarationNode
            base.CheckSignatureSemantic(symbolTable, errors);

            SemanticInfo returnTypeInfo;
            symbolTable.GetDefinedTypeShallow(ReturnType, out returnTypeInfo);

            ///lo agregamos a la tabla de símbolos como pendiente
            symbolTable.InsertSymbol(new SemanticInfo
            {
                Name = CallableId,
                ElementKind = SymbolKind.Function,
                Args = parametersType,
                BuiltInType = returnTypeInfo.BuiltInType,
                IsPending = true, 
                Type = returnTypeInfo.Type,
                ElementsType = returnTypeInfo.ElementsType,
                Fields = returnTypeInfo.Fields
            });
        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///check semantics al CallableDeclarationNode
            base.CheckSemantic(symbolTable, errors);

            SemanticInfo returnTypeInfo;

            ///chequeamos si existe el tipo de retorno
            if (!symbolTable.GetDefinedTypeDeep(ReturnType, out returnTypeInfo))
            {
                errors.Add(new CompileError
                {
                    Line = GetChild(ChildCount - 2).Line,
                    Column = GetChild(ChildCount - 2).CharPositionInLine,
                    ErrorMessage = string.Format("Type '{0}' could not be found in current context", ReturnType),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            ///si CallableBody no evaluó de error y se encontró el tipo de retorno
            if (!Object.Equals(CallableBody.NodeInfo, SemanticInfo.SemanticError) && 
                !Object.Equals(returnTypeInfo, SemanticInfo.SemanticError))
            {
                ///el tipo deretorno del CallableBody tiene que ser compatible con el tipo de retorno
                if (!CallableBody.NodeInfo.Type.IsCompatibleWith(returnTypeInfo))
                {
                    errors.Add(new CompileError
                    {
                        Line = GetChild(ChildCount - 2).Line,
                        Column = GetChild(ChildCount - 2).CharPositionInLine,
                        ErrorMessage = string.Format("Cannot implicitly convert type '{0}' to '{1}'", CallableBody.NodeInfo.Type.Name, returnTypeInfo.Type.Name),
                        Kind = ErrorKind.Semantic
                    });

                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }
            }

            ///si no ha evaluado de error le seteamos los valores
            if (!Object.Equals(NodeInfo, SemanticInfo.SemanticError))
            {
                NodeInfo = new SemanticInfo
                {
                    Name = SemanticInfo.NoName,
                    ElementKind = SymbolKind.NoSymbol,
                    Type = SemanticInfo.Void,
                    BuiltInType = BuiltInType.Void,
                    ILType = returnTypeInfo.ILType
                };

                functionParche = returnTypeInfo;  

                SemanticInfo arg;

                ///guardamos los ILType
                for (int i = 0; i < Parameters.Count; i++)
                {
                    symbolTable.GetDefinedTypeDeep(Parameters[i].Value, out arg);
                    ILTypes.Add(arg.ILType);
                }
            }

            SemanticInfo function;
            ///completamos la definición de la función
            symbolTable.GetDefinedCallableDeep(CallableId, out function);
            function.IsPending = false;
        }

    }
}
