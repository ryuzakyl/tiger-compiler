using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;

using Compiler.SemanticStructures;
using System.Reflection.Emit;

namespace Compiler.AST
{
    public abstract class ExpressionNode : TigerProgramNode
    {
        public ExpressionNode(IToken token)
            : base(token)
        {
            ///instanciamos el NodeInfo
            NodeInfo = new SemanticInfo();
            LoadVariableInTheStack = true;
        }

        /// <summary>
        /// Represents the semantic information of the node
        /// </summary>
        /// <remarks>Is an attempt to simulate the Attribute Grammars</remarks>
        public SemanticInfo NodeInfo { get; set; }

        public bool LoadVariableInTheStack { get; set; }

        public List<KeyValuePair<LocalBuilder, FieldBuilder>> GetLocalVariableDeclarations()
        {
            List<KeyValuePair<LocalBuilder, FieldBuilder>> result = new List<KeyValuePair<LocalBuilder, FieldBuilder>>();

            if (this is LetInEndNode)
            {
                result.AddRange((this as LetInEndNode).ListOfLocalDeclarations);
                result.AddRange((this as LetInEndNode).ExpressionSequence.GetLocalVariableDeclarations());
            }
            else if (this is ExpressionSequenceNode)
            {
                ExpressionSequenceNode exprSeq = this as ExpressionSequenceNode;
                for (int i = 0; i < exprSeq.ExpressionCount; i++)
                {
                    if (exprSeq.ExpressionAt(i) is LetInEndNode) 
                        result.AddRange(exprSeq.ExpressionAt(i).GetLocalVariableDeclarations());
                }
            }
            return result;

        }
    }
}
