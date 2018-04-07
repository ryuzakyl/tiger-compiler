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
    public class ArrayCreationNode : AssignableExpressionNode
    {
        public ArrayCreationNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// Id of the array
        /// </summary>
        public string ArrayId
        {
            get { return GetChild(0).Text; }
        }

        /// <summary>
        /// Array size
        /// </summary>
        public ExpressionNode IndexExpression
        {
            get { return GetChild(1) as ExpressionNode; }
        }

        /// <summary>
        /// Initialization expression
        /// </summary>
        public ExpressionNode InitExpression
        {
            get { return GetChild(2) as ExpressionNode; }
        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///check semantics al IndexExpression
            IndexExpression.CheckSemantic(symbolTable, errors);

            ///check semantics al InitExpression
            InitExpression.CheckSemantic(symbolTable, errors);

            ///si IndexExpression o InitExpression evalúa de error entonces esta también
            if (IndexExpression.NodeInfo.Equals(SemanticInfo.SemanticError) || 
                InitExpression.NodeInfo.Equals(SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            SemanticInfo arrayInfo;

            ///el ArrayId tiene que estar definido
            if (!symbolTable.GetDefinedTypeDeep(ArrayId, out arrayInfo))
            {
                errors.Add(new CompileError
                {
                    Line = GetChild(0).Line,
                    Column = GetChild(0).CharPositionInLine,
                    ErrorMessage = string.Format("Type '{0}' could not be found in current context", ArrayId),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }
            else
            {
                ///ArrayId tiene que ser compatible con array
                if (!arrayInfo.Type.BuiltInType.IsCompatibleWith(BuiltInType.Array))
                {
                    errors.Add(new CompileError
                    {
                        Line = GetChild(0).Line,
                        Column = GetChild(0).CharPositionInLine,
                        ErrorMessage = string.Format("Cannot apply indexing with [] to an expression of type '{0}'", arrayInfo.Type.Name),
                        Kind = ErrorKind.Semantic
                    });

                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }
            }

            ///si IndexExpression no evaluó de error
            if (!Object.Equals(IndexExpression.NodeInfo, SemanticInfo.SemanticError))
            {
                ///IndexExpressiontiene que ser compatible con 'int'
                if (!IndexExpression.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Int))
                {
                    errors.Add(new CompileError
                    {
                        Line = IndexExpression.Line,
                        Column = IndexExpression.CharPositionInLine,
                        ErrorMessage = string.Format("Cannot implicitly convert type '{0}' to 'int'", IndexExpression.NodeInfo.Type.Name),
                        Kind = ErrorKind.Semantic
                    });

                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }
            }

            ///si InitExpression no evaluó de error
            if (!Object.Equals(InitExpression.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el tipo de InitExpression debe ser compatible con el de los elementos del array
                if (!Object.Equals(arrayInfo, SemanticInfo.SemanticError) &&
                    !arrayInfo.Type.ElementsType.Type.IsCompatibleWith(InitExpression.NodeInfo.Type))
                {
                    errors.Add(new CompileError
                    {
                        Line = GetChild(2).Line,
                        Column = GetChild(2).CharPositionInLine,
                        ErrorMessage = string.Format("Cannot implicitly convert type '{0}' to '{1}'", InitExpression.NodeInfo.Type.Name, arrayInfo.ElementsType.Name),
                        Kind = ErrorKind.Semantic
                    });

                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }
            }

            ///seteamos los campos necesarios
            if (!Object.Equals(NodeInfo, SemanticInfo.SemanticError))
            {
                NodeInfo.BuiltInType = BuiltInType.Array;

                NodeInfo.ElementsType = arrayInfo.Type.ElementsType;
                NodeInfo.Fields = arrayInfo.Type.Fields;

                //change the last
                NodeInfo.Type = arrayInfo.Type.Type;
                NodeInfo.ILType = arrayInfo.Type.ILType;
            }
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            //creamos las variables locales
            LocalBuilder i = cg.ILGenerator.DeclareLocal(typeof(int));
            LocalBuilder length = cg.ILGenerator.DeclareLocal(typeof(int));
            LocalBuilder array = cg.ILGenerator.DeclareLocal(NodeInfo.Type.ILType);

            //creamos los label
            Label loopCondLabel = cg.ILGenerator.DefineLabel();
            Label loopEndLabel = cg.ILGenerator.DefineLabel();

            //guardamos el label a donde vamos a saltar
            cg.EndLoopLabelStack.Push(loopEndLabel);

            //generamos la expresion de la longitud del array
            IndexExpression.GenerateCode(cg);

            //creamos el array
            cg.ILGenerator.Emit(OpCodes.Stloc, length);
            cg.ILGenerator.Emit(OpCodes.Ldloc, length);
            cg.ILGenerator.Emit(OpCodes.Newarr, NodeInfo.Type.ElementsType.ILType);
            cg.ILGenerator.Emit(OpCodes.Stloc, array);

            //i = 0
            cg.ILGenerator.Emit(OpCodes.Ldc_I4_0);
            cg.ILGenerator.Emit(OpCodes.Stloc, i);

            //condition del loop
            cg.ILGenerator.MarkLabel(loopCondLabel);

            cg.ILGenerator.Emit(OpCodes.Ldloc, i);
            cg.ILGenerator.Emit(OpCodes.Ldloc, length);

            //si no se cumple la condition, saltamos al fin del ciclo
            cg.ILGenerator.Emit(OpCodes.Clt);
            cg.ILGenerator.Emit(OpCodes.Brfalse, loopEndLabel);

            //asignamos el valor(array[i] = InitExpression.Value)
            cg.ILGenerator.Emit(OpCodes.Ldloc, array);
            cg.ILGenerator.Emit(OpCodes.Ldloc, i);

            //generamos el codigo de la expresion de inicializacion
            InitExpression.GenerateCode(cg);

            //guardamos el elemento
            cg.ILGenerator.Emit(OpCodes.Stelem, NodeInfo.Type.ElementsType.ILType);

            // Incrementar "i".
            cg.ILGenerator.Emit(OpCodes.Ldloc, i);
            cg.ILGenerator.Emit(OpCodes.Ldc_I4_1);
            cg.ILGenerator.Emit(OpCodes.Add);
            cg.ILGenerator.Emit(OpCodes.Stloc, i);
            cg.ILGenerator.Emit(OpCodes.Br, loopCondLabel);

            // Fin del ciclo.
            cg.ILGenerator.MarkLabel(loopEndLabel);

            //sacamos el label guardado
            cg.EndLoopLabelStack.Pop();

            cg.ILGenerator.Emit(OpCodes.Ldloc, array);
        }
    }
}
