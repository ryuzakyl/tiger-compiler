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
    public class LValueIdNode : AssignableExpressionNode
    {
        public LValueIdNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// Variable name
        /// </summary>
        public string VariableName
        {
            get { return GetChild(0).Text; }
        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            SemanticInfo idInfo;

            ///el id tiene que haber sido definido previamente
            if (!symbolTable.GetDefinedVariableDeep(VariableName, out idInfo))
            {
                errors.Add(new CompileError
                {
                    Line = this.Line,
                    Column = this.CharPositionInLine,
                    ErrorMessage = string.Format("The field name '{0}' does not exist in the current context", VariableName),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            if (!Object.Equals(NodeInfo, SemanticInfo.SemanticError))
            {
                NodeInfo.BuiltInType = idInfo.Type.BuiltInType;
                NodeInfo.Type = idInfo.Type;

                NodeInfo.ElementsType = idInfo.Type.ElementsType;
                NodeInfo.Fields = idInfo.Type.Fields;

                NodeInfo.ILType = idInfo.Type.ILType;
            }
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ILElementInfo lValue = cg.ILContextTable.GetDefinedVarOrFunction(VariableName);
            NodeInfo.ILType = lValue.ILType;

            if (LoadVariableInTheStack)
            {
                if (!Object.Equals(lValue.ParameterBuilder, null))
                {
                    int index = lValue.ParameterBuilder.Position - 1;
                    cg.ILGenerator.Emit(OpCodes.Ldarg, index);
                }
                else if (!Object.Equals(lValue.FieldBuilder, null))
                {
                    cg.ILGenerator.Emit(OpCodes.Ldsfld, lValue.FieldBuilder);
                }
                else if (!Object.Equals(lValue.LocalBuilder, null))
                {
                    cg.ILGenerator.Emit(OpCodes.Ldloc, lValue.LocalBuilder);
                }
            }
        }
    }
}
