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
    public class ForLoopNode : ControlNode
    {
        public ForLoopNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// Represents the iteration variable
        /// </summary>
        public string LoopVariable
        {
            get { return GetChild(0).Text; }
        }

        /// <summary>
        /// Starting index of the iteration variable
        /// </summary>
        public ExpressionNode StartIndex
        {
            get { return GetChild(1) as ExpressionNode; }
        }

        /// <summary>
        /// End index of the iteration variable
        /// </summary>
        /// <remarks>The boundary is inclusive</remarks>
        public ExpressionNode EndIndex
        {
            get { return GetChild(2) as ExpressionNode; }
        }

        /// <summary>
        /// Instructions to execute in the 'for' loop
        /// </summary>
        public ExpressionNode ForBody
        {
            get { return GetChild(3) as ExpressionNode; }
        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///check semantics al StartIndex
            StartIndex.CheckSemantic(symbolTable, errors);

            ///check semantics al EndIndex
            EndIndex.CheckSemantic(symbolTable, errors);

            ///si StartIndex no evaluó de error
            if (!Object.Equals(StartIndex.NodeInfo, SemanticInfo.SemanticError))
            {
                ///la expresión de StartIndex tiene que ser compatible con 'int'
                if (!StartIndex.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Int))
                {
                    errors.Add(new CompileError
                    {
                        Line = StartIndex.Line,
                        Column = StartIndex.CharPositionInLine,
                        ErrorMessage = string.Format("Cannot implicitly convert type '{0}' to 'int'", StartIndex.NodeInfo.Type.Name),
                        Kind = ErrorKind.Semantic
                    });

                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }
            }

            ///si EndIndex no evaluó de error
            if (!Object.Equals(EndIndex.NodeInfo, SemanticInfo.SemanticError))
            {
                ///la expresión de EndIndex tiene que ser compatible con 'int'
                if (!EndIndex.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Int))
                {
                    errors.Add(new CompileError
                    {
                        Line = EndIndex.Line,
                        Column = EndIndex.CharPositionInLine,
                        ErrorMessage = string.Format("Cannot implicitly convert type '{0}' to 'int'", EndIndex.NodeInfo.Type.Name),
                        Kind = ErrorKind.Semantic
                    });

                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }
            }

            SemanticInfo loopVarInfo;

            ///no puede haber otra variable con el mismo nombre que este
            if (symbolTable.GetDefinedVariableDeep(LoopVariable, out loopVarInfo))
            {
                errors.Add(new CompileError
                {
                    Line = GetChild(0).Line,
                    Column = GetChild(0).CharPositionInLine,
                    ErrorMessage = string.Format("A local variable named '{0}' cannot be declared in this scope because it would give a different meaning to'{1}', which is already used in a 'parent or current' scope to denote something else", LoopVariable, LoopVariable),
                    Kind = ErrorKind.Semantic
                });
            }

            ///creamos un nuevo scope
            symbolTable.InitNewScope();

            ///agregamos la variable de iteración al scope actual
            SemanticInfo loopVariable = new SemanticInfo
            {
                Name = LoopVariable,
                ElementKind = SymbolKind.Variable,
                IsReadOnly = true,              //ponemos la variable como readonly
                BuiltInType = BuiltInType.Int,
                Type = SemanticInfo.Int
            };
            symbolTable.InsertSymbol(loopVariable);

            ///check semantics al ForBody
            ForBody.CheckSemantic(symbolTable, errors);

            ///aquí concluye el scope que crea el for
            symbolTable.CloseCurrentScope();

            ///si el ForBody evalúa de error este también
            if (Object.Equals(ForBody.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            ///seteamos la información del NodeInfo
            NodeInfo.BuiltInType = BuiltInType.Void;
            NodeInfo.Type = SemanticInfo.Void;

            ///el ForBody no puede retornar valor
            if (ForBody.NodeInfo.BuiltInType.IsReturnType())
            {
                errors.Add(new CompileError
                {
                    Line = ForBody.Line,
                    Column = ForBody.CharPositionInLine,
                    ErrorMessage = "Body of control instruction 'for' cannot return value",
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///el for crea su scope(en IL)
            cg.ILGenerator.BeginScope();

            ///creamos un nuevo contexto
            cg.ILContextTable.InitNewContext();

            ///definimos los labels necesarios en el ciclo
            Label forCondLabel = cg.ILGenerator.DefineLabel();
            Label forEndLabel = cg.ILGenerator.DefineLabel();

            ///guardamos el label a donde vamos a saltar
            cg.EndLoopLabelStack.Push(forEndLabel);

            ///declaramos la variable local de iteracion del for
            ILElementInfo forloopVariable = cg.ILContextTable.InsertILElement(LoopVariable, new ILElementInfo
            {
                LocalBuilder = cg.ILGenerator.DeclareLocal(typeof(int)),
                ElementKind = SymbolKind.Variable
            });

            ///declaramamos una varaible que representa a EndIndex
            ILElementInfo endLoopVariable = cg.ILContextTable.InsertILElement("endLoopVariable", new ILElementInfo
            {
                LocalBuilder = cg.ILGenerator.DeclareLocal(typeof(int)),
                ElementKind = SymbolKind.Variable
            });

            ///generamos la expresion de fin y la almacenamos
            EndIndex.GenerateCode(cg);
            cg.ILGenerator.Emit(OpCodes.Ldc_I4_1);
            cg.ILGenerator.Emit(OpCodes.Add);
            cg.ILGenerator.Emit(OpCodes.Stloc, endLoopVariable.LocalBuilder);

            ///generamos la expresion de inicializacion y lo almacenamos
            StartIndex.GenerateCode(cg);
            cg.ILGenerator.Emit(OpCodes.Stloc, forloopVariable.LocalBuilder);

            ///condition del for
            cg.ILGenerator.MarkLabel(forCondLabel);

            cg.ILGenerator.Emit(OpCodes.Ldloc, forloopVariable.LocalBuilder);
            cg.ILGenerator.Emit(OpCodes.Ldloc, endLoopVariable.LocalBuilder);

            ///si no se cumple la condition, saltamos al fin del ciclo
            cg.ILGenerator.Emit(OpCodes.Clt);
            cg.ILGenerator.Emit(OpCodes.Brfalse, forEndLabel);

            ///generamos el codigo del cuerpo
            ForBody.GenerateCode(cg);

            ///incrementamos la variable del ciclo
            cg.ILGenerator.Emit(OpCodes.Ldloc, forloopVariable.LocalBuilder);
            cg.ILGenerator.Emit(OpCodes.Ldc_I4_1);
            cg.ILGenerator.Emit(OpCodes.Add);
            cg.ILGenerator.Emit(OpCodes.Stloc, forloopVariable.LocalBuilder);

            ///saltamos a la condicion del for
            cg.ILGenerator.Emit(OpCodes.Br, forCondLabel);

            ///ponemos la variable de fin de ciclo
            cg.ILGenerator.MarkLabel(forEndLabel);

            ///sacamos el label guardado
            cg.EndLoopLabelStack.Pop();

            ///cerramos el contexto
            cg.ILContextTable.CloseCurrentContext();

            ///cerramos el scope del for(en IL)
            cg.ILGenerator.EndScope();
        }
    }
}
