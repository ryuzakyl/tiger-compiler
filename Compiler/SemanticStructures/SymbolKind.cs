using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler.SemanticStructures
{
    public enum SymbolKind
    {
        NoSymbol,
        Variable,
        Type,
        Function,
        Procedure
    }
}
