using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using Compiler.SemanticStructures;

namespace Compiler.CodeGenerators
{
    /// <summary>
    /// Structure similar to SymbolTable
    /// </summary>
    public class ContextTable
    {
        #region Fields
        /// <summary>
        /// Represents the current context
        /// </summary>
        Context currentContext;

        /// <summary>
        /// Represents the global context
        /// </summary>
        Context globalContext;

        /// <summary>
        /// Represents an identity field(like databases)
        /// </summary>
        int identityNumber;
        #endregion

        #region Constructors
        public ContextTable()
        {
            ///inicializamos el currentContext a null
            currentContext = null;

            ///inicializamos el globalContext a null
            globalContext = null;

            ///inicializamos el identityNumber
            identityNumber = 0;

            ///creamos un nuevo contexto
            InitNewContext();

            ///el globalContext es inicialmente igual al currentContext
            globalContext = currentContext;

            ///creamos el tipo 'int'
            globalContext.InsertType("int", new ILElementInfo { ILType = typeof(int) });

            //creamos el tipo 'string'
            globalContext.InsertType("string", new ILElementInfo { ILType = typeof(string) });
        } 
        #endregion

        #region Methods
        /// <summary>
        /// Creates a new context
        /// </summary>
        public void InitNewContext()
        {
            ///creamos el nuevo contexto
            Context newContext = new Context(identityNumber);
            

            ///incrementamos el identity
            identityNumber++;

            ///el padre de el nuevo contexto es el actual
            newContext.Outer = currentContext;

            ///actualizamos el contexto actual
            currentContext = newContext;
        }

        /// <summary>
        /// Closes the current context
        /// </summary>
        public void CloseCurrentContext()
        {
            currentContext = currentContext.Outer;
        }

        /// <summary>
        /// Inserts a ILElementInfo in the context table
        /// </summary>
        /// <param name="name">name of the element</param>
        /// <param name="element">element to insert</param>
        /// <returns>the inserted element</returns>
        public ILElementInfo InsertILElement(string name, ILElementInfo element)
        {
            switch (element.ElementKind)
            {
                case SymbolKind.Type:
                    return currentContext.InsertType(name, element);

                case SymbolKind.Variable:
                case SymbolKind.Function:
                case SymbolKind.Procedure:
                    return currentContext.InsertVarOrCallable(name, element);
                default:
                    return null; 
            }
        }

        public ILElementInfo InsertPredefinedCallable(string name, ILElementInfo element)
        {
            globalContext.InsertVarOrCallable(name, element);
            return element;
        }

        /// <summary>
        /// Retrieves an ILElementInfo
        /// </summary>
        /// <param name="name">ILElementInfo name</param>
        /// <returns>the ILElementInfo</returns>
        public ILElementInfo GetDefinedType(string name)
        {
            ILElementInfo result;

            Context localContext = currentContext;

            while (localContext != null)
            {
                ///si lo encontramos en el contexto local
                if ((result = localContext.GetDefinedType(name)) != null)
                    return result;

                ///lo buscamos en el padre
                localContext = localContext.Outer;
            }

            ///no se encontró
            return null;
        }

        public ILElementInfo GetDefinedVarOrFunction(string name)
        {
            ILElementInfo result;

            Context localContext = currentContext;

            while (localContext != null)
            {
                ///si lo encontramos en el contexto local
                if ((result = localContext.GetDefinedVarOrFunction(name)) != null)
                    return result;

                ///lo buscamos en el padre
                localContext = localContext.Outer;
            }

            ///no se encontró
            return null;
        }

        #endregion

        public int ContextNumber 
        {
            get { return currentContext.ContextNumber; } 
        }
    }
}
