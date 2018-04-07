using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler.SemanticStructures
{
    /// <summary>
    /// Represents the Tiger language built-in types
    /// </summary>
    public enum BuiltInType
    {
        None,
        Void,
        Int,
        String,
        Record,
        Array,
        Nil
    }

    /// <summary>
    /// BuiltInType extensors
    /// </summary>
    public static class BuiltInTypeExtensors
    {
        /// <summary>
        /// Determines if a BuiltInType is a return type
        /// </summary>
        /// <param name="type">Built-in type</param>
        /// <returns>True if 'type' is a return type, False otherwise</returns>
        public static bool IsReturnType(this BuiltInType type)
        {
            switch (type)
            {
                case BuiltInType.Array:
                case BuiltInType.Int:
                case BuiltInType.Record:
                case BuiltInType.String:
                    return true;

                ///el resto de los tipos no retornan valor
                default:
                    return false;
            }
        }

        /// <summary>
        /// Determines if two BuiltInType are compatibles
        /// </summary>
        /// <param name="firstType">First built-in type</param>
        /// <param name="secondType">Second built-in type</param>
        /// <returns>True if 'firstType' is compatible with 'secondType', False otherwise</returns>
        public static bool IsCompatibleWith(this BuiltInType firstType, BuiltInType secondType)
        {
            return AreCompatibleTypes(firstType, secondType);
        }

        /// <summary>
        /// Determines if two BuiltInType are compatibles
        /// </summary>
        /// <param name="firstType">First built-in type</param>
        /// <param name="secondType">Second built-in type</param>
        /// <returns>True if 'firstType' is compatible with 'secondType', False otherwise</returns>
        private static bool AreCompatibleTypes(BuiltInType firstType, BuiltInType secondType)
        {
            switch (firstType)
            {
                case BuiltInType.Array:
                    return secondType == BuiltInType.Array || secondType == BuiltInType.Nil;
                case BuiltInType.Int:
                    return secondType == BuiltInType.Int;
                case BuiltInType.Nil:
                    return secondType == BuiltInType.Nil || secondType == BuiltInType.Array || secondType == BuiltInType.Record || secondType == BuiltInType.String;
                case BuiltInType.None:
                    return secondType == BuiltInType.None;
                case BuiltInType.Record:
                    return secondType == BuiltInType.Record || secondType == BuiltInType.Nil;
                case BuiltInType.String:
                    return secondType == BuiltInType.String || secondType == BuiltInType.Nil;
                case BuiltInType.Void:
                    return secondType == BuiltInType.Void;
                default:
                    return false;
            }
        }
    }
}
