using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;
using System.Reflection;

using Compiler.SemanticStructures;

namespace Compiler.CodeGenerators
{
    public class ILElementInfo
    {
        public ILElementInfo()
        {
            FieldsOfContainerClass = new List<FieldBuilder>();
        }

        #region Properties
        /// <summary>
        /// Kind of the information
        /// </summary>
        /// <remarks>It could be: Variable, Function, Type, etc</remarks>
        public SymbolKind ElementKind { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        public TypeBuilder TypeBuilder { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        public ConstructorBuilder ContainerClassConstructor { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        public FieldBuilder FieldBuilder { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        public List<FieldBuilder> FieldsOfContainerClass { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        public MethodBuilder MethodBuilder { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        public Type ILType { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        public LocalBuilder LocalBuilder { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        public ParameterBuilder ParameterBuilder { get; set; }
        #endregion
    }
}
