using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Reflection;
using System.Reflection.Emit;

using Compiler.Errors;

namespace Compiler.CodeGenerators
{
    /// <summary>
    /// Represents a MSIL code generator
    /// </summary>
    public class ILCodeGenerator
    {
        #region Fields
        /// <summary>
        /// Fired when Build error ocurrs
        /// </summary>
        public event CompileErrorOcurrence OnBuildingErrorOcurrence;
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new MSIL CodeGenerator
        /// </summary>
        /// <param name="executableFileName">Tiger source code file name</param>
        /// <param name="parentDirectory">Tiger source code file parent directory</param>
        public ILCodeGenerator(string executableFileName, string parentDirectory)
        {
            ///guardamos el nombre del fichero
            ExecutableFileName = executableFileName;

            ///guardamos el directorio padre
            ParentDirectory = parentDirectory;

            ///creamos un AssemblyName
            AssemblyName assemblyName = new AssemblyName(Path.GetFileNameWithoutExtension(executableFileName));
            assemblyName.Version = new Version(1, 0, 0, 0);

            ///construimos nuestro ensamblado
            this.Assembly = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.RunAndSave, ParentDirectory);

            ///construimos nuestro módulo(en nuestro caso solo vamos a tener uno)
            this.Module = this.Assembly.DefineDynamicModule(assemblyName.Name, ExecutableFileName);

            ///vamos a definir la clase Program
            this.Program = this.Module.DefineType("Program", TypeAttributes.Public | TypeAttributes.Class);

            ///vamos a definir el Main(método del entry point)
            this.Main = this.Program.DefineMethod(
                        "Main",                                                //nombre del método
                        MethodAttributes.Public | MethodAttributes.Static,     //atributos
                        typeof(void),                                          //tipo de retorno
                        new Type[0]);                                          //tipos de los argumentos

            ///seteamos el entry point
            this.Assembly.SetEntryPoint(this.Main);

            ///seteamos el generador de código IL
            ILGenerator = this.Main.GetILGenerator();

            ///inicializamos el stack de labels de fin de ciclo
            EndLoopLabelStack = new Stack<Label>();

            ///inicializamos la tabla del generador de código
            ILContextTable = new ContextTable();

            ///comenzamos el bloque try-catch-finall
            ILGenerator.BeginExceptionBlock();
        }
        #endregion

        #region Properties

        /// <summary>
        /// Tiger source code file name
        /// </summary>
        public static string ExecutableFileName { get; set; }

        /// <summary>
        /// Tiger source code file parent directory
        /// </summary>
        public static string ParentDirectory { get; set; }

        /// <summary>
        /// Represents the Assembly(wether .exe or .dll)
        /// </summary>
        private AssemblyBuilder Assembly { get; set; }

        /// <summary>
        /// Represents the namespace
        /// </summary>
        public ModuleBuilder Module { get; set; }

        /// <summary>
        /// Represents the class where all the code is hosted
        /// </summary>
        public TypeBuilder Program { get; set; }

        /// <summary>
        /// Represents the Main method of a .NET application
        /// </summary>
        private MethodBuilder Main { get; set; }

        /// <summary>
        /// IL generator of this code generator
        /// </summary>
        public ILGenerator ILGenerator { get; set; }

        /// <summary>
        /// Stack of Labels of for or while loops
        /// </summary>
        public Stack<Label> EndLoopLabelStack { get; private set; }

        /// <summary>
        /// Context table similar to the check semantics symbol table
        /// </summary>
        public ContextTable ILContextTable { get; private set; }
        #endregion

        #region Methods
        /// <summary>
        /// Saves the .exe file
        /// </summary>
        /// <returns>True if succeded, False otherwise</returns>
        public bool SaveExecutable()
        {
            try
            {
                #region cuerpo del catch-finally
                ///comenzamos el bloque catch
                ILGenerator.BeginCatchBlock(typeof(Exception));

                ///declaramos la variable que representa a la excepción 
                LocalBuilder e = ILGenerator.DeclareLocal(typeof(Exception));

                ///almacenamos la excepción en la variable
                ILGenerator.Emit(OpCodes.Stloc, e);

                ///pedimos la propiedad Error de Console
                ILGenerator.Emit(OpCodes.Call, typeof(Console).GetMethod("get_Error", new Type[0]));

                ///cargamos el mensaje de error
                ILGenerator.Emit(OpCodes.Ldstr, "Exception of type '{0}' was thrown.");

                ///cargamos la variable de la excepción
                ILGenerator.Emit(OpCodes.Ldloc, e);

                ///llamamos al metodo GetType de la clase Exception
                ILGenerator.Emit(OpCodes.Callvirt, typeof(Exception).GetMethod("GetType", new Type[0]));

                ///escribimos el mensaje en la salida de errores de Console
                ILGenerator.Emit(OpCodes.Callvirt, typeof(TextWriter).GetMethod("WriteLine", new Type[] { typeof(string), typeof(object) }));

                ///comenzamos un bloque finally
                ILGenerator.BeginFinallyBlock();

                ///NO PONEMOS CÓDIGO EN EL CUERPO DEL FINALLY 

                ///cerramos el bloque de excepciones
                ILGenerator.EndExceptionBlock();
                #endregion

                ///emitimos el return del método Main
                ILGenerator.Emit(OpCodes.Ret);

                ///creamos la clase Program en caso de que no haya sido creada
                if (!this.Program.IsCreated())
                    this.Program.CreateType();

                ///salvamos el Assembly
                this.Assembly.Save(ExecutableFileName);

                return true;
            }
            catch (IOException)
            {
                ///si alguien se suscribió al evento
                if (OnBuildingErrorOcurrence != null)
                {
                    string errorMessage = string.Format("The process cannot access the file '{0}' because it is being used by another process.", ExecutableFileName);
                    OnBuildingErrorOcurrence(0, 0, errorMessage);
                }

                return false;
            }
        }

        #endregion
    }
}
