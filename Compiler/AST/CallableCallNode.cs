using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;

using Antlr.Runtime;
using Antlr.Runtime.Tree;

using Compiler.SemanticStructures;
using Compiler.Errors;
using Compiler.CodeGenerators;

using System.Reflection;
using System.IO;

namespace Compiler.AST
{
    public class CallableCallNode : AssignableExpressionNode
    {
        public CallableCallNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// Represents the callable element
        /// </summary>
        private ITree Callable
        {
            get { return GetChild(0); }
        }

        /// <summary>
        /// Id of the function or procedure
        /// </summary>
        public string CallableId
        {
            get { return Callable.Text; }
        }

        /// <summary>
        /// Arguments count
        /// </summary>
        private int ArgsCount
        {
            get { return this.ChildCount - 1; }
        }

        /// <summary>
        /// Gets a parameter of the function or procedure 
        /// </summary>
        /// <param name="i">parameter index</param>
        /// <returns>the parameter</returns>
        /// <remarks>Index starts at 1</remarks>
        private ExpressionNode ArgAt(int i)
        {
            return this.GetChild(i) as ExpressionNode;
        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            SemanticInfo callableInfo;

            ///la función o procedimiento tiene que estar declarada(o)
            if (!symbolTable.GetDefinedCallableDeep(CallableId, out callableInfo))
            {
                errors.Add(new CompileError
                {
                    Line = Callable.Line,
                    Column = Callable.CharPositionInLine,
                    ErrorMessage = string.Format("The name '{0}' could not be found in current context", CallableId),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            ///la cantidad de argumentos tiene que coincidir con los de su declaración
            if (callableInfo.Args.Count != ArgsCount)
            {
                errors.Add(new CompileError
                {
                    Line = this.Line,
                    Column = this.CharPositionInLine,
                    ErrorMessage = string.Format("No overload for {0} '{1}' takes {2} arguments", (callableInfo.ElementKind == SymbolKind.Function) ? "function" : "procedure", CallableId, ArgsCount),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            
            ExpressionNode currentArg;
            ///los tipos de los argumentos tienen que coincidir con los de su definición
            for (int i = 0; i < ArgsCount; i++)
            {
                ///obtenemos el i-ésimo argumento
                currentArg = ArgAt(i + 1);

                ///check semantics a currentArg
                currentArg.CheckSemantic(symbolTable, errors);

                ///si currentArg no evaluó de error
                if (!Object.Equals(currentArg.NodeInfo, SemanticInfo.SemanticError))
                {
                    ///si no coinciden los tipos
                    if (!callableInfo.Args[i].Type.IsCompatibleWith(currentArg.NodeInfo.Type))
                    {
                        errors.Add(new CompileError
                        {
                            Line = currentArg.Line,
                            Column = currentArg.CharPositionInLine,
                            ErrorMessage = string.Format("Argument {0}: cannot convert from '{1}' to '{2}'", i + 1, currentArg.NodeInfo.Type.Name, callableInfo.Args[i].Type.Name),
                            Kind = ErrorKind.Semantic
                        });

                        ///el nodo evalúa de error
                        NodeInfo = SemanticInfo.SemanticError;
                    }
                }
                else
                {
                    ///hubo una argumento que evaluó de error

                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }

            }

            ///seteamos la información del NodeInfo
            if (!Object.Equals(NodeInfo, SemanticInfo.SemanticError))
            {
                NodeInfo = new SemanticInfo
                {
                    Name = SemanticInfo.NoName,
                    ElementKind = SymbolKind.NoSymbol,
                    BuiltInType = callableInfo.BuiltInType,
                    Type = callableInfo.Type,

                    ElementsType = callableInfo.ElementsType,
                    Fields = callableInfo.Fields
                };
            }
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///gen code a los argumentos
            for (int i = 1; i <= ArgsCount; i++)
                ArgAt(i).GenerateCode(cg);

            switch (CallableId)
            {
                case "print":
                    cg.ILGenerator.Emit(OpCodes.Call, print(cg));
                    //print(cg);
                    break;
                case "printi":
                    cg.ILGenerator.Emit(OpCodes.Call, printi(cg));
                    //printi(cg);
                    break;
                case "flush":
                    cg.ILGenerator.Emit(OpCodes.Call, flush(cg));
                    //flush(cg);
                    break;
                case "getchar":
                    cg.ILGenerator.Emit(OpCodes.Call, getchar(cg));
                    //getchar(cg);
                    break;
                case "ord":
                    cg.ILGenerator.Emit(OpCodes.Call, ord(cg));
                    //ord(cg);
                    break;
                case "chr":
                    cg.ILGenerator.Emit(OpCodes.Call, chr(cg));
                    //chr(cg);
                    break;
                case "size":
                    cg.ILGenerator.Emit(OpCodes.Call, size(cg));
                    //size(cg);
                    break;
                case "substring":
                    cg.ILGenerator.Emit(OpCodes.Call, substring(cg));
                    //substring(cg);
                    break;
                case "concat":
                    cg.ILGenerator.Emit(OpCodes.Call, concat(cg));
                    //concat(cg);
                    break;
                case "not":
                    cg.ILGenerator.Emit(OpCodes.Call, not(cg));
                    //not(cg);
                    break;
                case "exit":
                    cg.ILGenerator.Emit(OpCodes.Call, exit(cg));
                    //exit(cg);
                    break;
                case "getline":
                    cg.ILGenerator.Emit(OpCodes.Call, getline(cg));
                    //getline(cg);
                    break;
                case "printline":
                    cg.ILGenerator.Emit(OpCodes.Call, printline(cg));
                    //printline(cg);
                    break;
                default:
                    ILElementInfo ile = cg.ILContextTable.GetDefinedVarOrFunction(CallableId);
                    cg.ILGenerator.Emit(OpCodes.Call, ile.MethodBuilder);
                    break;
            }
        }

        private MethodBuilder print(ILCodeGenerator cg)
        {
            ILElementInfo printProcedure = cg.ILContextTable.GetDefinedVarOrFunction("print");

            ///si ya fue definido
            if (!Object.Equals(printProcedure, null))
                return printProcedure.MethodBuilder;

            MethodBuilder print = cg.Program.DefineMethod("print", MethodAttributes.Private | MethodAttributes.Static, typeof(void), new Type[] { typeof(string) });
            ILGenerator body = print.GetILGenerator();

            body.Emit(OpCodes.Ldarg_0);
            body.Emit(OpCodes.Call, typeof(Console).GetMethod("Write", new Type[] { typeof(string) }));
            body.Emit(OpCodes.Ret);

            ///lo agregamos a las funciones
            cg.ILContextTable.InsertPredefinedCallable("print", new ILElementInfo { MethodBuilder = print });
            return print;
        }

        private MethodBuilder printi(ILCodeGenerator cg)
        {
            ILElementInfo printiProcedure = cg.ILContextTable.GetDefinedVarOrFunction("printi");

            ///si ya fue definido
            if (!Object.Equals(printiProcedure, null))
                return printiProcedure.MethodBuilder;

            MethodBuilder printi = cg.Program.DefineMethod("printi", MethodAttributes.Private | MethodAttributes.Static, typeof(void), new Type[] { typeof(int) });
            ILGenerator body = printi.GetILGenerator();

            body.Emit(OpCodes.Ldarg_0);
            body.Emit(OpCodes.Call, typeof(Console).GetMethod("Write", new Type[] { typeof(int) }));
            body.Emit(OpCodes.Ret);

            ///lo agregamos a las funciones
            cg.ILContextTable.InsertPredefinedCallable("printi", new ILElementInfo { MethodBuilder = printi });
            return printi;
        }

        private MethodBuilder flush(ILCodeGenerator cg)
        {
            ILElementInfo flushProcedure = cg.ILContextTable.GetDefinedVarOrFunction("flush");

            ///si ya fue definido
            if (!Object.Equals(flushProcedure, null))
                return flushProcedure.MethodBuilder;

            MethodBuilder flush = cg.Program.DefineMethod("flush", MethodAttributes.Private | MethodAttributes.Static, typeof(void), System.Type.EmptyTypes);
            ILGenerator body = flush.GetILGenerator();

            body.Emit(OpCodes.Call, typeof(Console).GetProperty("Out").GetGetMethod());
            body.Emit(OpCodes.Callvirt, typeof(TextWriter).GetMethod("Flush", System.Type.EmptyTypes));
            body.Emit(OpCodes.Ret);

            ///lo agregamos a las funciones
            cg.ILContextTable.InsertPredefinedCallable("flush", new ILElementInfo { MethodBuilder = flush });
            return flush;
        }

        private MethodBuilder getchar(ILCodeGenerator cg)
        {
            ILElementInfo getcharFunction = cg.ILContextTable.GetDefinedVarOrFunction("getchar");

            ///si ya fue definido
            if (!Object.Equals(getcharFunction, null))
                return getcharFunction.MethodBuilder;

            MethodBuilder getchar = cg.Program.DefineMethod("getchar", MethodAttributes.Private | MethodAttributes.Static, typeof(string), System.Type.EmptyTypes);
            ILGenerator body = getchar.GetILGenerator();

            LocalBuilder local = body.DeclareLocal(typeof(ConsoleKeyInfo));
            body.Emit(OpCodes.Call, typeof(Console).GetMethod("ReadKey", System.Type.EmptyTypes));
            body.Emit(OpCodes.Stloc, local);
            body.Emit(OpCodes.Ldloca_S, local);
            body.Emit(OpCodes.Call, typeof(ConsoleKeyInfo).GetProperty("KeyChar").GetGetMethod());
            body.Emit(OpCodes.Call, typeof(Char).GetMethod("ToString", new Type[] { typeof(char) }));
            body.Emit(OpCodes.Ret);

            ///lo agregamos a las funciones
            cg.ILContextTable.InsertPredefinedCallable("getchar", new ILElementInfo { MethodBuilder = getchar });
            return getchar;
        }

        private MethodBuilder ord(ILCodeGenerator cg)
        {
            ILElementInfo ordFunction = cg.ILContextTable.GetDefinedVarOrFunction("ord");

            ///si ya fue definido
            if (!Object.Equals(ordFunction, null))
                return ordFunction.MethodBuilder;

            MethodBuilder ord = cg.Program.DefineMethod("ord", MethodAttributes.Private | MethodAttributes.Static, typeof(int), new Type[] { typeof(string) });
            ILGenerator body = ord.GetILGenerator();

            Label stringEmptyLabel = body.DefineLabel();
            Label endLabel = body.DefineLabel();

            ///verificamos que no sea el string nulo o vacío
            body.Emit(OpCodes.Ldarg_0);
            body.Emit(OpCodes.Call, typeof(string).GetMethod("IsNullOrEmpty", new Type[] { typeof(string) }));
            body.Emit(OpCodes.Brtrue, stringEmptyLabel);

            ///0 es el índice del 1er char
            body.Emit(OpCodes.Ldarg_0);
            body.Emit(OpCodes.Ldc_I4_0);

            ///llamamos al get_Chars
            MethodInfo getChars = typeof(string).GetMethod("get_Chars", new Type[] { typeof(int) });
            body.Emit(OpCodes.Callvirt, getChars);
            body.Emit(OpCodes.Br, endLabel);

            ///si era el string nulo o vacío cargamos -1 en la pila
            body.MarkLabel(stringEmptyLabel);
            body.Emit(OpCodes.Ldc_I4, -1);

            ///fin del metodo
            body.MarkLabel(endLabel);
            body.Emit(OpCodes.Ret);

            ///lo agregamos a las funciones
            cg.ILContextTable.InsertPredefinedCallable("ord", new ILElementInfo { MethodBuilder = ord });
            return ord;
        }

        private MethodBuilder chr(ILCodeGenerator cg)
        {
            ILElementInfo chrFunction = cg.ILContextTable.GetDefinedVarOrFunction("chr");

            ///si ya fue definido
            if (!Object.Equals(chrFunction, null))
                return chrFunction.MethodBuilder;

            MethodBuilder chr = cg.Program.DefineMethod("chr", MethodAttributes.Private | MethodAttributes.Static, typeof(string), new Type[] { typeof(int) });
            ILGenerator body = chr.GetILGenerator();

            Label outOfRangeLabel = body.DefineLabel();
            Label endLabel = body.DefineLabel();

            ///si i es mayor que 127
            body.Emit(OpCodes.Ldarg_0);
            body.Emit(OpCodes.Ldc_I4, 127);
            body.Emit(OpCodes.Bgt, outOfRangeLabel);

            ///si i es menor que 0
            body.Emit(OpCodes.Ldarg_0);
            body.Emit(OpCodes.Ldc_I4_0);
            body.Emit(OpCodes.Blt, outOfRangeLabel);

            
            body.Emit(OpCodes.Ldarg_0);
            body.Emit(OpCodes.Call, typeof(Convert).GetMethod("ToChar", new Type[] { typeof(int) }));
            body.Emit(OpCodes.Call, typeof(Char).GetMethod("ToString", new Type[] { typeof(char) }));

            ///saltamos al fin del proceso
            body.Emit(OpCodes.Br, endLabel);

            ///hubo index out of range
            body.MarkLabel(outOfRangeLabel);
            body.Emit(OpCodes.Ldstr, "Integer i is out of range");
            body.ThrowException(typeof(IndexOutOfRangeException));

            body.MarkLabel(endLabel);
            body.Emit(OpCodes.Ret);

            ///lo agregamos a las funciones
            cg.ILContextTable.InsertPredefinedCallable("chr", new ILElementInfo { MethodBuilder = chr });
            return chr;
        }

        private MethodBuilder size(ILCodeGenerator cg)
        {
            ILElementInfo sizeFunction = cg.ILContextTable.GetDefinedVarOrFunction("size");

            ///si ya fue definido
            if (!Object.Equals(sizeFunction, null))
                return sizeFunction.MethodBuilder;

            MethodBuilder size = cg.Program.DefineMethod("size", MethodAttributes.Private | MethodAttributes.Static, typeof(int), new Type[] { typeof(string) });
            ILGenerator body = size.GetILGenerator();
            
            body.Emit(OpCodes.Ldarg_0);
            body.Emit(OpCodes.Call, typeof(string).GetProperty("Length").GetGetMethod());
            body.Emit(OpCodes.Ret);

            ///lo agregamos a las funciones
            cg.ILContextTable.InsertPredefinedCallable("size", new ILElementInfo { MethodBuilder = size });

            return size;
        }

        private MethodBuilder substring(ILCodeGenerator cg)
        {
            ILElementInfo substringFunction = cg.ILContextTable.GetDefinedVarOrFunction("substring");

            ///si ya fue definido
            if (!Object.Equals(substringFunction, null))
                return substringFunction.MethodBuilder;

            MethodBuilder substring = cg.Program.DefineMethod("substring", MethodAttributes.Private | MethodAttributes.Static, typeof(string), new Type[] { typeof(string), typeof(int), typeof(int) });
            ILGenerator body = substring.GetILGenerator();

            body.Emit(OpCodes.Ldarg_0);
            body.Emit(OpCodes.Ldarg_1);
            body.Emit(OpCodes.Ldarg_2);
            body.Emit(OpCodes.Call, typeof(string).GetMethod("Substring", new Type[] { typeof(int), typeof(int) }));
            body.Emit(OpCodes.Ret);

            ///lo agregamos a las funciones
            cg.ILContextTable.InsertPredefinedCallable("substring", new ILElementInfo { MethodBuilder = substring });

            return substring;
        }

        private MethodBuilder concat(ILCodeGenerator cg)
        {
            ILElementInfo concatFunction = cg.ILContextTable.GetDefinedVarOrFunction("concat");

            ///si ya fue definido
            if (!Object.Equals(concatFunction, null))
                return concatFunction.MethodBuilder;

            MethodBuilder concat = cg.Program.DefineMethod("concat", MethodAttributes.Private | MethodAttributes.Static, typeof(string), new Type[] { typeof(string), typeof(string) });
            ILGenerator body = concat.GetILGenerator();

            body.Emit(OpCodes.Ldarg_0);
            body.Emit(OpCodes.Ldarg_1);
            body.Emit(OpCodes.Call, typeof(string).GetMethod("Concat", new Type[] { typeof(string), typeof(string) }));
            body.Emit(OpCodes.Ret);

            ///lo agregamos a las funciones
            cg.ILContextTable.InsertPredefinedCallable("concat", new ILElementInfo { MethodBuilder = concat });

            return concat;
        }

        private MethodBuilder not(ILCodeGenerator cg)
        {
            ILElementInfo notFunction = cg.ILContextTable.GetDefinedVarOrFunction("not");

            ///si ya fue definido
            if (!Object.Equals(notFunction, null))
                return notFunction.MethodBuilder;

            MethodBuilder not = cg.Program.DefineMethod("not", MethodAttributes.Private | MethodAttributes.Static, typeof(int), new Type[] { typeof(int) });
            ILGenerator body = not.GetILGenerator();

            body.Emit(OpCodes.Ldarg_0);
            body.Emit(OpCodes.Ldc_I4_0);
            body.Emit(OpCodes.Ceq);
            body.Emit(OpCodes.Ret);

            ///lo agregamos a las funciones
            cg.ILContextTable.InsertPredefinedCallable("not", new ILElementInfo { MethodBuilder = not });

            return not;
        }

        private MethodBuilder exit(ILCodeGenerator cg)
        {
            ILElementInfo exitProcedure = cg.ILContextTable.GetDefinedVarOrFunction("exit");

            ///si ya fue definido
            if (!Object.Equals(exitProcedure, null))
                return exitProcedure.MethodBuilder;

            MethodBuilder exit = cg.Program.DefineMethod("exit", MethodAttributes.Private | MethodAttributes.Static, typeof(void), new Type[] { typeof(int) });
            ILGenerator body = exit.GetILGenerator();

            body.Emit(OpCodes.Ldarg_0);
            body.Emit(OpCodes.Call, typeof(Environment).GetMethod("Exit", new Type[] { typeof(int) }));
            body.Emit(OpCodes.Ret);

            ///lo agregamos a las funciones
            cg.ILContextTable.InsertPredefinedCallable("exit", new ILElementInfo { MethodBuilder = exit });

            return exit;
        }

        private MethodBuilder getline(ILCodeGenerator cg)
        {
            ILElementInfo getlineFunction = cg.ILContextTable.GetDefinedVarOrFunction("getline");

            ///si ya fue definido
            if (!Object.Equals(getlineFunction, null))
                return getlineFunction.MethodBuilder;

            MethodBuilder getline = cg.Program.DefineMethod("getline", MethodAttributes.Private | MethodAttributes.Static, typeof(string), new Type[0]);
            ILGenerator body = getline.GetILGenerator();

            body.Emit(OpCodes.Call, typeof(Console).GetMethod("ReadLine"));
            body.Emit(OpCodes.Ret);

            ///lo agregamos a las funciones
            cg.ILContextTable.InsertPredefinedCallable("getline", new ILElementInfo { MethodBuilder = getline });

            return getline;
        }

        private MethodBuilder printline(ILCodeGenerator cg)
        {
            ILElementInfo printlineProcedure = cg.ILContextTable.GetDefinedVarOrFunction("printline");

            ///si ya fue definido
            if (!Object.Equals(printlineProcedure, null))
                return printlineProcedure.MethodBuilder;

            MethodBuilder printline = cg.Program.DefineMethod("printline", MethodAttributes.Private | MethodAttributes.Static, typeof(void), new Type[] { typeof(string) });
            ILGenerator body = printline.GetILGenerator();

            body.Emit(OpCodes.Ldarg_0);
            body.Emit(OpCodes.Call, typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) }));
            body.Emit(OpCodes.Ret);

            ///lo agregamos a las funciones
            cg.ILContextTable.InsertPredefinedCallable("printline", new ILElementInfo { MethodBuilder = printline });

            return printline;
        }
    }
}
