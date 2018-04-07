using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler.CodeGenerators
{
    internal class Context
    {
        #region Fields
        /// <summary>
        /// Represents the elements of the program
        /// </summary>
        Dictionary<string, ILElementInfo> types;
        Dictionary<string, ILElementInfo> varsAndFunctions;
        #endregion

        #region Constructors
        public Context(int contextNumber)
        {
            ///inicializamos el diccionario de los elementos
            types = new Dictionary<string, ILElementInfo>();

            ///inicializamos el diccionario de las variables y funciones
            varsAndFunctions = new Dictionary<string, ILElementInfo>();

            ///guardamos el número del contexto
            ContextNumber = contextNumber;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Indicates the context number
        /// </summary>
        public int ContextNumber { get; set; }

        /// <summary>
        /// Outer or parent context
        /// </summary>
        public Context Outer { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Inserts a new ILElementInfo
        /// </summary>
        /// <param name="name">id of the ILElementInfo</param>
        /// <param name="element">the ILElementInfo</param>
        /// <returns>Inserted ILElementInfo</returns>
        public ILElementInfo InsertType(string name, ILElementInfo element)
        {
            ///asumimos que no va a haber nada repetido
            types.Add(name, element);
            return element;
        }

        public ILElementInfo InsertVarOrCallable(string name, ILElementInfo element)
        {
            ///asumimos que no va a haber nada repetido
            varsAndFunctions.Add(name, element);
            return element;
        }

        /// <summary>
        /// Search an ILElementInfo
        /// </summary>
        /// <param name="name">ILElementInfo's id</param>
        /// <returns>the ILElementInfo</returns>
        public ILElementInfo GetDefinedType(string name)
        {
            if (types.ContainsKey(name))
                return types[name];

            return null;
        }

        public ILElementInfo GetDefinedVarOrFunction(string name)
        {
            if (varsAndFunctions.ContainsKey(name))
                return varsAndFunctions[name];

            return null;
        }
        #endregion
    }
}
