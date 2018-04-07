using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;
using Compiler.SemanticStructures;
using Compiler.Errors;

namespace Compiler.AST
{
    public abstract class TypeDeclarationNode : DeclarationNode
    {
        public TypeDeclarationNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// Id of the new type
        /// </summary>
        private string TypeId
        {
            get { return GetChild(0).Text; }
        }

        public override void CheckSignatureSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            SemanticInfo typeInfo;

            ///el tipo no puede estar definido
            if (symbolTable.GetDefinedTypeShallow(TypeId, out typeInfo))
            {
                errors.Add(new CompileError
                {
                    Line = this.Line,
                    Column = this.CharPositionInLine,
                    ErrorMessage = string.Format("Current context already contains a definition for '{0}'", TypeId),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            typeInfo = new SemanticInfo
            {
                Name = TypeId,
                ElementKind = SymbolKind.Type,
                //Type = null,
                IsPending = true
            };

            typeInfo.Type = !(this is AliasDeclarationNode) ? typeInfo : null;

            ///insertamos el tipo en la tabla de símbolos como pendiente
            symbolTable.InsertSymbol(typeInfo);
        }
    }
}
