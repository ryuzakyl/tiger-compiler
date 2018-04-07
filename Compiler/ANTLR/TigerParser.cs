using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;
using Compiler.Errors;

namespace Compiler.ANTLR
{
    /// <summary>
    /// Tiger language parser
    /// </summary>
    public class TigerParser : TigerGrammarParser
    {
        /// <summary>
        /// Fired when Syntactic error ocurrs
        /// </summary>
        public event CompileErrorOcurrence OnParsingErrorOcurrence;

        public TigerParser(ITokenStream input) : base(input) { }

        public override void ReportError(RecognitionException e)
        {
            base.ReportError(e);

            string errorMessage = GetErrorMessage(e, this.TokenNames);

            if (OnParsingErrorOcurrence != null)
                OnParsingErrorOcurrence(e.Line, e.CharPositionInLine, errorMessage);
        }
    }
}
