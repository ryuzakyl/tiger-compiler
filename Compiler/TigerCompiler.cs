using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Reflection.Emit;

using Antlr.Runtime;

using Compiler.Errors;
using Compiler.ANTLR;
using Compiler.AST;
using Compiler.SemanticStructures;
using Compiler.CodeGenerators;

namespace Compiler
{

    /// <summary>
    /// Tiger Compiler
    /// </summary>
    public static class TigerCompiler
    {
        /// <summary>
        /// Tiger lexer of compiler
        /// </summary>
        static TigerLexer Lexer { get; set; }

        /// <summary>
        /// Tiger tokens 
        /// </summary>
        static CommonTokenStream Tokens { get; set; }

        /// <summary>
        /// Tiger parser of compiler
        /// </summary>
        static TigerParser Parser { get; set; }

        /// <summary>
        /// Resulting AST after parsing Tiger code
        /// </summary>
        public static ExpressionNode Ast { get; set; }

        /// <summary>
        /// Symbol table of compiler
        /// </summary>
        static SymbolTable SemanticSymbolTable { get; set; }

        /// <summary>
        /// Intermediate code generator of compiler
        /// </summary>
        static ILCodeGenerator CodeGenerator { get; set; }

        /// <summary>
        /// Tiger source code file name
        /// </summary>
        public static string ExecutableFileName { get; set; }

        /// <summary>
        /// Tiger source code file parent directory
        /// </summary>
        public static string ParentDirectory { get; set; }

        /// <summary>
        /// List of errors of the compilation process
        /// </summary>
        public static List<CompileError> Errors { get; set; }

        /// <summary>
        /// Compiles a file of Tiger source code
        /// </summary>
        /// <param name="filePath">Path of the source code file</param>
        /// <returns>True if compilation proccess succeded, False otherwise</returns>
        public static bool CompileFile(string filePath)
        {
            ///guardamos el nombre del fichero
            ExecutableFileName = string.Format("{0}.exe", Path.GetFileNameWithoutExtension(filePath));
          
            ///guardamos el directorio padre
            string parentDirectory = Path.GetDirectoryName(filePath);
            if (string.IsNullOrEmpty(parentDirectory))
                ParentDirectory = Environment.CurrentDirectory;
            else
                ParentDirectory = Path.GetDirectoryName(filePath);

            ///compilamos el fichero de código
            return Compile(new ANTLRFileStream(filePath));
        }

        /// <summary>
        /// Compiles a Tiger source code given as a string
        /// </summary>
        /// <param name="code">Source code</param>
        /// <returns>True if compilation proccess succeded, False otherwise</returns>
        /// <remarks>
        /// The resulting .exe file will be compiled in the compiler's
        /// directory unless specified otherwise. The file name will be
        /// code.exe
        /// </remarks>
        public static bool CompileCode(string code)
        {
            //guardamos el nombre del fichero
            ExecutableFileName = "code.exe";

            ///guardamos el directorio padre
            ParentDirectory = Environment.CurrentDirectory;

            ///compilamos el código
            return Compile(new ANTLRStringStream(code));
        }

        /// <summary>
        /// Compiles a Tiger source code
        /// </summary>
        /// <param name="input">Source code input</param>
        /// <returns>True if compilation proccess succeded, False otherwise</returns>
        private static bool Compile(ICharStream input)
        {
            ///limpiamos los errores antes del proceso de compilación
            Errors = new List<CompileError>();

            ///creamos el lexer
            Lexer = new TigerLexer(input);

            ///creamos los tokens
            Tokens = new CommonTokenStream(Lexer);

            ///creamos el parser
            Parser = new TigerParser(Tokens);
            Parser.TreeAdaptor = new TigerAdaptor();

            try
            {
                ///análisis sintáctico
                Lexer.OnLexicalErrorOcurrence += NotifyLexicError;
                Parser.OnParsingErrorOcurrence += NotifySyntacticError;
                Ast = Parser.program().Tree as ExpressionNode;

                ///en caso de que no fuera un ExpressionNode
                if (Ast == null)
                    throw new Exception("A parsing error ocurred");

                ///en caso de haber errores sintácticos
                if (Errors.Count > 0)
                    return false;

                ///creamos la tabla de símbolos
                SemanticSymbolTable = new SymbolTable();

                ///análisis semántico
                Ast.CheckSemantic(SemanticSymbolTable, Errors);

                ///en caso de haber errores semánticos
                if (Errors.Count > 0)
                    return false;

                ///generamos código
                CodeGenerator = new ILCodeGenerator(ExecutableFileName, ParentDirectory);
                CodeGenerator.OnBuildingErrorOcurrence += NotifyBuildError;
                Ast.GenerateCode(CodeGenerator);

                ///si el Ast retorna valor, lo sacamos de la pila
                if (Ast.NodeInfo.BuiltInType.IsReturnType())
                    CodeGenerator.ILGenerator.Emit(OpCodes.Pop);

                ///salvamos el ejecutable
                return CodeGenerator.SaveExecutable();
            }
            catch (RecognitionException re)
            {
                ///elaboramos el mensaje de error
                string errorMessage = Lexer.GetErrorMessage(re, Lexer.TokenNames);

                ///agregamos el error sintáctico(aunque esto es en caso de que el parser explote)
                Errors.Add(new CompileError 
                {
                    Line = re.Line,
                    Column = re.CharPositionInLine,
                    ErrorMessage = errorMessage,
                    Kind = ErrorKind.Lexic
                });

                return false;
            }
            catch (Exception e)
            {
                //change
                Errors.Add(new CompileError
                {
                    Line = 0,
                    Column = 0,
                    ErrorMessage = "Compile process terminated due to unexpected error",
                    Kind = ErrorKind.Build
                });

                return false;
            }
        }

        /// <summary>
        /// Adds a Lexic error to the errors list
        /// </summary>
        /// <param name="line">Line of error</param>
        /// <param name="column">Column of error</param>
        /// <param name="errorMessage">Message of the error</param>
        static void NotifyLexicError(int line, int column, string errorMessage)
        {
            Errors.Add(new CompileError 
            {
                Line = line,
                Column = column,
                ErrorMessage = errorMessage, 
                Kind = ErrorKind.Lexic
            });
        }

        /// <summary>
        /// Adds a Syntactic error to the errors list
        /// </summary>
        /// <param name="line">Line of error</param>
        /// <param name="column">Column of error</param>
        /// <param name="errorMessage">Message of the error</param>
        static void NotifySyntacticError(int line, int column, string errorMessage)
        {
            Errors.Add(new CompileError
            {
                Line = line,
                Column = column,
                ErrorMessage = errorMessage,
                Kind = ErrorKind.Syntactic
            });
        }

        /// <summary>
        /// Adds a Build error to the errors list
        /// </summary>
        /// <param name="line">Line of error</param>
        /// <param name="column">Column of error</param>
        /// <param name="errorMessage">Message of the error</param>
        static void NotifyBuildError(int line, int column, string errorMessage)
        {
            Errors.Add(new CompileError
            {
                Line = line,
                Column = column,
                ErrorMessage = errorMessage,
                Kind = ErrorKind.Build
            });
        }
    }
}
