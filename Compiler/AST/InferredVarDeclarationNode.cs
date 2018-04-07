using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.Errors;
using Compiler.CodeGenerators;

namespace Compiler.AST
{
    public class InferredVarDeclarationNode : VarDeclarationNode
    {
        SemanticInfo inferredParche;

        public InferredVarDeclarationNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// Initialization expression
        /// </summary>
        public ExpressionNode InitExpression
        {
            get { return GetChild(1) as ExpressionNode; }
        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///check semantics al VarDeclarationNode
            base.CheckSemantic(symbolTable, errors);

            ///check semantics al InitExpression
            InitExpression.CheckSemantic(symbolTable, errors);

            ///si InitExpression evalúa de error este también
            if (Object.Equals(InitExpression.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            ///si InitExpression tiene tipo 'nil'
            if (InitExpression.NodeInfo.BuiltInType == BuiltInType.Nil)
            {
                errors.Add(new CompileError
                {
                    Line = InitExpression.Line,
                    Column = InitExpression.CharPositionInLine,
                    ErrorMessage = "Cannot assign nil to an implicitly-typed local variable",
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            ///si no hubo error seteamos los campos necesarios
            if (!Object.Equals(NodeInfo, SemanticInfo.SemanticError))
            {
                NodeInfo.Type = SemanticInfo.Void;
                NodeInfo.BuiltInType = BuiltInType.Void;
            }

            SemanticInfo variable = new SemanticInfo
            {
                Name = VariableName,
                ElementKind = SymbolKind.Variable,
                BuiltInType = InitExpression.NodeInfo.BuiltInType,
                
                ElementsType = InitExpression.NodeInfo.ElementsType,
                Fields = InitExpression.NodeInfo.Fields,
             
                Type = InitExpression.NodeInfo.Type.Type,
                ILType = InitExpression.NodeInfo.ILType
            };

            ///seteamos el ILType del NodeInfo
            NodeInfo.ILType = InitExpression.NodeInfo.ILType;

            inferredParche = InitExpression.NodeInfo.Type;

            ///agregamos la variable a la tabla de símbolos
            symbolTable.InsertSymbol(variable);

        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            Type variableType;

            variableType = inferredParche.ILType;

            VariableLocalBuilder = cg.ILGenerator.DeclareLocal(variableType);

            string varName = string.Format("{0}{1}", VariableName, cg.ILContextTable.ContextNumber);
            FieldBuilder fd = cg.Program.DefineField(varName, variableType, FieldAttributes.Private | FieldAttributes.Static);

            VariableFieldBuilder = fd;

            cg.ILContextTable.InsertILElement(VariableName, new ILElementInfo { FieldBuilder = fd, ILType = variableType , ElementKind = SymbolKind.Variable});

            ILElementInfo varInfo = cg.ILContextTable.GetDefinedVarOrFunction(VariableName);

            cg.ILGenerator.Emit(OpCodes.Ldsfld, varInfo.FieldBuilder);
            cg.ILGenerator.Emit(OpCodes.Stloc, VariableLocalBuilder);

            InitExpression.GenerateCode(cg);

            ///este usa el static field porque el campo es estático
            cg.ILGenerator.Emit(OpCodes.Stsfld, varInfo.FieldBuilder);
        }
    }
}
