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
    public abstract class CallableDeclarationNode : DeclarationNode
    {
        #region Fields
        protected List<KeyValuePair<string, string>> parameter;
        protected List<SemanticInfo> parametersType;
        protected List<Type> ILTypes; 
        #endregion

        public CallableDeclarationNode(IToken token) : base(token)
        {
            parametersType = new List<SemanticInfo>();
            ILTypes = new List<Type>();

            FirstPass = true;
        }

        /// <summary>
        /// Function or procedure Id
        /// </summary>
        public string CallableId
        {
            get { return GetChild(0).Text; }
        }

        /// <summary>
        /// List of parameters
        /// </summary>
        public List<KeyValuePair<string, string>> Parameters
        {
            get
            {
                if (parameter == null)
                {
                    parameter = new List<KeyValuePair<string, string>>();
                    int paramCount = (ChildCount - 2) / 2;
                    for (int i = 0; i < paramCount; i++)
                    {
                        parameter.Add(new KeyValuePair<string, string>(GetChild(2 * i + 1).Text, GetChild(2 * i + 2).Text));
                    }
                }

                return parameter;
            }
        }

        /// <summary>
        /// Body of function or procedure
        /// </summary>
        public ExpressionNode CallableBody
        {
            get { return GetChild(ChildCount - 1) as ExpressionNode; }
        }

        /// <summary>
        /// Indicates if is the first pass processing this node
        /// </summary>
        public bool FirstPass { get; set; }

        public override void CheckSignatureSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            SemanticInfo callableInfo;

            ///en el mismo scope no puede haber otro callable con el mismo nombre
            if (symbolTable.GetDefinedCallableShallow(CallableId, out callableInfo))
            {
                errors.Add(new CompileError
                {
                    Line = this.Line,
                    Column = this.CharPositionInLine,
                    ErrorMessage = string.Format("Current context already contains a definition for '{0}'", CallableId),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            SemanticInfo arg;

            ///chequeamos que los tipos de los parámetros esten definidos
            for (int i = 0; i < Parameters.Count; i++)
            {
                if (!symbolTable.GetDefinedTypeDeep(Parameters[i].Value, out arg))
                {
                    errors.Add(new CompileError
                    {
                        Line = GetChild(2 * i + 2).Line,
                        Column = GetChild(2 * i + 2).CharPositionInLine,
                        ErrorMessage = string.Format("Type '{0}' could not be found in current context", Parameters[i].Value),
                        Kind = ErrorKind.Semantic
                    });
                }
                else
                    parametersType.Add(arg.Type); //esto es uno de los ultimos cambios

                ///chequeamos que no hay parámetros con el mismo nombre
                for (int j = 0; j < i; j++)
                {
                    if (Parameters[i].Key.Equals(Parameters[j].Key))
                    {
                        errors.Add(new CompileError
                        {
                            Line = GetChild(2 * i + 1).Line,
                            Column = GetChild(2 * i + 1).CharPositionInLine,
                            ErrorMessage = string.Format("The parameter name '{0}' is a duplicate", Parameters[i].Key),
                            Kind = ErrorKind.Semantic
                        });
                    }
                }
            }

        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            SemanticInfo variableInfo;

            ///chequeamos que no haya una variable con el mismo nombre
            if (symbolTable.GetDefinedVariableShallow(CallableId, out variableInfo))
            {
                errors.Add(new CompileError
                {
                    Line = GetChild(ChildCount - 2).Line,
                    Column = GetChild(ChildCount - 2).CharPositionInLine,
                    ErrorMessage = string.Format("There is already a definition for '{0}' in current context", CallableId),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            ///creamos el scope de la función o procedimiento
            symbolTable.InitNewScope();

            SemanticInfo param;

            ///agregamos los parámetros de la función o procedimiento al scope
            for (int i = 0; i < Parameters.Count; i++)
            {
                param = new SemanticInfo
                {
                    Name = Parameters[i].Key,
                    ElementKind = SymbolKind.Variable,
                    BuiltInType = parametersType[i].BuiltInType,
                    Type = parametersType[i],
                    ElementsType = parametersType[i].ElementsType,
                    Fields = parametersType[i].Fields
                };

                symbolTable.InsertSymbol(param);
            }

            ///check semantics al CallableBody
            CallableBody.CheckSemantic(symbolTable, errors);

            ///destruimos el scope de la función o procedimiento
            symbolTable.CloseCurrentScope();
        }

        Type returnILType;

        public override void GenerateCode(ILCodeGenerator cg)
        {
            if (FirstPass)
            {
                if (this is FunctionDeclarationNode)
                {
                    ILElementInfo returnILElementInfo = cg.ILContextTable.GetDefinedType((this as FunctionDeclarationNode).ReturnType);
                    returnILType = returnILElementInfo.ILType;

                    if (Object.Equals(returnILType, null)) 
                        returnILType = (this as FunctionDeclarationNode).functionParche.ILType;
                }

                for (int i = 0; i < ILTypes.Count; i++)
                {
                    if (Object.Equals(ILTypes[i], null)) 
                    {
                        ILTypes[i] = parametersType[i].Type.ILType;
                    }
                }

                ///creamos un método estático en la clase Program
                string callableName = string.Format("{0}{1}", CallableId, cg.ILContextTable.ContextNumber);
                MethodBuilder callable = cg.Program.DefineMethod(callableName, MethodAttributes.Private | MethodAttributes.Static, returnILType, ILTypes.ToArray());
                
                ///lo insertamos el la tabla de contextos
                cg.ILContextTable.InsertILElement(CallableId, new ILElementInfo { MethodBuilder = callable , ElementKind = SymbolKind.Function });
                
                ///ya no va a ser la 1era pasada
                FirstPass = false;
            }
            else
            {
                ILElementInfo callable = cg.ILContextTable.GetDefinedVarOrFunction(CallableId);

                MethodBuilder callableBuilder = callable.MethodBuilder;

                ILGenerator tmpIL = cg.ILGenerator;
                cg.ILGenerator = callableBuilder.GetILGenerator();

                ///creamos un nuevo contexto
                cg.ILContextTable.InitNewContext();

                List<LocalBuilder> localSaving = new List<LocalBuilder>();

                ///creamos los parámetros y variables en la clase Program
                for (int i = 0; i < Parameters.Count; i++)
                {
                    ParameterBuilder pb = callableBuilder.DefineParameter(i + 1, ParameterAttributes.None, Parameters[i].Key);

                    string parameterName = string.Format("{0}{1}", Parameters[i].Key, cg.ILContextTable.ContextNumber);
                    FieldBuilder fb = cg.Program.DefineField(parameterName, ILTypes[i], FieldAttributes.Public | FieldAttributes.Static);
                    cg.ILContextTable.InsertILElement(Parameters[i].Key, new ILElementInfo { FieldBuilder = fb , ElementKind = SymbolKind.Variable});
                }

                //salvamos los valores de las variables de la clase
                for (int i = 0; i < Parameters.Count; i++)
                {
                    localSaving.Add(cg.ILGenerator.DeclareLocal(ILTypes[i]));
                    callable = cg.ILContextTable.GetDefinedVarOrFunction(Parameters[i].Key);
                    cg.ILGenerator.Emit(OpCodes.Ldsfld, callable.FieldBuilder);
                    cg.ILGenerator.Emit(OpCodes.Stloc, localSaving[i]);
                }

                ///cargando los argumentos
                for (int i = 0; i < Parameters.Count; i++)
                {
                    callable = cg.ILContextTable.GetDefinedVarOrFunction(Parameters[i].Key);
                    cg.ILGenerator.Emit(OpCodes.Ldarg, i);
                    cg.ILGenerator.Emit(OpCodes.Stsfld, callable.FieldBuilder);
                }

                ///gen code al body de la función o procedimiento
                CallableBody.GenerateCode(cg);

                bool isFunction = this is FunctionDeclarationNode;
                LocalBuilder returnValue = null;

                ///en caso de ser función
                if (isFunction)
                {
                    returnValue = cg.ILGenerator.DeclareLocal(returnILType);
                    cg.ILGenerator.Emit(OpCodes.Stloc, returnValue);
                }

                ///restauramos los valores de las variables de la clase
                for (int i = 0; i < Parameters.Count; i++)
                {
                    callable = cg.ILContextTable.GetDefinedVarOrFunction(Parameters[i].Key);
                    cg.ILGenerator.Emit(OpCodes.Ldloc, localSaving[i]);
                    cg.ILGenerator.Emit(OpCodes.Stsfld, callable.FieldBuilder);
                }
                List<KeyValuePair<LocalBuilder, FieldBuilder>> localvars = CallableBody.GetLocalVariableDeclarations();
                foreach (var item in localvars)
                {
                    cg.ILGenerator.Emit(OpCodes.Ldloc, item.Key);
                    cg.ILGenerator.Emit(OpCodes.Stsfld, item.Value);
                }
                

                ///destruimos el contexto de la función o procedimiento
                cg.ILContextTable.CloseCurrentContext();

                ///si es función ponemos en el tope de la pila el valor de retorno
                if (isFunction)
                    cg.ILGenerator.Emit(OpCodes.Ldloc, returnValue);

                ///emitimos el return de la función
                cg.ILGenerator.Emit(OpCodes.Ret);

                ///restauramos el ILGenerator del cg
                cg.ILGenerator = tmpIL;
            }
        }
    }
}
