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
    public class AliasDeclarationNode : TypeDeclarationNode
    {
        SemanticInfo aliasParche;

        public AliasDeclarationNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// New type Id
        /// </summary>
        public string AliasId
        {
            get { return GetChild(0).Text; }
        }

        /// <summary>
        /// Type of which this type is alias
        /// </summary>
        public string OriginalId
        {
            get { return GetChild(1).Text; }
        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///un type no puede ser alias de si mismo
            if (AliasId.Equals(OriginalId))
            {
                errors.Add(new CompileError
                {
                    Line = this.Line,
                    Column = this.CharPositionInLine,
                    ErrorMessage = "Defining a self recursive 'alias' type is not allowed",
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            SemanticInfo typeInfo;

            ///el tipo del que se es alias debe existir
            if (!symbolTable.GetDefinedTypeDeep(OriginalId, out typeInfo))
            {
                errors.Add(new CompileError
                {
                    Line = GetChild(1).Line,
                    Column = GetChild(1).CharPositionInLine,
                    ErrorMessage = string.Format("Type '{0}' could not be found in current context", OriginalId),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            ///si no ha evaluado de error le seteamos los valores
            if (!Object.Equals(NodeInfo, SemanticInfo.SemanticError))
            {
                NodeInfo.Type = SemanticInfo.Void;
                NodeInfo.BuiltInType = BuiltInType.Void;
            }

            SemanticInfo alias;
            symbolTable.GetDefinedTypeDeep(AliasId, out alias);
            alias.BuiltInType = typeInfo.BuiltInType;

            alias.ElementsType = typeInfo.ElementsType;
            alias.Fields = typeInfo.Fields;

            alias.Type = typeInfo.Type;
            alias.ILType = typeInfo.ILType;
            alias.IsPending = false;

            //change
            NodeInfo = SemanticInfo.Void; //me parece que el nodeinfo del aliasDeclaration tiene que ser void
            aliasParche = typeInfo;
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///lo agregamos al contexto
            cg.ILContextTable.InsertILElement(AliasId, new ILElementInfo { ILType = aliasParche.ILType, ElementKind = SymbolKind.Type });
        }
    }
}
