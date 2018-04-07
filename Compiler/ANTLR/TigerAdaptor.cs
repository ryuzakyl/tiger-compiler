using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime.Tree;
using Antlr.Runtime;

using Compiler.AST;

namespace Compiler.ANTLR
{
    public class TigerAdaptor : CommonTreeAdaptor
    {
        public override object Create(IToken payload)
        {

            if (payload == null)
                return base.Create(payload);

            switch (payload.Type)
            {
                case TigerLexer.ALIAS_DECLARATION:
                    return new AliasDeclarationNode(payload);

                case TigerLexer.AND:
                    return new AndOperationNode(payload);

                case TigerLexer.ARRAY_CREATION:
                    return new ArrayCreationNode(payload);

                case TigerLexer.ARRAY_DECLARATION:
                    return new ArrayDeclarationNode(payload);

                case TigerLexer.ARRAY_ACCESS:
                    return new ArrayIndexAccessNode(payload);

                case TigerLexer.ASSIGN:
                    return new AssignInstructionNode(payload);

                case TigerLexer.BREAK:
                    return new BreakNode(payload);

                case TigerLexer.CALLABLE_CALL:
                    return new CallableCallNode(payload);

                case TigerLexer.DIV:
                    return new DivisionOperationNode(payload);

                case TigerLexer.EQUALS:
                    return new EqualOperationNode(payload);

                case TigerLexer.EXPR_SEQ:
                    return new ExpressionSequenceNode(payload);

                case TigerLexer.FOR:
                    return new ForLoopNode(payload);

                case TigerLexer.FUNCTION_DECLARATION:
                    return new FunctionDeclarationNode(payload);

                case TigerLexer.GREATER:
                    return new GreaterThanOperationNode(payload);

                case TigerLexer.GREATER_EQUALS:
                    return new GreaterEqualOperationNode(payload);

                case TigerLexer.IF_THEN:
                    return new IfThenNode(payload);

                case TigerLexer.IF_THEN_ELSE:
                    return new IfThenElseNode(payload);

                case TigerLexer.INFERRED_VAR_DECLARATION:
                    return new InferredVarDeclarationNode(payload);

                case TigerLexer.INT:
                    return new IntConstantNode(payload);

                case TigerLexer.LET:
                    return new LetInEndNode(payload);

                case TigerLexer.LESS:
                    return new LessThanOperationNode(payload);

                case TigerLexer.LESS_EQUALS:
                    return new LessEqualThanOperationNode(payload);

                case TigerLexer.LVALUE_ID:
                    return new LValueIdNode(payload);

                case TigerLexer.MINUS:
                    return new MinusOperationNode(payload);

                case TigerLexer.MINUS_UNARY:
                    return new UnaryMinusOperationNode(payload);

                case TigerLexer.MULT:
                    return new MultiplicationOperationNode(payload);

                case TigerLexer.NIL:
                    return new NilConstantNode(payload);

                case TigerLexer.NOT_EQUALS:
                    return new NotEqualOperationNode(payload);

                case TigerLexer.OR:
                    return new OrOperationNode(payload);

                case TigerLexer.PLUS:
                    return new PlusOperationNode(payload);

                case TigerLexer.PROCEDURE_DECLARATION:
                    return new ProcedureDeclarationNode(payload);

                case TigerLexer.RECORD_ACCESS:
                    return new RecordDotAccessNode(payload);

                case TigerLexer.RECORD_CREATION:
                    return new RecordCreationNode(payload);

                case TigerLexer.RECORD_DECLARATION:
                    return new RecordDeclarationNode(payload);

                case TigerLexer.STRING:
                    return new StringConstantNode(payload);
                
                /*
                case TigerLexer.TAIL:
                    return new NoAccessNode(payload);
                */
                
                case TigerLexer.TYPED_VAR_DECLARATION:
                    return new TypedVarDeclarationNode(payload);

                case TigerLexer.WHILE:
                    return new WhileLoopNode(payload);

                default:
                    return base.Create(payload);
            }
        }
    }
}
