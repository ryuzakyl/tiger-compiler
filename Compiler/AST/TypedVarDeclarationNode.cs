using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using Antlr.Runtime;
using Antlr.Runtime.Tree;

using Compiler.SemanticStructures;
using Compiler.Errors;
using Compiler.CodeGenerators;



namespace Compiler.AST
{
    public class TypedVarDeclarationNode : VarDeclarationNode
    {
        public TypedVarDeclarationNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// Id of the type of the variable
        /// </summary>
        public string VarTypeId
        {
            get { return VarType.Text; }
        }

        /// <summary>
        /// Type of the variable
        /// </summary>
        private ITree VarType
        {
            get { return GetChild(1); }
        }

        /// <summary>
        /// Initialization expression
        /// </summary>
        public ExpressionNode InitExpression
        {
            get { return GetChild(ChildCount - 1) as ExpressionNode; }
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

            SemanticInfo typeInfo;

            ///el tipo de la variable tiene que estar definido
            if (!symbolTable.GetDefinedTypeDeep(VarTypeId, out typeInfo))
            {
                errors.Add(new CompileError
                {
                    Line = VarType.Line,
                    Column = VarType.CharPositionInLine,
                    ErrorMessage = string.Format("Type '{0}' could not be found in current context", VarTypeId),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            ///si existe el tipo de la variable
            if (!Object.Equals(typeInfo, SemanticInfo.SemanticError))
            {
                ///el tipo de InitExpression y VarTypeId tienen que ser compatibles
                if (!InitExpression.NodeInfo.Type.IsCompatibleWith(typeInfo.Type))
                {
                    errors.Add(new CompileError
                    {
                        Line = VarType.Line,
                        Column = VarType.CharPositionInLine,
                        ErrorMessage = string.Format("Cannot implicitly convert type '{0}' to '{1}'", InitExpression.NodeInfo.Type.Name, VarTypeId),
                        Kind = ErrorKind.Semantic
                    });

                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }
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
                BuiltInType = typeInfo.BuiltInType,
                Type = typeInfo.Type,

                ElementsType = typeInfo.ElementsType,
                Fields = typeInfo.Fields 
            };

            ///guardamos el ILType en el NodeInfo
            NodeInfo.ILType = InitExpression.NodeInfo.ILType;

            ///agregamos la variable a la tabla de símbolos
            symbolTable.InsertSymbol(variable);
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ILElementInfo varTypeInfo = cg.ILContextTable.GetDefinedType(VarTypeId);
            Type variableType = null;

            if (varTypeInfo.TypeBuilder != null)
                variableType = varTypeInfo.TypeBuilder;
            else if (varTypeInfo.ILType != null)
                variableType = varTypeInfo.ILType;
            else if (InitExpression is NilConstantNode)
                variableType = typeof(string);
            else
                variableType = NodeInfo.ILType;

            if (InitExpression is ArrayCreationNode) 
                variableType = InitExpression.NodeInfo.ILType;

            VariableLocalBuilder = cg.ILGenerator.DeclareLocal(variableType);

            string varName = string.Format("{0}{1}", VariableName, cg.ILContextTable.ContextNumber);
            FieldBuilder fd = cg.Program.DefineField(varName, variableType, FieldAttributes.Private | FieldAttributes.Static);
            
            //change
            VariableFieldBuilder = fd;

            cg.ILContextTable.InsertILElement(VariableName, new ILElementInfo { FieldBuilder = fd, ILType = variableType , ElementKind = SymbolKind.Variable});

            ILElementInfo variableElementInfo = cg.ILContextTable.GetDefinedVarOrFunction(VariableName);

            cg.ILGenerator.Emit(OpCodes.Ldsfld, variableElementInfo.FieldBuilder);
            cg.ILGenerator.Emit(OpCodes.Stloc, VariableLocalBuilder);

            InitExpression.GenerateCode(cg);

            //este usa el static field porque el campo es estatico
            cg.ILGenerator.Emit(OpCodes.Stsfld, variableElementInfo.FieldBuilder);
        }

        
    }
}
