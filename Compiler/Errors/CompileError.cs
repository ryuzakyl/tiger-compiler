using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler.Errors
{
    /// <summary>
    /// Represents an error of the compilation process
    /// </summary>
    public class CompileError
    {

        /// <summary>
        /// Line of error
        /// </summary>
        public int Line { get; set; }

        /// <summary>
        /// Column of error
        /// </summary>
        public int Column { get; set; }

        /// <summary>
        /// Message of error
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Kind of error
        /// </summary>
        public ErrorKind Kind { get; set; }

        /// <summary>
        /// CompileError ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("({0},{1}): {2}", Line, Column, ErrorMessage);
        }
    }
}
