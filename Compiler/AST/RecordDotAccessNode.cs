using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;
using Compiler.SemanticStructures;
using Compiler.Errors;
using Compiler.CodeGenerators;
using System.Reflection;
using System.Reflection.Emit;

namespace Compiler.AST
{
    public class RecordDotAccessNode : AccessNode
    {
        public RecordDotAccessNode(IToken token) : base(token)
        {

        }

        /// <summary>
        /// Expresion a la que se le hace punto
        /// </summary>
        public ExpressionNode DotedExpression
        {
            get { return GetChild(0) as ExpressionNode; }
        }

        /// <summary>
        /// Representa el id que se usa para acceder a un campo del record.
        /// </summary>
        public string ID
        {
            get { return GetChild(1).Text; }
        }

        public string RecordName { get; set; }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            //se manda a chequear semanticamente la expresion a la que se le hizo punto
            DotedExpression.CheckSemantic(symbolTable, errors);

            //si DotedExpression evalua de error este tambien evalua de error
            if (Object.Equals(DotedExpression.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
                return;
            }

            //la expresion tiene que ser compatible con record
            if (!DotedExpression.NodeInfo.BuiltInType.IsCompatibleWith(BuiltInType.Record))
            {
                errors.Add(new CompileError
                {
                    Line = GetChild(1).Line,
                    Column = GetChild(1).CharPositionInLine,
                    ErrorMessage = "Dot notation can only be applied to 'record' types",
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            ///si este nodo evaluó de error
            if (Object.Equals(NodeInfo, SemanticInfo.SemanticError))
            {
                ///terminamos de chequear la semántica de este nodo
                return;
            }

            //verificamos que el record tenga un campo con el nombre ID
            bool existField = false;
            foreach (var field in DotedExpression.NodeInfo.Fields)
            {
                if (field.Key.Equals(ID))
                {
                    existField = true;

                    NodeInfo.Type = field.Value.Type;
                    NodeInfo.BuiltInType = field.Value.BuiltInType;
                    NodeInfo.ElementsType = field.Value.ElementsType;
                    NodeInfo.Fields = field.Value.Fields;
                    break;
                }

            }

            if (!existField)
            {
                errors.Add(new CompileError
                {
                    Line = GetChild(1).Line,
                    Column = GetChild(1).CharPositionInLine,
                    ErrorMessage = string.Format("Type '{0}' does not contain a definition for '{1}'", DotedExpression.NodeInfo.Type.Name, ID),
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }
            RecordName = DotedExpression.NodeInfo.Type.Name;
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            DotedExpression.GenerateCode(cg);

            if (LoadVariableInTheStack)
            {
                ILElementInfo ile = cg.ILContextTable.GetDefinedType(RecordName);
                FieldInfo fi = ile.TypeBuilder.GetField(ID);
                cg.ILGenerator.Emit(OpCodes.Ldfld, fi);
            }
        }
    }
}
