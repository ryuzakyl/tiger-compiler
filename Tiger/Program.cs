using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using Compiler;
using Compiler.Errors;

namespace Tiger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tiger Compiler version 1.0");
            Console.WriteLine("Copyright (C) 2011-2012 Daniel A. Mesejo & Victor M. Mendiola");
            Console.WriteLine();

            ///se requiere exactamente 1 argumento
            if (args.Length != 1)
            {
                Console.WriteLine("(0,0): Invalid usage. The application require exactly 1 argument.");

                ///terminamos con código de salida 1
                Environment.Exit(1);
            }

            ///guardamos el path del fichero de código
            string filePath = args[0];

            ///solo se admiten archivos con extensión .tig 
            if(!Object.Equals(Path.GetExtension(filePath),".tig"))
            {
                Console.WriteLine("(0,0): Only .tig files supported.");

                ///terminamos con código de salida 1
                Environment.Exit(1);
            }

            try
            {
                ///validamos el path del fichero
                if (!ValidatePath(filePath))
                {
                    Console.WriteLine("(0,0): File '{0}' cannot be found.", filePath);
                    
                    ///terminamos con código de salida 1
                    Environment.Exit(1);
                }

                ///compilamos el fichero de texto
                bool compileSucceded = TigerCompiler.CompileFile(filePath);

                ///si hubo error los imprimimos
                if (!compileSucceded)
                {
                    foreach (CompileError error in TigerCompiler.Errors)
                    {
                        Console.WriteLine(error.ToString());
                    }

                    ///terminamos con código de salida 1
                    Environment.Exit(1);
                }
            }
            catch
            {
                Console.WriteLine("(0,0): Program terminated due to unexpected error.");

                ///terminamos con código de salida 1
                Environment.Exit(1);
            }

            ///terminamos con código de salida 0
            Environment.Exit(0);
        }

        /// <summary>
        /// Check IO stuffs
        /// </summary>
        /// <param name="filePath">path of tiger source code file</param>
        /// <returns>True if file is OK, False otherwhise</returns>
        private static bool ValidatePath(string filePath)
        {
            //chequeamos que el archivo exista
            if (!File.Exists(filePath))
                return false;

            return true;
        }
    }
}
