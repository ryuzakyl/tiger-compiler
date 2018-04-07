using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.Errors;
using System.Reflection.Emit;

namespace Compiler.AST
{
    public abstract class VarDeclarationNode : DeclarationNode
    {
        public VarDeclarationNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// Name of the variable
        /// </summary>
        public string VariableName
        {
            get { return GetChild(0).Text; }
        }

        public FieldBuilder VariableFieldBuilder { get; set; }

        public LocalBuilder VariableLocalBuilder { get; set; }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            SemanticInfo variableInfo;

            ///chequeamos que en el scope local no haya otra variable con el mismo nombre
            if (symbolTable.GetDefinedVariableShallow(VariableName, out variableInfo))
            {
                errors.Add(new CompileError
                {
                    Line = this.Line,
                    Column = this.CharPositionInLine,
                    ErrorMessage = string.Format("Current context already contains a definition for '{0}'", VariableName),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            SemanticInfo callableInfo;

            //en el mismo scope no puede haber una función o procedimiento con el mismo nombre
            if (symbolTable.GetDefinedCallableShallow(VariableName, out callableInfo))
            {
                errors.Add(new CompileError
                {
                    Line = this.Line,
                    Column = this.CharPositionInLine,
                    ErrorMessage = string.Format("Current context already contains a definition for '{0}'", VariableName),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }
        }

    }
}
