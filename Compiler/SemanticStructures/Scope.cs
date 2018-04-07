using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler.SemanticStructures
{
    internal class Scope
    {
        #region Fields

        /// <summary>
        /// Declared types
        /// </summary>
        Dictionary<string, SemanticInfo> declaredTypes;

        /// <summary>
        /// Declared vars and functions
        /// </summary>
        Dictionary<string, SemanticInfo> declaredVarsAndFunctions; 

        #endregion

        #region Constructors
        
        public Scope()
        {
            declaredTypes = new Dictionary<string, SemanticInfo>();
            declaredVarsAndFunctions = new Dictionary<string, SemanticInfo>();

            Outer = null;
        } 

        #endregion

        #region Properties

        /// <summary>
        /// Represents the 'parent' or 'outer' scope
        /// </summary>
        public Scope Outer { get; set; } 

        #endregion

        #region Types

        /// <summary>
        /// Declares a new type in the current scope
        /// </summary>
        /// <param name="type">new type</param>
        /// <returns>True if succeded, False otherwise</returns>
        public bool DefineLocalType(SemanticInfo type)
        {
            SemanticInfo localType;
            
            ///si ya ha sido definido un tipo con ese nombre
            if (GetDefinedLocalType(type.Name, out localType))
                return false;

            ///lo agregamos a los tipos declarados
            declaredTypes.Add(type.Name, type);
            return true;
        }

        /// <summary>
        /// Search for an existing type
        /// </summary>
        /// <param name="typeName">type name</param>
        /// <param name="localType">stores the type at this out parameter</param>
        /// <returns>True if the type exists, False otherwise</returns>
        public bool GetDefinedLocalType(string typeName, out SemanticInfo localType)
        {
            ///en caso de que no existe
            if (!declaredTypes.ContainsKey(typeName))
            {
                localType = SemanticInfo.SemanticError;
                return false;
            }

            ///lo buscamos en el diccionario
            localType = declaredTypes[typeName];
            return true;
        }

        #endregion

        #region Vars and Functions

        /// <summary>
        /// Declares a new variable or function in the current scope
        /// </summary>
        /// <param name="varOrFunction">new var or function</param>
        /// <returns></returns>
        public bool DefineLocalVarOrFunction(SemanticInfo varOrFunction)
        {
            SemanticInfo localVarOrFunction;

            ///si ya ha sido definida una variable o función con ese nombre
            if (GetDefinedLocalVarOrFunction(varOrFunction.Name, out localVarOrFunction))
                return false;

            ///lo agregamos a las variables y funciones declaradas
            declaredVarsAndFunctions.Add(varOrFunction.Name, varOrFunction);
            return true;
        }

        /// <summary>
        /// Search for an existing var or function
        /// </summary>
        /// <param name="varOrFunctionName">var or function name</param>
        /// <param name="localVarOrFunction">stores the var or function at this out parameter</param>
        /// <returns>True if var or function exists, False otherwise</returns>
        public bool GetDefinedLocalVarOrFunction(string varOrFunctionName, out SemanticInfo localVarOrFunction)
        {
            ///en caso de que no existe
            if (!declaredVarsAndFunctions.ContainsKey(varOrFunctionName))
            {
                localVarOrFunction = SemanticInfo.SemanticError;
                return false;
            }

            ///lo buscamos en el diccionario
            localVarOrFunction = declaredVarsAndFunctions[varOrFunctionName];
            return true;
        }

        #endregion
    }
}
