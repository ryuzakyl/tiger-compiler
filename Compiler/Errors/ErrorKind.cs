using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler.Errors
{
    public enum ErrorKind
    {
        Lexic,
        Syntactic,
        Semantic,
        Build,
        Unknown
    }
}
