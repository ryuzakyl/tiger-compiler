using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;
using Compiler.Errors;

namespace Compiler.ANTLR
{
    /// <summary>
    /// Tiger language lexer
    /// </summary>
    public class TigerLexer : TigerGrammarLexer
    {
        /// <summary>
        /// Fired when Lexic error ocurrs
        /// </summary>
        public event CompileErrorOcurrence OnLexicalErrorOcurrence;

        public TigerLexer(ICharStream input) : base(input) { }

        public override void ReportError(RecognitionException e)
        {
            base.ReportError(e);

            string errorMessage = GetErrorMessage(e, this.TokenNames);

            if (OnLexicalErrorOcurrence != null)
                OnLexicalErrorOcurrence(e.Line, e.CharPositionInLine, errorMessage);
        }
    }
}
