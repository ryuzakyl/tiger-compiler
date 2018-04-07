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
    public class RecordDeclarationNode : TypeDeclarationNode
    {
        #region Fields
        List<KeyValuePair<string, string>> fields;
        List<SemanticInfo> realFields;
        int childCount;
        bool firstPass = true;
        SemanticInfo recordParche; 
        #endregion

        public RecordDeclarationNode(IToken token) : base(token)
        {
            childCount = -1;
            realFields = new List<SemanticInfo>();
        }

        /// <summary>
        /// Id of the record
        /// </summary>
        public string RecordId
        {
            get { return GetChild(0).Text; }
        }

        /// <summary>
        /// Record fields count
        /// </summary>
        public int FieldsCount
        {
            get
            {
                if (childCount == -1)
                    childCount = ChildCount / 2;
                return childCount;
            }
        }

        /// <summary>
        /// Fields of the record
        /// </summary>
        public List<KeyValuePair<string, string>> Fields
        {
            get
            {
                if (fields == null)
                {
                    fields = new List<KeyValuePair<string, string>>();
                    for (int i = 0; i < FieldsCount; i++)
                        fields.Add(new KeyValuePair<string, string>(GetChild(2 * i + 1).Text, GetChild(2 * i + 2).Text));
                }
                return fields;
            }
        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            SemanticInfo fieldInfo;

            for (int i = 0; i < FieldsCount; i++)
            {
                ///los tipos de los campos tienen que haber sido declarados
                if (!symbolTable.GetDefinedTypeDeep(Fields[i].Value, out fieldInfo))
                {
                    errors.Add(new CompileError
                    {
                        Line = GetChild(2 * i + 2).Line,
                        Column = GetChild(2 * i + 2).CharPositionInLine,
                        ErrorMessage = string.Format("Type '{0}' could not be found in current context", Fields[i].Value),
                        Kind = ErrorKind.Semantic
                    });

                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }
                else
                    realFields.Add(fieldInfo);

                for (int j = 0; j < i; j++)
                {
                    ///chequeamos que no existan 2 campos con el mismo nombre
                    if (Fields[i].Key.Equals(Fields[j].Key))
                    {
                        errors.Add(new CompileError
                        {
                            Line = GetChild(2 * i + 1).Line,
                            Column = GetChild(2 * i + 1).CharPositionInLine,
                            ErrorMessage = string.Format("The field name '{0}' is a duplicate", Fields[i].Key),
                            Kind = ErrorKind.Semantic
                        });

                        ///el nodo evalúa de error
                        NodeInfo = SemanticInfo.SemanticError;
                    }
                }
            }

            /////si no ha evaluado de error le seteamos los valores
            //if (!Object.Equals(NodeInfo, SemanticInfo.SemanticError))
            //{
            //    NodeInfo.Type = SemanticInfo.Void;
            //    NodeInfo.BuiltInType = BuiltInType.Void;
            //}

            ///si evaluó de error
            if (Object.Equals(NodeInfo, SemanticInfo.SemanticError))
            {
                ///no declaramos el record porque uno de sus campos no existe
                return;
            }

            ///seteamos la información del NodeInfo
            NodeInfo.Type = SemanticInfo.Void;
            NodeInfo.BuiltInType = BuiltInType.Void;

            List<KeyValuePair<string, SemanticInfo>> fields = new List<KeyValuePair<string, SemanticInfo>>();
            ///guardamos los fields del record
            for (int i = 0; i < FieldsCount; i++)
            {
                fields.Add(new KeyValuePair<string, SemanticInfo>(Fields[i].Key, realFields[i]));
            }

            SemanticInfo recordAlias;

            symbolTable.GetDefinedTypeDeep(RecordId, out recordAlias);
            recordAlias.BuiltInType = BuiltInType.Record;
            recordAlias.Fields = fields;
            recordAlias.IsPending = false;
            recordAlias.Type = recordAlias;

            recordParche = recordAlias;
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            if (firstPass)
            {
                TypeBuilder tb = cg.Module.DefineType(RecordId + cg.ILContextTable.ContextNumber);
                cg.ILContextTable.InsertILElement(RecordId, new ILElementInfo { TypeBuilder = tb, ILType = tb , ElementKind = SymbolKind.Type});
                recordParche.ILType = tb;
                firstPass = false;
            }
            else
            {
                ILElementInfo ile = cg.ILContextTable.GetDefinedType(RecordId);

                FieldBuilder fbTmp;
                List<Type> fieldsILType = new List<Type>();
                for (int i = 0; i < FieldsCount; i++)
                {
                    fbTmp = ile.TypeBuilder.DefineField(Fields[i].Key, realFields[i].Type.ILType, FieldAttributes.Public);
                    ile.FieldsOfContainerClass.Add(fbTmp);
                    fieldsILType.Add(realFields[i].Type.ILType);
                }
                
                ConstructorBuilder ctor = ile.TypeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, fieldsILType.ToArray());
                ILGenerator cgCtor = ctor.GetILGenerator();
                cgCtor.Emit(OpCodes.Ldarg_0);
                cgCtor.Emit(OpCodes.Call, typeof(object).GetConstructor(System.Type.EmptyTypes));
                for (int i = 0; i < Fields.Count; i++)
                {
                    cgCtor.Emit(OpCodes.Ldarg_0);
                    cgCtor.Emit(OpCodes.Ldarg, i + 1);
                    cgCtor.Emit(OpCodes.Stfld, ile.FieldsOfContainerClass[i]);
                }
                cgCtor.Emit(OpCodes.Ret);
                ile.TypeBuilder.CreateType();
            }
        }
    }
}
