using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler.SemanticStructures
{
    /// <summary>
    /// Represents any semantic information
    /// </summary>
    public class SemanticInfo
    {
        #region Fields

        /// <summary>
        /// Represents a semantic error element
        /// </summary>
        public static SemanticInfo SemanticError = new SemanticInfo 
        { 
            Name = "",
            ElementKind = SymbolKind.NoSymbol, 
            BuiltInType = BuiltInType.None 
        };

        /// <summary>
        /// Represents the built-in type 'int'
        /// </summary>
        public static SemanticInfo Int = new SemanticInfo
        {
            Name = "int",
            ElementKind = SymbolKind.Type,
            BuiltInType = BuiltInType.Int,
            ILType = typeof(int)
        };

        /// <summary>
        /// Represents the built-in type 'string'
        /// </summary>
        public static SemanticInfo String = new SemanticInfo
        {
            Name = "string",
            ElementKind = SymbolKind.Type,
            BuiltInType = BuiltInType.String,
            ILType = typeof(string)
        };

        /// <summary>
        /// Represents the built-in type 'nil'
        /// </summary>
        public static SemanticInfo Nil = new SemanticInfo
        {
            Name = "nil",
            ElementKind = SymbolKind.Type,
            BuiltInType = BuiltInType.Nil,
            ILType = null
        };

        /// <summary>
        /// Represents the built-in type 'void'
        /// </summary>
        public static SemanticInfo Void = new SemanticInfo
        {
            Name = "void",
            ElementKind = SymbolKind.Type,
            BuiltInType = BuiltInType.Void,
            ILType = typeof(void)
        };

        /// <summary>
        /// Represents an element with no name
        /// </summary>
        public static string NoName = "noName";

        /// <summary>
        /// Represents the .NET Type of the semantic information
        /// </summary>
        Type ilType;

        #endregion

        #region Constructors

        public SemanticInfo()
        {
            Name = NoName;
            ElementKind = SymbolKind.NoSymbol;
        }

        static SemanticInfo()
        {
            Int.Type = Int;
            String.Type = String;
            Nil.Type = Nil;
            Void.Type = Void;
        }

        #endregion

        #region Properties

        /// <summary>
        /// List of arguments of a function or procedure
        /// </summary>
        public List<SemanticInfo> Args { get; set; }

        /// <summary>
        /// Represents built-in type of this information
        /// </summary>
        public BuiltInType BuiltInType { get; set; }

        /// <summary>
        /// Kind of the information
        /// </summary>
        /// <remarks>It could be: Variable, Function, Type, etc</remarks>
        public SymbolKind ElementKind { get; set; }

        /// <summary>
        /// Represents the Type of the elements of an array
        /// </summary>
        /// <remarks>Only used for arrays</remarks>
        public SemanticInfo ElementsType { get; set; }

        /// <summary>
        /// Represents the fields of a record
        /// </summary>
        /// <remarks>Only used for records</remarks>
        public List<KeyValuePair<string, SemanticInfo>> Fields { get; set; }

        /// <summary>
        /// Represents the .NET Type of the semantic information
        /// </summary>
        public Type ILType
        {
            get
            {
                ///si es array con sus elementos seteados
                if (ElementsType != null && ElementsType.ILType != null)
                    return ElementsType.ILType.MakeArrayType();

                return ilType;
            }
            set { ilType = value; }
        }

        /// <summary>
        /// Determines wheter certain semantic information is complete.
        /// </summary>
        public bool IsPending { get; set; }

        /// <summary>
        /// Indicates if the semantic element is readonly
        /// </summary>
        /// <remarks>Only used for variables</remarks>
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// Name of the semantic information
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Number of arguments of a function or procedure
        /// </summary>
        public int nArgs 
        {
            get { return (Args == null)? 0 : Args.Count; }
        }

        /// <summary>
        /// Type of the element.
        /// </summary>
        public SemanticInfo Type { get; set; }
        #endregion
    }

    public static class ElementInfoExtensions
    {
        /// <summary>
        /// Determines if two elements of type SemanticInfo are compatibles
        /// </summary>
        /// <param name="element">First SemanticInfo element</param>
        /// <param name="other">Second SemanticInfo element</param>
        /// <returns>True if the elements are compatible, False otherwise</returns>
        public static bool IsCompatibleWith(this SemanticInfo element, SemanticInfo other)
        {
            ///si ambos son arrays
            if (element.BuiltInType == BuiltInType.Array && other.BuiltInType == BuiltInType.Array)
                return Object.Equals(element.Type, other.Type);

            ///si ambos son record
            if (element.BuiltInType == BuiltInType.Record && other.BuiltInType == BuiltInType.Record)
                return Object.Equals(element.Type, other.Type);

            ///en caso contrario retornamos la compatibilidad de los tipos BuiltIn
            return element.BuiltInType.IsCompatibleWith(other.BuiltInType);
        }
    }

}
