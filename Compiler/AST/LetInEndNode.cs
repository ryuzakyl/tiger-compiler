using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;

using Compiler.Utils;
using Compiler.SemanticStructures;
using Compiler.Errors;
using Compiler.CodeGenerators;
using System.Reflection.Emit;

namespace Compiler.AST
{
    public class LetInEndNode : AssignableExpressionNode
    {
        public LetInEndNode(IToken token) : base(token)
        {
            ListOfLocalDeclarations = new List<KeyValuePair<LocalBuilder, FieldBuilder>>();
        }
        
        enum DeclarationType { CALLABLE, VARIABLE, TYPE, NONE }

        public DeclarationNode GetLetDeclarationAt(int i)
        {
            if (i < 0 || i >= LetDeclarationCount)
                throw new IndexOutOfRangeException("There is no such declaration.");

            return GetChild(0).GetChild(i) as DeclarationNode;
        }

        public int LetDeclarationCount
        {
            get { return GetChild(0).ChildCount; }
        }

        public ExpressionSequenceNode ExpressionSequence
        {
            get { return GetChild(1) as ExpressionSequenceNode; }
        }

        public override void CheckSemantic(SymbolTable symbolTable, List<CompileError> errors)
        {
            ///la instrucción let-in-end genera un nuevo scope
            symbolTable.InitNewScope();

            #region CheckSemantic_of_Declarations_List

            DeclarationNode currentDeclaration;
            DeclarationType previousDeclarationType = DeclarationType.NONE;
            List<DeclarationNode> pendingDeclarations = new List<DeclarationNode>();

            ///chequeamos la semántica de C/U de las declaraciones
            for (int i = 0; i < LetDeclarationCount; i++)
            {
                currentDeclaration = GetLetDeclarationAt(i);

                if (GetDeclarationType(currentDeclaration) != previousDeclarationType && pendingDeclarations.Count > 0)
                {
                    CommitPendingDeclarations(symbolTable, errors, pendingDeclarations);
                    pendingDeclarations.Clear();
                }

                if (GetDeclarationType(currentDeclaration) == DeclarationType.VARIABLE)
                    currentDeclaration.CheckSemantic(symbolTable, errors);
                else
                    pendingDeclarations.Add(currentDeclaration);

                previousDeclarationType = GetDeclarationType(currentDeclaration);
            }

            ///chequeamos el último bloque
            if (pendingDeclarations.Count > 0)
            {
                CommitPendingDeclarations(symbolTable, errors, pendingDeclarations);
                pendingDeclarations.Clear();
            }
            #endregion

            ///chequeamos la semántica de ExpressionSequence
            ExpressionSequence.CheckSemantic(symbolTable, errors);

            ///si el ExpressionSequence evalúa de error, este también
            if (Object.Equals(ExpressionSequence.NodeInfo, SemanticInfo.SemanticError))
            {
                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }

            ///el scope de let-in-end termina en el end
            symbolTable.CloseCurrentScope();

            ///si este no evaluó de error
            if (!Object.Equals(NodeInfo, SemanticInfo.SemanticError))
            {
                NodeInfo = new SemanticInfo
                {
                    Name = SemanticInfo.NoName,
                    BuiltInType = ExpressionSequence.NodeInfo.BuiltInType,
                    ElementKind = SymbolKind.NoSymbol,
                    Type = ExpressionSequence.NodeInfo.Type,
                    
                    ElementsType = ExpressionSequence.NodeInfo.ElementsType,
                    Fields = ExpressionSequence.NodeInfo.Fields,

                    //added
                    ILType = ExpressionSequence.NodeInfo.ILType
                };
            }
        }

        DeclarationType GetDeclarationType(DeclarationNode declaration)
        {
            if (declaration is CallableDeclarationNode)
                return DeclarationType.CALLABLE;
            else if (declaration is VarDeclarationNode)
                return DeclarationType.VARIABLE;
            else if (declaration is TypeDeclarationNode)
                return DeclarationType.TYPE;
            else
                throw new InvalidOperationException("Nodo no válido");
        }

