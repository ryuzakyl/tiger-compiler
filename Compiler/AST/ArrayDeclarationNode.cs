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
    public class ArrayDeclarationNode : TypeDeclarationNode
    {
        public ArrayDeclarationNode(IToken token) : base(token)
        {

        }



        /// <summary>
        /// Id of the new array
        /// </summary>
        public string ArrayId
        {
            get { return GetChild(0).Text; }
        }

        /// <summary>
        /// Id of array's elements 
        /// </summary>
        public string ElementsId
        {
            get { return GetChild(1).Text; }
        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///no se pude declarar un array en función de si mismo
            if (ArrayId.Equals(ElementsId))
            {
                errors.Add(new CompileError
                {
                    Line = this.Line,
                    Column = this.CharPositionInLine,
                    ErrorMessage = "Defining a self recursive 'array' type is not allowed",
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            SemanticInfo elementsTypeInfo;

            ///el tipo de los elementos del array tiene que existir
            if (!symbolTable.GetDefinedTypeDeep(ElementsId, out elementsTypeInfo))
            {
                errors.Add(new CompileError
                {
                    Line = GetChild(1).Line,
                    Column = Line = GetChild(1).CharPositionInLine,
                    ErrorMessage = string.Format("Type '{0}' could not be found in current context", ElementsId),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            ///si no ha evaluado de error le seteamos los valores
            if (!Object.Equals(NodeInfo, SemanticInfo.SemanticError))
            {
                NodeInfo.BuiltInType = BuiltInType.Void;
                NodeInfo.Type = SemanticInfo.Void;
            }

            SemanticInfo arrayAlias;
            symbolTable.GetDefinedTypeShallow(ArrayId, out arrayAlias);

            arrayAlias.BuiltInType = BuiltInType.Array;
            arrayAlias.IsPending = false;
            arrayAlias.Type = arrayAlias;

            arrayAlias.ElementsType = elementsTypeInfo;
            NodeInfo.ElementsType = arrayAlias.ElementsType;
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///lo agregamos al contexto
            cg.ILContextTable.InsertILElement(ArrayId, new ILElementInfo { ILType = NodeInfo.ILType , ElementKind = SymbolKind.Type });
        }
    }
}
