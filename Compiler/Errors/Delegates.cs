using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler.Errors
{
    public delegate void CompileErrorOcurrence(int line, int column, string errorMessage);
}