        private void CommitPendingDeclarations(SymbolTable symbolTable, List<CompileError> errors, List<DeclarationNode> pendingDeclarations)
        {
            Graph<string> g = new Graph<string>();
            DeclarationNode currentDeclarationNode;
            AliasDeclarationNode aliasNode;
            ArrayDeclarationNode arrayNode;

            ///hacemos otra pasada por cada declaración
            for (int i = 0; i < pendingDeclarations.Count; i++)
            {
                currentDeclarationNode = pendingDeclarations[i];
                currentDeclarationNode.CheckSignatureSemantic(symbolTable, errors);

                ///si una de estas tiene un error este evalúa de error
                if (Object.Equals(pendingDeclarations[i].NodeInfo, SemanticInfo.SemanticError))
                {
                    ///el nodo evalúa de error
                    NodeInfo = SemanticInfo.SemanticError;
                }

                if (currentDeclarationNode is AliasDeclarationNode)
                {
                    aliasNode = (AliasDeclarationNode)currentDeclarationNode;

                    g.AddVertex(aliasNode.AliasId);
                    g.AddVertex(aliasNode.OriginalId);
                    g.AddEdge(aliasNode.AliasId, aliasNode.OriginalId);
                }
                else if (currentDeclarationNode is ArrayDeclarationNode)
                {
                    arrayNode = (ArrayDeclarationNode)currentDeclarationNode;

                    g.AddVertex(arrayNode.ArrayId);
                    g.AddVertex(arrayNode.ElementsId);
                    g.AddEdge(arrayNode.ArrayId, arrayNode.ElementsId);
                }

            }

            if (g.HasCycle())
            {
                errors.Add(new CompileError
                {
                    Line = this.Line,
                    Column = this.CharPositionInLine,
                    ErrorMessage = "Defining mutually recursive types that do not pass through record or array is not allowed",
                    Kind = ErrorKind.Semantic
                });

                ///el nodo evalúa de error
                NodeInfo = SemanticInfo.SemanticError;
            }
            else
            {
                for (int i = 0; i < pendingDeclarations.Count; i++)
                {
                    currentDeclarationNode = pendingDeclarations[i];

                    ///si en el CheckSignatureSemantic evaluó de error no le checkeo semántica
                    if (!Object.Equals(currentDeclarationNode.NodeInfo, SemanticInfo.SemanticError))
                    {
                        currentDeclarationNode.CheckSemantic(symbolTable, errors);
                    }
                    else
                    {
                        ///el nodo evalúa de error
                        NodeInfo = SemanticInfo.SemanticError;
                    }

                    //currentDeclarationNode.CheckSemantic(symbolTable, errors);

                    ////si una de estas tiene un error este evalúa de error
                    //if (Object.Equals(currentDeclarationNode.NodeInfo, SemanticInfo.SemanticError))
                    //{
                    //    ///el nodo evalúa de error
                    //    NodeInfo = SemanticInfo.SemanticError;
                    //}
                }
            }

        }

        public override void GenerateCode(ILCodeGenerator cg)
        {
            cg.ILContextTable.InitNewContext();

            DeclarationNode currentDeclaration;
            DeclarationType previousDeclarationType = DeclarationType.NONE;
            List<DeclarationNode> pendingDeclarations = new List<DeclarationNode>();

            //chequeamos la semantica de C/U de las declaraciones
            for (int i = 0; i < LetDeclarationCount; i++)
            {
                currentDeclaration = GetLetDeclarationAt(i);

                if (GetDeclarationType(currentDeclaration) != previousDeclarationType && pendingDeclarations.Count > 0)
                {
                    CommitPendingGenerations(cg, pendingDeclarations);
                    pendingDeclarations.Clear();
                }

                if (GetDeclarationType(currentDeclaration) == DeclarationType.VARIABLE)
                {
                    currentDeclaration.GenerateCode(cg);

                    //change
                    VarDeclarationNode vdn = currentDeclaration as VarDeclarationNode;
                    ListOfLocalDeclarations.Add(new KeyValuePair<LocalBuilder,FieldBuilder>(vdn.VariableLocalBuilder, vdn.VariableFieldBuilder));
                }
                else
                    pendingDeclarations.Add(currentDeclaration);

                previousDeclarationType = GetDeclarationType(currentDeclaration);
            }

            if (pendingDeclarations.Count > 0)
            {
                CommitPendingGenerations(cg, pendingDeclarations);
                pendingDeclarations.Clear();
            }

            ExpressionSequence.GenerateCode(cg);

            cg.ILContextTable.CloseCurrentContext();
        }

        private void CommitPendingGenerations(ILCodeGenerator cg, List<DeclarationNode> pendingDeclarations)
        {
            for (int i = 0; i < pendingDeclarations.Count; i++)
            {
                pendingDeclarations[i].GenerateCode(cg);
            }

            for (int i = 0; i < pendingDeclarations.Count; i++)
            {
                if (pendingDeclarations[i] is CallableDeclarationNode || pendingDeclarations[i] is RecordDeclarationNode)
                    pendingDeclarations[i].GenerateCode(cg);
            }
        }

        public List<KeyValuePair<LocalBuilder, FieldBuilder>> ListOfLocalDeclarations { get; set; }
    }
}
