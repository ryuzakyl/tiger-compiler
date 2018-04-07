using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using Compiler.Errors;
using Compiler.CodeGenerators;

using System.Reflection.Emit;

namespace Compiler.AST
{
    public class NilConstantNode : ConstantExpressionNode
    {
        public NilConstantNode(IToken token) : base(token)
        {

        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///seteamos la información del NodeInfo
            NodeInfo.BuiltInType = BuiltInType.Nil;
            NodeInfo.Type = SemanticInfo.Nil;
            NodeInfo.ILType = null;
        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            ///cargamos null en la pila
            cg.ILGenerator.Emit(OpCodes.Ldnull);
        }
    }
}
