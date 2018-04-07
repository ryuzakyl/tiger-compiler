using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.Errors;

namespace Compiler.AST
{
    class ProcedureDeclarationNode : CallableDeclarationNode
    {
        public ProcedureDeclarationNode(IToken token) : base(token)
        {

        }

        public override void CheckSignatureSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///check signature semantics al CallableDeclarationNode
            base.CheckSignatureSemantic(symbolTable, errors);

            ///lo agregamos a la tabla de símbolos como pendiente
            symbolTable.InsertSymbol(new SemanticInfo
            {
                Name = CallableId,
                ElementKind = SymbolKind.Procedure,
                Args = parametersType,
                IsPending = true,
                Type = SemanticInfo.Void, 
                BuiltInType = BuiltInType.Void
            });
        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///check semantics al CallableDeclarationNode
            base.CheckSemantic(symbolTable, errors);

            ///si BodyExpression no evaluó de error
            if (!Object.Equals(CallableBody.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el procedimiento debe retornar void
                if (!CallableBody.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Void))
                {
                    errors.Add(new CompileError
                    {
                        Line = CallableBody.Line,
                        Column = CallableBody.CharPositionInLine,
                        ErrorMessage = string.Format("Cannot implicitly convert type '{0}' to 'void'", CallableBody.NodeInfo.Type.Name),
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
                    ILType = null
                };

                SemanticInfo arg;

                ///guardamos los ILType
                for (int i = 0; i < Parameters.Count; i++)
                {
                    symbolTable.GetDefinedTypeDeep(Parameters[i].Value, out arg);
                    ILTypes.Add(arg.Type.ILType);
                }
            }

            SemanticInfo procedure;
            ///completamos la definición del procedimiento
            symbolTable.GetDefinedCallableDeep(CallableId, out procedure);
            procedure.IsPending = false;
        }
    }
}
