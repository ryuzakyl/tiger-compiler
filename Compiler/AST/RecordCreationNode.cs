using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.Errors;
using Compiler.CodeGenerators;



namespace Compiler.AST
{
    public class RecordCreationNode : AssignableExpressionNode
    {
        public List<KeyValuePair<string, ExpressionNode>> propertiesList;

        public RecordCreationNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// Id of the record
        /// </summary>
        public string RecordId
        {
            get { return GetChild(0).Text; }
        }

        public List<KeyValuePair<string, ExpressionNode>> Fields
        {
            get
            {
                if (propertiesList == null)
                {
                    propertiesList = new List<KeyValuePair<string, ExpressionNode>>();
                    for (int i = 0; i < ChildCount / 2; i++)
                    {
                        propertiesList.Add(new KeyValuePair<string, ExpressionNode>(GetChild(2 * i + 1).Text, GetChild(2 * i + 2) as ExpressionNode));
                    }
                }
                return propertiesList;
            }
        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            SemanticInfo recordInfo;

            ///chequeamos que exista un tipo con ese nombre
            if (!symbolTable.GetDefinedTypeDeep(RecordId, out recordInfo))
            {
                errors.Add(new CompileError
                {
                    Line = GetChild(0).Line,
                    Column = GetChild(0).CharPositionInLine,
                    ErrorMessage = string.Format("Type '{0}' could not be found in current context", RecordId),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }
            else
            {
                ///si el tipo encontrado no es compatible con record
                if (!recordInfo.BuiltInType.IsCompatibleWith(BuiltInType.Record))
                {
                    errors.Add(new CompileError
                    {
                        Line = GetChild(0).Line,
                        Column = GetChild(0).CharPositionInLine,
                        ErrorMessage = string.Format("Cannot implicitly convert type '{0}' to 'record'", recordInfo.Type.Name),
                        Kind = ErrorKind.Semantic
                    });

                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }
            }

            ///si este nodo no evaluó de error
            if (Object.Equals(NodeInfo, SemanticInfo.SemanticError))
            {
                ///no chequeamos los campos
                return;
            }

            ///debo chequear que la cantidad de fields sea correcta
            if (recordInfo.Fields.Count != Fields.Count)
            {
                errors.Add(new CompileError
                {
                    Line = GetChild(0).Line,
                    Column = GetChild(0).CharPositionInLine,
                    ErrorMessage = string.Format("Record type '{0}' requires {1} field(s) initialization(s)", RecordId, recordInfo.Fields.Count),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }
            else
            {
                ///chequeamos que el tipo de cada parámetro coincida con el tipo con el que fue definido
                for (int i = 0; i < Fields.Count; i++)
                {
                    //check semantics del i-esimo field
                    Fields[i].Value.CheckSemantic(symbolTable, errors);

                    ///los nombres de los fields deben coincidir
                    if (!recordInfo.Fields[i].Key.Equals(Fields[i].Key))
                    {
                        errors.Add(new CompileError
                        {
                            Line = GetChild(2 * i + 1).Line,
                            Column = GetChild(2 * i + 1).CharPositionInLine,
                            ErrorMessage = string.Format("Record type '{0}' does not contain a definition for '{1}'", RecordId, Fields[i].Key),
                            Kind = ErrorKind.Semantic
                        });

                        ///el nodo evalúa de error
                        NodeInfo = SemanticInfo.SemanticError;
                    }

                    ///si la expresión actual no evalúa de error
                    if (!Object.Equals(Fields[i].Value.NodeInfo, SemanticInfo.SemanticError))
                    {
                        ///si el field no es compatible con el tipo que fue definido
                        if (!recordInfo.Fields[i].Value.IsCompatibleWith(Fields[i].Value.NodeInfo))
                        {
                            errors.Add(new CompileError
                            {
                                Line = GetChild(2 * i + 2).Line,
                                Column = GetChild(2 * i + 2).CharPositionInLine,
                                ErrorMessage = string.Format("Cannot implicitly convert type '{0}' to '{1}'", Fields[i].Value.NodeInfo.Type.Name, recordInfo.Fields[i].Value.Type.Name),
                                Kind = ErrorKind.Semantic
                            });

                            ///el nodo evalúa de error
                            NodeInfo = SemanticInfo.SemanticError;
                        }
                    }
                    else
                    { 
                        ///el nodo evalúa de error
                        NodeInfo = SemanticInfo.SemanticError;
                    }
                }
            }

            ///seteamos los campos necesarios
            if (!Object.Equals(NodeInfo, SemanticInfo.SemanticError))
            {
                NodeInfo.BuiltInType = BuiltInType.Record;

                NodeInfo.ElementsType = recordInfo.ElementsType;
                NodeInfo.Fields = recordInfo.Fields;

                NodeInfo.Type = recordInfo.Type;
                NodeInfo.ILType = NodeInfo.ILType;
            }
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ILElementInfo ile = cg.ILContextTable.GetDefinedType(RecordId);
            Type recordType = ile.ILType;

            List<Type> fieldsType = new List<Type>();
            foreach (var fieldElement in NodeInfo.Fields)
                fieldsType.Add(fieldElement.Value.ILType);
            foreach (var fieldExpression in Fields)
                fieldExpression.Value.GenerateCode(cg);

            //ConstructorInfo constructor = recordType.GetConstructor(fieldsType.ToArray());
            
            ///le pedimos el constructor que no tiene parámetros
            ConstructorInfo  constructor = recordType.GetConstructors()[0];
            cg.ILGenerator.Emit(OpCodes.Newobj, constructor);

            NodeInfo.ILType = ile.TypeBuilder;
        }
    }
}
