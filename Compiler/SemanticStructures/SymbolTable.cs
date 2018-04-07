using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler.SemanticStructures
{
    public class SymbolTable
    {
        #region Fields
        /// <summary>
        /// Represents the current scope
        /// </summary>
        Scope currentScope;

        /// <summary>
        /// Represents the scope of built-in types and functions
        /// </summary>
        Scope globalScope;
        #endregion

        #region Constructors
        public SymbolTable()
        {
            ///inicializamos currentScope a null
            currentScope = null;

            ///inicializamos globalScope a null
            globalScope = null;

            ///creamos el globalScope
            InitNewScope();

            ///el globalScope es el 1ero que se crea
            globalScope = currentScope;

            ///agregamos los tipos predefinidos
            AddBuiltInTypes();

            ///agregamos las funciones y procedimientos predefinidos
            AddPredefinedFunctionsAndProcedures();
        } 
        #endregion

        #region Methods
        /// <summary>
        /// Creates a new scope.
        /// </summary>
        public void InitNewScope()
        {
            Scope newScope = new Scope();

            ///su padre va a ser el scope actual
            newScope.Outer = currentScope;

            ///ahora el currentScope es el newScope
            currentScope = newScope;
        }

        /// <summary>
        /// Closes the current scope
        /// </summary>
        public void CloseCurrentScope()
        {
            currentScope = currentScope.Outer;
        }

        /// <summary>
        /// Adds the Tiger built-in types to the global scope
        /// </summary>
        private void AddBuiltInTypes()
        {
            currentScope.DefineLocalType(SemanticInfo.Int);
            currentScope.DefineLocalType(SemanticInfo.String);
            currentScope.DefineLocalType(SemanticInfo.Nil);
        }

        /// <summary>
        /// Adds the Tiger built-in functions and procedures
        /// </summary>
        private void AddPredefinedFunctionsAndProcedures()
        {
            #region print(s : string)
            currentScope.DefineLocalVarOrFunction(new SemanticInfo
            {
                Name = "print",
                ElementKind = SymbolKind.Procedure,
                Args = new List<SemanticInfo> 
                { 
                    new SemanticInfo { Name = "s", Type = SemanticInfo.String , BuiltInType = BuiltInType.String } 
                },
                Type = SemanticInfo.Void,
                BuiltInType = BuiltInType.Void
            });
            #endregion

            #region printi(i : int)
            currentScope.DefineLocalVarOrFunction(new SemanticInfo
            {
                Name = "printi",
                ElementKind = SymbolKind.Procedure,
                Args = new List<SemanticInfo> 
                { 
                    new SemanticInfo { Name = "i", Type = SemanticInfo.Int, BuiltInType = BuiltInType.Int }
                },
                Type = SemanticInfo.Void,
                BuiltInType = BuiltInType.Void
            });
            #endregion

            #region flush()
            currentScope.DefineLocalVarOrFunction(new SemanticInfo
            {
                Name = "flush",
                ElementKind = SymbolKind.Procedure,
                Args = new List<SemanticInfo>(), //no arguments
                Type = SemanticInfo.Void,
                BuiltInType = BuiltInType.Void
            });
            #endregion

            #region getchar() : string
            currentScope.DefineLocalVarOrFunction(new SemanticInfo
            {
                Name = "getchar",
                ElementKind = SymbolKind.Function,
                Args = new List<SemanticInfo>(), //no arguments
                Type = SemanticInfo.String,
                BuiltInType = BuiltInType.String
            });
            #endregion
            
            #region ord(s : string) : int
            currentScope.DefineLocalVarOrFunction(new SemanticInfo
            {
                Name = "ord",
                ElementKind = SymbolKind.Function,
                Args = new List<SemanticInfo> 
                { 
                    new SemanticInfo { Name = "s" , Type = SemanticInfo.String, BuiltInType = BuiltInType.String }
                },
                Type = SemanticInfo.Int,
                BuiltInType = BuiltInType.Int
            });
            #endregion

            #region chr(i : int) : string
            currentScope.DefineLocalVarOrFunction(new SemanticInfo
            {
                Name = "chr",
                ElementKind = SymbolKind.Function,
                Args = new List<SemanticInfo> 
                { 
                    new SemanticInfo { Name = "i", Type = SemanticInfo.Int, BuiltInType = BuiltInType.Int }
                },
                Type = SemanticInfo.String,
                BuiltInType = BuiltInType.String
            });
            #endregion

            #region size(s : string) : int
            currentScope.DefineLocalVarOrFunction(new SemanticInfo
            {
                Name = "size",
                ElementKind = SymbolKind.Function,
                Args = new List<SemanticInfo> 
                { 
                    new SemanticInfo { Name = "s", Type = SemanticInfo.String, BuiltInType = BuiltInType.String }
                },
                Type = SemanticInfo.Int,
                BuiltInType = BuiltInType.Int
            });
            #endregion

            #region substring(s : string, f : int, n : int) : string
            currentScope.DefineLocalVarOrFunction(new SemanticInfo
            {
                Name = "substring",
                ElementKind = SymbolKind.Function,
                Args = new List<SemanticInfo> 
                { 
                    new SemanticInfo { Name = "s" , Type = SemanticInfo.String, BuiltInType = BuiltInType.String },
                    new SemanticInfo { Name = "f" , Type = SemanticInfo.Int, BuiltInType = BuiltInType.Int },
                    new SemanticInfo { Name = "n" , Type = SemanticInfo.Int, BuiltInType = BuiltInType.Int }
                },
                Type = SemanticInfo.String,
                BuiltInType = BuiltInType.String
            });
            #endregion

            #region concat(s1 : string, s2 : string) : string
            currentScope.DefineLocalVarOrFunction(new SemanticInfo
            {
                Name = "concat",
                ElementKind = SymbolKind.Function,
                Args = new List<SemanticInfo> 
                { 
                    new SemanticInfo { Name = "s1" , Type = SemanticInfo.String, BuiltInType = BuiltInType.String },
                    new SemanticInfo { Name = "s2" , Type = SemanticInfo.String, BuiltInType = BuiltInType.String }
                },
                Type = SemanticInfo.String,
                BuiltInType = BuiltInType.String
            });
            #endregion

            #region not(i : int) : int
            currentScope.DefineLocalVarOrFunction(new SemanticInfo
            {
                Name = "not",
                ElementKind = SymbolKind.Function,
                Args = new List<SemanticInfo> 
                { 
                    new SemanticInfo { Name = "i", Type = SemanticInfo.Int, BuiltInType = BuiltInType.Int }
                },
                Type = SemanticInfo.Int,
                BuiltInType = BuiltInType.Int
            });
            #endregion

            #region exit(i : int)
            currentScope.DefineLocalVarOrFunction(new SemanticInfo
            {
                Name = "exit",
                ElementKind = SymbolKind.Procedure,
                Args = new List<SemanticInfo> 
                { 
                    new SemanticInfo { Name = "i", Type = SemanticInfo.Int, BuiltInType = BuiltInType.Int }
                },
                Type = SemanticInfo.Void,
                BuiltInType = BuiltInType.Void
            });
            #endregion


            #region getline() : string
            currentScope.DefineLocalVarOrFunction(new SemanticInfo
            {
                Name = "getline",
                ElementKind = SymbolKind.Function,
                Args = new List<SemanticInfo>(), //no arguments
                Type = SemanticInfo.String,
                BuiltInType = BuiltInType.String
            });
            #endregion

            #region printline(s : string)
            currentScope.DefineLocalVarOrFunction(new SemanticInfo
            {
                Name = "printline",
                ElementKind = SymbolKind.Procedure,
                Args = new List<SemanticInfo> 
                { 
                    new SemanticInfo { Name = "s" , Type = SemanticInfo.String, BuiltInType = BuiltInType.String }
                },
                Type = SemanticInfo.Void,
                BuiltInType = BuiltInType.Void
            });
            #endregion

        }

        /// <summary>
        /// Inserts a new symbol in the current scope
        /// </summary>
        /// <param name="element">new element</param>
        /// <returns>True if succeded, False otherwise</returns>
        public bool InsertSymbol(SemanticInfo element)
        {
            switch (element.ElementKind)
            {
                case SymbolKind.Type:
                {
                    ///verificamos que no oculte ninguno de los BuiltIn
                    SemanticInfo builtIn;
                    if (globalScope.GetDefinedLocalType(element.Name, out builtIn))
                        return false;

                    ///lo tratamos de insertar en el scope local
                    return currentScope.DefineLocalType(element);
                }
                case SymbolKind.Variable:
                case SymbolKind.Function:
                case SymbolKind.Procedure:
                {
                    ///verificamos que no oculte ninguno de los predefinidos
                    SemanticInfo predefined;
                    if (globalScope.GetDefinedLocalVarOrFunction(element.Name, out predefined))
                        return false;

                    ///lo tratamos de insertar en el scope local 
                    return currentScope.DefineLocalVarOrFunction(element);
                }
                default:
                    return false;
            }
        }



        /// <summary>
        /// Searches for a function or procedure in the current scope or predefined
        /// </summary>
        /// <param name="callableName">function or procedure name</param>
        /// <param name="localCallable">out function or procedure</param>
        /// <returns>True if succeded, False otherwise</returns>
        public bool GetDefinedCallableShallow(string callableName, out SemanticInfo localCallable)
        {
            ///verificamos si está en el scope local
            if (currentScope.GetDefinedLocalVarOrFunction(callableName, out localCallable))
            {
                ///si nos encontramos con una función o un procedimiento
                if (localCallable.ElementKind != SymbolKind.Variable)
                    return true;
                else
                {
                    localCallable = SemanticInfo.SemanticError;
                    return false;
                }
            }

            ///verificamos si es una de las funciones o procedimientos predeterminados
            return globalScope.GetDefinedLocalVarOrFunction(callableName, out localCallable);
        }

        /// <summary>
        /// Searches for a function or procedure in the entire program
        /// </summary>
        /// <param name="callableName">function or procedure name</param>
        /// <param name="callable">out function or procedure</param>
        /// <returns>True if succeded, False otherwise</returns>
        public bool GetDefinedCallableDeep(string callableName, out SemanticInfo callable)
        {
            Scope localScope = currentScope;

            while (localScope != null)
            {
                ///se encontró en el scope local
                if (localScope.GetDefinedLocalVarOrFunction(callableName, out callable))
                {
                    ///si es función o procedimiento
                    if (callable.ElementKind != SymbolKind.Variable)
                        return true;
                }

                ///buscamos en el scope padre
                localScope = localScope.Outer;
            }

            ///no se encontró
            callable = SemanticInfo.SemanticError;
            return false;
        }

        /// <summary>
        /// Searches for a variable in the current scope or global
        /// </summary>
        /// <param name="variableName">variable name</param>
        /// <param name="localVariable">out variable</param>
        /// <returns>True if succeded, False otherwise</returns>
        public bool GetDefinedVariableShallow(string variableName, out SemanticInfo localVariable)
        {
            ///verificamos si está en el scope local
            if (currentScope.GetDefinedLocalVarOrFunction(variableName, out localVariable))
            {
                ///si lo encontrado fue una variable
                if (localVariable.ElementKind == SymbolKind.Variable)
                    return true;
                else
                {
                    localVariable = SemanticInfo.SemanticError;
                    return false;
                }
            }

            ///verificamos si es una de las variables globales(Tiger no tiene ninguna)
            return globalScope.GetDefinedLocalVarOrFunction(variableName, out localVariable);
        }

        /// <summary>
        ///  Searches for a variable in the entire program
        /// </summary>
        /// <param name="variableName">variable name</param>
        /// <param name="variable">out variable</param>
        /// <returns>True if succeded, False otherwise</returns>
        public bool GetDefinedVariableDeep(string variableName, out SemanticInfo variable)
        {
            Scope localScope = currentScope;

            while (localScope != null)
            {
                ///se encontró en el scope local
                if (localScope.GetDefinedLocalVarOrFunction(variableName, out variable))
                {
                    ///si es una variable
                    if (variable.ElementKind == SymbolKind.Variable)
                        return true;
                }

                ///buscamos en el padre
                localScope = localScope.Outer;
            }

            ///no se encontró
            variable = SemanticInfo.SemanticError;
            return false;
        }

        /// <summary>
        /// Searches for a type in the current scope or global
        /// </summary>
        /// <param name="typeName">type name</param>
        /// <param name="localType">out type</param>
        /// <returns>True if succeded, False otherwise</returns>
        public bool GetDefinedTypeShallow(string typeName, out SemanticInfo localType)
        {
            ///verificamos si está en el scope local
            if (currentScope.GetDefinedLocalType(typeName, out localType))
                return true;

            ///verificamos si es uno de los BuiltIn
            return globalScope.GetDefinedLocalType(typeName, out localType);
        }

        /// <summary>
        /// Searches for a type in the entire program
        /// </summary>
        /// <param name="typeName">type name</param>
        /// <param name="type">out type</param>
        /// <returns>True if succeded, False otherwise</returns>
        public bool GetDefinedTypeDeep(string typeName, out SemanticInfo type)
        {
            Scope localScope = currentScope;

            while (localScope != null)
            {
                ///se encontró en el scope local
                if (localScope.GetDefinedLocalType(typeName, out type))
                    return true;

                ///buscamos en el padre
                localScope = localScope.Outer;
            }

            ///no se encontró
            type = SemanticInfo.SemanticError;
            return false;
        }
        #endregion
    }
}
