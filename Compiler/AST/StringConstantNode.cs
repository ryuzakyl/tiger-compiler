using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.Errors;
using Compiler.CodeGenerators;

namespace Compiler.AST
{
    public class StringConstantNode : ConstantExpressionNode
    {
        public StringConstantNode(IToken token) : base(token)
        {

        }

        private string StringValue { get; set; }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///escapamos el string
            StringValue = EscapeText(this.Text);

            ///si hay una secuencia de escape no válida
            if (StringValue == null)
            {
                errors.Add(new CompileError
                {
                    Line = this.Line,
                    Column = this.CharPositionInLine,
                    ErrorMessage = "Unrecognized escape sequence",
                    Kind = ErrorKind.Syntactic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }
            else
            {
                ///seteamos la información del NodeInfo
                NodeInfo.BuiltInType = BuiltInType.String;
                NodeInfo.Type = SemanticInfo.String;
                NodeInfo.ILType = typeof(string);
            }

        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            //cargamos el string en la pila
            cg.ILGenerator.Emit(OpCodes.Ldstr, StringValue);
        }

        private string EscapeText(string text)
        {
            try
            {
                //nos quitamos de arriba las comillas ""
                string s = text.Substring(1, text.Length - 2);

                StringBuilder scapedText = new StringBuilder();

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '\\')
                    {
                        //pasamos al siguiente caracter
                        i++;

                        if (s[i] == 'n')
                        {   //Newline
                            scapedText.Append("\n");
                        }
                        else if (s[i] == 't')
                        {   //Tab
                            scapedText.Append("\t");
                        }
                        else if (s[i] == '\"')
                        {   //Double quote
                            scapedText.Append("\"");
                        }
                        else if (s[i] == '\\')
                        {   //Backslash
                            scapedText.Append("\\");
                        }
                        else if (s[i] == '^')
                        {   //Control-c
                            i++;
                            char controlC = (char)(s[i] - 64);//@ = 64
                            scapedText.Append(controlC);
                        }
                        else if (IsDigit(s[i]))
                        {   //caso de \ddd
                            if (IsDigit(s[i + 1]) && IsDigit(s[i + 2]))
                            {
                                char ascii_char = (char)int.Parse(s.Substring(i, 3));
                                scapedText.Append(ascii_char);
                                i += 2;
                            }
                            else
                                return null;
                        }
                        else if (IsWhiteSpace(s[i]))
                        {
                            //caso de \...\
                            int index = ConsumeWhiteSpaces(s, i);

                            if (s[index] != '\\')
                                return null;

                            i = index;
                        }
                        else
                            return null;
                    }
                    else
                        scapedText.Append(s[i]);
                }

                return scapedText.ToString();
            }
            catch
            {
                return null;
            }
        }

        private bool IsDigit(char c)
        {
            return 48 <= c && c <= 57;
        }

        private bool IsWhiteSpace(char c)
        {
            return c == ' ' || c == '\t' | c == '\r' | c == '\n';
        }

        private int ConsumeWhiteSpaces(string s, int i)
        {
            while (IsWhiteSpace(s[i]))
                i++;

            return i;
        }
    }
}
