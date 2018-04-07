// $ANTLR 3.3 Nov 30, 2010 12:45:30 C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g 2012-03-08 10:43:44

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;
using Map = System.Collections.IDictionary;
using HashMap = System.Collections.Generic.Dictionary<object, object>;

using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
[System.CLSCompliant(false)]
public partial class TigerGrammarParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "ARRAY", "IF", "THEN", "ELSE", "WHILE", "FOR", "TO", "DO", "LET", "IN", "END", "OF", "BREAK", "NIL", "FUNCTION", "VAR", "TYPE", "DOT", "COMMA", "COLON", "SEMICOLON", "L_PARENT", "R_PARENT", "L_BRACKET", "R_BRACKET", "L_BRACE", "R_BRACE", "PLUS", "MINUS", "MULT", "DIV", "EQUALS", "NOT_EQUALS", "LESS", "LESS_EQUALS", "GREATER", "GREATER_EQUALS", "AND", "OR", "ASSIGN", "OPEN_COMMENT", "CLOSE_COMMENT", "TYPED_VAR_DECLARATION", "INFERRED_VAR_DECLARATION", "RECORD_DECLARATION", "ALIAS_DECLARATION", "ARRAY_DECLARATION", "ARRAY_CREATION", "RECORD_CREATION", "FUNCTION_DECLARATION", "PROCEDURE_DECLARATION", "CALLABLE_CALL", "MINUS_UNARY", "RECORD_ACCESS", "ARRAY_ACCESS", "LVALUE_ID", "IF_THEN", "IF_THEN_ELSE", "DECLARATION_LIST", "EXPR_SEQ", "INT", "STRING", "ID", "LETTER", "DEC_DIGIT", "COMMENT", "WS", "ESC_SEQ", "HEX_DIGIT", "ASCII_ESC"
	};
	public const int EOF=-1;
	public const int ARRAY=4;
	public const int IF=5;
	public const int THEN=6;
	public const int ELSE=7;
	public const int WHILE=8;
	public const int FOR=9;
	public const int TO=10;
	public const int DO=11;
	public const int LET=12;
	public const int IN=13;
	public const int END=14;
	public const int OF=15;
	public const int BREAK=16;
	public const int NIL=17;
	public const int FUNCTION=18;
	public const int VAR=19;
	public const int TYPE=20;
	public const int DOT=21;
	public const int COMMA=22;
	public const int COLON=23;
	public const int SEMICOLON=24;
	public const int L_PARENT=25;
	public const int R_PARENT=26;
	public const int L_BRACKET=27;
	public const int R_BRACKET=28;
	public const int L_BRACE=29;
	public const int R_BRACE=30;
	public const int PLUS=31;
	public const int MINUS=32;
	public const int MULT=33;
	public const int DIV=34;
	public const int EQUALS=35;
	public const int NOT_EQUALS=36;
	public const int LESS=37;
	public const int LESS_EQUALS=38;
	public const int GREATER=39;
	public const int GREATER_EQUALS=40;
	public const int AND=41;
	public const int OR=42;
	public const int ASSIGN=43;
	public const int OPEN_COMMENT=44;
	public const int CLOSE_COMMENT=45;
	public const int TYPED_VAR_DECLARATION=46;
	public const int INFERRED_VAR_DECLARATION=47;
	public const int RECORD_DECLARATION=48;
	public const int ALIAS_DECLARATION=49;
	public const int ARRAY_DECLARATION=50;
	public const int ARRAY_CREATION=51;
	public const int RECORD_CREATION=52;
	public const int FUNCTION_DECLARATION=53;
	public const int PROCEDURE_DECLARATION=54;
	public const int CALLABLE_CALL=55;
	public const int MINUS_UNARY=56;
	public const int RECORD_ACCESS=57;
	public const int ARRAY_ACCESS=58;
	public const int LVALUE_ID=59;
	public const int IF_THEN=60;
	public const int IF_THEN_ELSE=61;
	public const int DECLARATION_LIST=62;
	public const int EXPR_SEQ=63;
	public const int INT=64;
	public const int STRING=65;
	public const int ID=66;
	public const int LETTER=67;
	public const int DEC_DIGIT=68;
	public const int COMMENT=69;
	public const int WS=70;
	public const int ESC_SEQ=71;
	public const int HEX_DIGIT=72;
	public const int ASCII_ESC=73;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				true, false, false, false, false, false, false, false, false, false, 
				false, false, true, false, false, false, false, true, false, false, 
				false, false, false, false, false, false, false, false, false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public TigerGrammarParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public TigerGrammarParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[33+1];

		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return TigerGrammarParser.tokenNames; } }
	public override string GrammarFileName { get { return "C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_program();
	partial void Leave_program();

	// $ANTLR start "program"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:93:8: public program : expr EOF ;
	[GrammarRule("program")]
	public TigerGrammarParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 1);
		TraceIn("program", 1);
		TigerGrammarParser.program_return retval = new TigerGrammarParser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EOF2=null;
		TigerGrammarParser.expr_return expr1 = default(TigerGrammarParser.expr_return);

		object EOF2_tree=null;

		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(93, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:94:2: ( expr EOF )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:95:3: expr EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(95, 3);
			PushFollow(Follow._expr_in_program545);
			expr1=expr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr1.Tree);
			DebugLocation(95, 11);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_program547); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("program", 1);
			LeaveRule("program", 1);
			Leave_program();
		}
		DebugLocation(96, 1);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return retval;

	}
	// $ANTLR end "program"

	public class expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr();
	partial void Leave_expr();

	// $ANTLR start "expr"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:98:1: expr options {backtrack=true; memoize=true; } : ( array_creation | assign_expr | expr_or | control_instr | let_in_end );
	[GrammarRule("expr")]
	private TigerGrammarParser.expr_return expr()
	{
		Enter_expr();
		EnterRule("expr", 2);
		TraceIn("expr", 2);
		TigerGrammarParser.expr_return retval = new TigerGrammarParser.expr_return();
		retval.Start = (IToken)input.LT(1);
		int expr_StartIndex = input.Index;
		object root_0 = null;

		TigerGrammarParser.array_creation_return array_creation3 = default(TigerGrammarParser.array_creation_return);
		TigerGrammarParser.assign_expr_return assign_expr4 = default(TigerGrammarParser.assign_expr_return);
		TigerGrammarParser.expr_or_return expr_or5 = default(TigerGrammarParser.expr_or_return);
		TigerGrammarParser.control_instr_return control_instr6 = default(TigerGrammarParser.control_instr_return);
		TigerGrammarParser.let_in_end_return let_in_end7 = default(TigerGrammarParser.let_in_end_return);


		try { DebugEnterRule(GrammarFileName, "expr");
		DebugLocation(98, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:99:2: ( array_creation | assign_expr | expr_or | control_instr | let_in_end )
			int alt1=5;
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			try
			{
				alt1 = dfa1.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:99:4: array_creation
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(99, 4);
				PushFollow(Follow._array_creation_in_expr577);
				array_creation3=array_creation();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_creation3.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:100:10: assign_expr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(100, 10);
				PushFollow(Follow._assign_expr_in_expr588);
				assign_expr4=assign_expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assign_expr4.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:101:10: expr_or
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(101, 10);
				PushFollow(Follow._expr_or_in_expr600);
				expr_or5=expr_or();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr_or5.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:102:10: control_instr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(102, 10);
				PushFollow(Follow._control_instr_in_expr611);
				control_instr6=control_instr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, control_instr6.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:103:10: let_in_end
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(103, 10);
				PushFollow(Follow._let_in_end_in_expr622);
				let_in_end7=let_in_end();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, let_in_end7.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr", 2);
			LeaveRule("expr", 2);
			Leave_expr();
			if (state.backtracking > 0) { Memoize(input, 2, expr_StartIndex); }
		}
		DebugLocation(104, 1);
		} finally { DebugExitRule(GrammarFileName, "expr"); }
		return retval;

	}
	// $ANTLR end "expr"

	public class expr_or_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr_or();
	partial void Leave_expr_or();

	// $ANTLR start "expr_or"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:106:1: expr_or : expr_and ( OR expr_and )* ;
	[GrammarRule("expr_or")]
	private TigerGrammarParser.expr_or_return expr_or()
	{
		Enter_expr_or();
		EnterRule("expr_or", 3);
		TraceIn("expr_or", 3);
		TigerGrammarParser.expr_or_return retval = new TigerGrammarParser.expr_or_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken OR9=null;
		TigerGrammarParser.expr_and_return expr_and8 = default(TigerGrammarParser.expr_and_return);
		TigerGrammarParser.expr_and_return expr_and10 = default(TigerGrammarParser.expr_and_return);

		object OR9_tree=null;

		try { DebugEnterRule(GrammarFileName, "expr_or");
		DebugLocation(106, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:107:2: ( expr_and ( OR expr_and )* )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:108:3: expr_and ( OR expr_and )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(108, 3);
			PushFollow(Follow._expr_and_in_expr_or638);
			expr_and8=expr_and();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr_and8.Tree);
			DebugLocation(108, 12);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:108:12: ( OR expr_and )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0==OR))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:108:13: OR expr_and
					{
					DebugLocation(108, 15);
					OR9=(IToken)Match(input,OR,Follow._OR_in_expr_or641); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR9_tree = (object)adaptor.Create(OR9);
					root_0 = (object)adaptor.BecomeRoot(OR9_tree, root_0);
					}
					DebugLocation(108, 17);
					PushFollow(Follow._expr_and_in_expr_or644);
					expr_and10=expr_and();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr_and10.Tree);

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr_or", 3);
			LeaveRule("expr_or", 3);
			Leave_expr_or();
		}
		DebugLocation(109, 1);
		} finally { DebugExitRule(GrammarFileName, "expr_or"); }
		return retval;

	}
	// $ANTLR end "expr_or"

	public class expr_and_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr_and();
	partial void Leave_expr_and();

	// $ANTLR start "expr_and"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:111:1: expr_and : expr_rel ( AND expr_rel )* ;
	[GrammarRule("expr_and")]
	private TigerGrammarParser.expr_and_return expr_and()
	{
		Enter_expr_and();
		EnterRule("expr_and", 4);
		TraceIn("expr_and", 4);
		TigerGrammarParser.expr_and_return retval = new TigerGrammarParser.expr_and_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken AND12=null;
		TigerGrammarParser.expr_rel_return expr_rel11 = default(TigerGrammarParser.expr_rel_return);
		TigerGrammarParser.expr_rel_return expr_rel13 = default(TigerGrammarParser.expr_rel_return);

		object AND12_tree=null;

		try { DebugEnterRule(GrammarFileName, "expr_and");
		DebugLocation(111, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:112:2: ( expr_rel ( AND expr_rel )* )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:113:3: expr_rel ( AND expr_rel )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(113, 3);
			PushFollow(Follow._expr_rel_in_expr_and660);
			expr_rel11=expr_rel();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr_rel11.Tree);
			DebugLocation(113, 12);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:113:12: ( AND expr_rel )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if ((LA3_0==AND))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:113:13: AND expr_rel
					{
					DebugLocation(113, 16);
					AND12=(IToken)Match(input,AND,Follow._AND_in_expr_and663); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND12_tree = (object)adaptor.Create(AND12);
					root_0 = (object)adaptor.BecomeRoot(AND12_tree, root_0);
					}
					DebugLocation(113, 18);
					PushFollow(Follow._expr_rel_in_expr_and666);
					expr_rel13=expr_rel();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr_rel13.Tree);

					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr_and", 4);
			LeaveRule("expr_and", 4);
			Leave_expr_and();
		}
		DebugLocation(114, 1);
		} finally { DebugExitRule(GrammarFileName, "expr_and"); }
		return retval;

	}
	// $ANTLR end "expr_and"

	public class expr_rel_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr_rel();
	partial void Leave_expr_rel();

	// $ANTLR start "expr_rel"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:116:1: expr_rel : expr_arit ( ( EQUALS | NOT_EQUALS | LESS | LESS_EQUALS | GREATER | GREATER_EQUALS ) expr_arit )? ;
	[GrammarRule("expr_rel")]
	private TigerGrammarParser.expr_rel_return expr_rel()
	{
		Enter_expr_rel();
		EnterRule("expr_rel", 5);
		TraceIn("expr_rel", 5);
		TigerGrammarParser.expr_rel_return retval = new TigerGrammarParser.expr_rel_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EQUALS15=null;
		IToken NOT_EQUALS16=null;
		IToken LESS17=null;
		IToken LESS_EQUALS18=null;
		IToken GREATER19=null;
		IToken GREATER_EQUALS20=null;
		TigerGrammarParser.expr_arit_return expr_arit14 = default(TigerGrammarParser.expr_arit_return);
		TigerGrammarParser.expr_arit_return expr_arit21 = default(TigerGrammarParser.expr_arit_return);

		object EQUALS15_tree=null;
		object NOT_EQUALS16_tree=null;
		object LESS17_tree=null;
		object LESS_EQUALS18_tree=null;
		object GREATER19_tree=null;
		object GREATER_EQUALS20_tree=null;

		try { DebugEnterRule(GrammarFileName, "expr_rel");
		DebugLocation(116, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:117:2: ( expr_arit ( ( EQUALS | NOT_EQUALS | LESS | LESS_EQUALS | GREATER | GREATER_EQUALS ) expr_arit )? )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:118:3: expr_arit ( ( EQUALS | NOT_EQUALS | LESS | LESS_EQUALS | GREATER | GREATER_EQUALS ) expr_arit )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(118, 3);
			PushFollow(Follow._expr_arit_in_expr_rel682);
			expr_arit14=expr_arit();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr_arit14.Tree);
			DebugLocation(118, 13);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:118:13: ( ( EQUALS | NOT_EQUALS | LESS | LESS_EQUALS | GREATER | GREATER_EQUALS ) expr_arit )?
			int alt5=2;
			try { DebugEnterSubRule(5);
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			int LA5_0 = input.LA(1);

			if (((LA5_0>=EQUALS && LA5_0<=GREATER_EQUALS)))
			{
				alt5=1;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:118:14: ( EQUALS | NOT_EQUALS | LESS | LESS_EQUALS | GREATER | GREATER_EQUALS ) expr_arit
				{
				DebugLocation(118, 14);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:118:14: ( EQUALS | NOT_EQUALS | LESS | LESS_EQUALS | GREATER | GREATER_EQUALS )
				int alt4=6;
				try { DebugEnterSubRule(4);
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				switch (input.LA(1))
				{
				case EQUALS:
					{
					alt4=1;
					}
					break;
				case NOT_EQUALS:
					{
					alt4=2;
					}
					break;
				case LESS:
					{
					alt4=3;
					}
					break;
				case LESS_EQUALS:
					{
					alt4=4;
					}
					break;
				case GREATER:
					{
					alt4=5;
					}
					break;
				case GREATER_EQUALS:
					{
					alt4=6;
					}
					break;
				default:
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 4, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}

				} finally { DebugExitDecision(4); }
				switch (alt4)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:118:15: EQUALS
					{
					DebugLocation(118, 21);
					EQUALS15=(IToken)Match(input,EQUALS,Follow._EQUALS_in_expr_rel686); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					EQUALS15_tree = (object)adaptor.Create(EQUALS15);
					root_0 = (object)adaptor.BecomeRoot(EQUALS15_tree, root_0);
					}

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:118:26: NOT_EQUALS
					{
					DebugLocation(118, 36);
					NOT_EQUALS16=(IToken)Match(input,NOT_EQUALS,Follow._NOT_EQUALS_in_expr_rel692); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					NOT_EQUALS16_tree = (object)adaptor.Create(NOT_EQUALS16);
					root_0 = (object)adaptor.BecomeRoot(NOT_EQUALS16_tree, root_0);
					}

					}
					break;
				case 3:
					DebugEnterAlt(3);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:118:40: LESS
					{
					DebugLocation(118, 44);
					LESS17=(IToken)Match(input,LESS,Follow._LESS_in_expr_rel697); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					LESS17_tree = (object)adaptor.Create(LESS17);
					root_0 = (object)adaptor.BecomeRoot(LESS17_tree, root_0);
					}

					}
					break;
				case 4:
					DebugEnterAlt(4);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:118:48: LESS_EQUALS
					{
					DebugLocation(118, 59);
					LESS_EQUALS18=(IToken)Match(input,LESS_EQUALS,Follow._LESS_EQUALS_in_expr_rel702); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					LESS_EQUALS18_tree = (object)adaptor.Create(LESS_EQUALS18);
					root_0 = (object)adaptor.BecomeRoot(LESS_EQUALS18_tree, root_0);
					}

					}
					break;
				case 5:
					DebugEnterAlt(5);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:118:63: GREATER
					{
					DebugLocation(118, 70);
					GREATER19=(IToken)Match(input,GREATER,Follow._GREATER_in_expr_rel707); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					GREATER19_tree = (object)adaptor.Create(GREATER19);
					root_0 = (object)adaptor.BecomeRoot(GREATER19_tree, root_0);
					}

					}
					break;
				case 6:
					DebugEnterAlt(6);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:118:74: GREATER_EQUALS
					{
					DebugLocation(118, 88);
					GREATER_EQUALS20=(IToken)Match(input,GREATER_EQUALS,Follow._GREATER_EQUALS_in_expr_rel712); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					GREATER_EQUALS20_tree = (object)adaptor.Create(GREATER_EQUALS20);
					root_0 = (object)adaptor.BecomeRoot(GREATER_EQUALS20_tree, root_0);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(4); }

				DebugLocation(118, 91);
				PushFollow(Follow._expr_arit_in_expr_rel716);
				expr_arit21=expr_arit();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr_arit21.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(5); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr_rel", 5);
			LeaveRule("expr_rel", 5);
			Leave_expr_rel();
		}
		DebugLocation(119, 1);
		} finally { DebugExitRule(GrammarFileName, "expr_rel"); }
		return retval;

	}
	// $ANTLR end "expr_rel"

	public class expr_arit_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr_arit();
	partial void Leave_expr_arit();

	// $ANTLR start "expr_arit"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:121:1: expr_arit : term ( ( MINUS | PLUS ) term )* ;
	[GrammarRule("expr_arit")]
	private TigerGrammarParser.expr_arit_return expr_arit()
	{
		Enter_expr_arit();
		EnterRule("expr_arit", 6);
		TraceIn("expr_arit", 6);
		TigerGrammarParser.expr_arit_return retval = new TigerGrammarParser.expr_arit_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MINUS23=null;
		IToken PLUS24=null;
		TigerGrammarParser.term_return term22 = default(TigerGrammarParser.term_return);
		TigerGrammarParser.term_return term25 = default(TigerGrammarParser.term_return);

		object MINUS23_tree=null;
		object PLUS24_tree=null;

		try { DebugEnterRule(GrammarFileName, "expr_arit");
		DebugLocation(121, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:122:2: ( term ( ( MINUS | PLUS ) term )* )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:123:3: term ( ( MINUS | PLUS ) term )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(123, 3);
			PushFollow(Follow._term_in_expr_arit732);
			term22=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term22.Tree);
			DebugLocation(123, 8);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:123:8: ( ( MINUS | PLUS ) term )*
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, decisionCanBacktrack[7]);
				int LA7_0 = input.LA(1);

				if (((LA7_0>=PLUS && LA7_0<=MINUS)))
				{
					alt7=1;
				}


				} finally { DebugExitDecision(7); }
				switch ( alt7 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:123:9: ( MINUS | PLUS ) term
					{
					DebugLocation(123, 9);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:123:9: ( MINUS | PLUS )
					int alt6=2;
					try { DebugEnterSubRule(6);
					try { DebugEnterDecision(6, decisionCanBacktrack[6]);
					int LA6_0 = input.LA(1);

					if ((LA6_0==MINUS))
					{
						alt6=1;
					}
					else if ((LA6_0==PLUS))
					{
						alt6=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 6, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(6); }
					switch (alt6)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:123:10: MINUS
						{
						DebugLocation(123, 15);
						MINUS23=(IToken)Match(input,MINUS,Follow._MINUS_in_expr_arit736); if (state.failed) return retval;
						if ( state.backtracking == 0 ) {
						MINUS23_tree = (object)adaptor.Create(MINUS23);
						root_0 = (object)adaptor.BecomeRoot(MINUS23_tree, root_0);
						}

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:123:19: PLUS
						{
						DebugLocation(123, 23);
						PLUS24=(IToken)Match(input,PLUS,Follow._PLUS_in_expr_arit741); if (state.failed) return retval;
						if ( state.backtracking == 0 ) {
						PLUS24_tree = (object)adaptor.Create(PLUS24);
						root_0 = (object)adaptor.BecomeRoot(PLUS24_tree, root_0);
						}

						}
						break;

					}
					} finally { DebugExitSubRule(6); }

					DebugLocation(123, 26);
					PushFollow(Follow._term_in_expr_arit745);
					term25=term();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term25.Tree);

					}
					break;

				default:
					goto loop7;
				}
			}

			loop7:
				;

			} finally { DebugExitSubRule(7); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr_arit", 6);
			LeaveRule("expr_arit", 6);
			Leave_expr_arit();
		}
		DebugLocation(124, 1);
		} finally { DebugExitRule(GrammarFileName, "expr_arit"); }
		return retval;

	}
	// $ANTLR end "expr_arit"

	public class term_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_term();
	partial void Leave_term();

	// $ANTLR start "term"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:126:1: term : factor ( ( MULT | DIV ) factor )* ;
	[GrammarRule("term")]
	private TigerGrammarParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 7);
		TraceIn("term", 7);
		TigerGrammarParser.term_return retval = new TigerGrammarParser.term_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MULT27=null;
		IToken DIV28=null;
		TigerGrammarParser.factor_return factor26 = default(TigerGrammarParser.factor_return);
		TigerGrammarParser.factor_return factor29 = default(TigerGrammarParser.factor_return);

		object MULT27_tree=null;
		object DIV28_tree=null;

		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(126, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:127:2: ( factor ( ( MULT | DIV ) factor )* )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:128:3: factor ( ( MULT | DIV ) factor )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(128, 3);
			PushFollow(Follow._factor_in_term762);
			factor26=factor();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, factor26.Tree);
			DebugLocation(128, 10);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:128:10: ( ( MULT | DIV ) factor )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_0 = input.LA(1);

				if (((LA9_0>=MULT && LA9_0<=DIV)))
				{
					alt9=1;
				}


				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:128:11: ( MULT | DIV ) factor
					{
					DebugLocation(128, 11);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:128:11: ( MULT | DIV )
					int alt8=2;
					try { DebugEnterSubRule(8);
					try { DebugEnterDecision(8, decisionCanBacktrack[8]);
					int LA8_0 = input.LA(1);

					if ((LA8_0==MULT))
					{
						alt8=1;
					}
					else if ((LA8_0==DIV))
					{
						alt8=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 8, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(8); }
					switch (alt8)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:128:12: MULT
						{
						DebugLocation(128, 16);
						MULT27=(IToken)Match(input,MULT,Follow._MULT_in_term766); if (state.failed) return retval;
						if ( state.backtracking == 0 ) {
						MULT27_tree = (object)adaptor.Create(MULT27);
						root_0 = (object)adaptor.BecomeRoot(MULT27_tree, root_0);
						}

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:128:20: DIV
						{
						DebugLocation(128, 23);
						DIV28=(IToken)Match(input,DIV,Follow._DIV_in_term771); if (state.failed) return retval;
						if ( state.backtracking == 0 ) {
						DIV28_tree = (object)adaptor.Create(DIV28);
						root_0 = (object)adaptor.BecomeRoot(DIV28_tree, root_0);
						}

						}
						break;

					}
					} finally { DebugExitSubRule(8); }

					DebugLocation(128, 26);
					PushFollow(Follow._factor_in_term775);
					factor29=factor();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, factor29.Tree);

					}
					break;

				default:
					goto loop9;
				}
			}

			loop9:
				;

			} finally { DebugExitSubRule(9); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 7);
			LeaveRule("term", 7);
			Leave_term();
		}
		DebugLocation(129, 1);
		} finally { DebugExitRule(GrammarFileName, "term"); }
		return retval;

	}
	// $ANTLR end "term"

	public class factor_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_factor();
	partial void Leave_factor();

	// $ANTLR start "factor"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:131:1: factor : ( MINUS f= unsigned_factor -> ^( MINUS_UNARY $f) | unsigned_factor );
	[GrammarRule("factor")]
	private TigerGrammarParser.factor_return factor()
	{
		Enter_factor();
		EnterRule("factor", 8);
		TraceIn("factor", 8);
		TigerGrammarParser.factor_return retval = new TigerGrammarParser.factor_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MINUS30=null;
		TigerGrammarParser.unsigned_factor_return f = default(TigerGrammarParser.unsigned_factor_return);
		TigerGrammarParser.unsigned_factor_return unsigned_factor31 = default(TigerGrammarParser.unsigned_factor_return);

		object MINUS30_tree=null;
		RewriteRuleITokenStream stream_MINUS=new RewriteRuleITokenStream(adaptor,"token MINUS");
		RewriteRuleSubtreeStream stream_unsigned_factor=new RewriteRuleSubtreeStream(adaptor,"rule unsigned_factor");
		try { DebugEnterRule(GrammarFileName, "factor");
		DebugLocation(131, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:132:2: ( MINUS f= unsigned_factor -> ^( MINUS_UNARY $f) | unsigned_factor )
			int alt10=2;
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			int LA10_0 = input.LA(1);

			if ((LA10_0==MINUS))
			{
				alt10=1;
			}
			else if ((LA10_0==NIL||LA10_0==L_PARENT||(LA10_0>=INT && LA10_0<=ID)))
			{
				alt10=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 10, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(10); }
			switch (alt10)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:133:4: MINUS f= unsigned_factor
				{
				DebugLocation(133, 4);
				MINUS30=(IToken)Match(input,MINUS,Follow._MINUS_in_factor792); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MINUS.Add(MINUS30);

				DebugLocation(133, 12);
				PushFollow(Follow._unsigned_factor_in_factor798);
				f=unsigned_factor();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_unsigned_factor.Add(f.Tree);


				{
				// AST REWRITE
				// elements: f
				// token labels: 
				// rule labels: f, retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_f=new RewriteRuleSubtreeStream(adaptor,"rule f",f!=null?f.Tree:null);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 133:30: -> ^( MINUS_UNARY $f)
				{
					DebugLocation(133, 33);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:133:33: ^( MINUS_UNARY $f)
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(133, 35);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MINUS_UNARY, "MINUS_UNARY"), root_1);

					DebugLocation(133, 47);
					adaptor.AddChild(root_1, stream_f.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:134:11: unsigned_factor
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(134, 11);
				PushFollow(Follow._unsigned_factor_in_factor819);
				unsigned_factor31=unsigned_factor();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unsigned_factor31.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("factor", 8);
			LeaveRule("factor", 8);
			Leave_factor();
		}
		DebugLocation(135, 1);
		} finally { DebugExitRule(GrammarFileName, "factor"); }
		return retval;

	}
	// $ANTLR end "factor"

	public class unsigned_factor_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_unsigned_factor();
	partial void Leave_unsigned_factor();

	// $ANTLR start "unsigned_factor"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:137:1: unsigned_factor : ( constant | lvalue );
	[GrammarRule("unsigned_factor")]
	private TigerGrammarParser.unsigned_factor_return unsigned_factor()
	{
		Enter_unsigned_factor();
		EnterRule("unsigned_factor", 9);
		TraceIn("unsigned_factor", 9);
		TigerGrammarParser.unsigned_factor_return retval = new TigerGrammarParser.unsigned_factor_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		TigerGrammarParser.constant_return constant32 = default(TigerGrammarParser.constant_return);
		TigerGrammarParser.lvalue_return lvalue33 = default(TigerGrammarParser.lvalue_return);


		try { DebugEnterRule(GrammarFileName, "unsigned_factor");
		DebugLocation(137, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:138:2: ( constant | lvalue )
			int alt11=2;
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if ((LA11_0==NIL||(LA11_0>=INT && LA11_0<=STRING)))
			{
				alt11=1;
			}
			else if ((LA11_0==L_PARENT||LA11_0==ID))
			{
				alt11=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 11, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(11); }
			switch (alt11)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:139:3: constant
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(139, 3);
				PushFollow(Follow._constant_in_unsigned_factor834);
				constant32=constant();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constant32.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:140:10: lvalue
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(140, 10);
				PushFollow(Follow._lvalue_in_unsigned_factor845);
				lvalue33=lvalue();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lvalue33.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("unsigned_factor", 9);
			LeaveRule("unsigned_factor", 9);
			Leave_unsigned_factor();
		}
		DebugLocation(141, 1);
		} finally { DebugExitRule(GrammarFileName, "unsigned_factor"); }
		return retval;

	}
	// $ANTLR end "unsigned_factor"

	public class constant_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_constant();
	partial void Leave_constant();

	// $ANTLR start "constant"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:143:1: constant : ( NIL | INT | STRING );
	[GrammarRule("constant")]
	private TigerGrammarParser.constant_return constant()
	{
		Enter_constant();
		EnterRule("constant", 10);
		TraceIn("constant", 10);
		TigerGrammarParser.constant_return retval = new TigerGrammarParser.constant_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken NIL34=null;
		IToken INT35=null;
		IToken STRING36=null;

		object NIL34_tree=null;
		object INT35_tree=null;
		object STRING36_tree=null;

		try { DebugEnterRule(GrammarFileName, "constant");
		DebugLocation(143, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:144:2: ( NIL | INT | STRING )
			int alt12=3;
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			switch (input.LA(1))
			{
			case NIL:
				{
				alt12=1;
				}
				break;
			case INT:
				{
				alt12=2;
				}
				break;
			case STRING:
				{
				alt12=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 12, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(12); }
			switch (alt12)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:145:3: NIL
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(145, 6);
				NIL34=(IToken)Match(input,NIL,Follow._NIL_in_constant858); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				NIL34_tree = (object)adaptor.Create(NIL34);
				root_0 = (object)adaptor.BecomeRoot(NIL34_tree, root_0);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:146:10: INT
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(146, 13);
				INT35=(IToken)Match(input,INT,Follow._INT_in_constant870); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				INT35_tree = (object)adaptor.Create(INT35);
				root_0 = (object)adaptor.BecomeRoot(INT35_tree, root_0);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:147:10: STRING
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(147, 16);
				STRING36=(IToken)Match(input,STRING,Follow._STRING_in_constant882); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				STRING36_tree = (object)adaptor.Create(STRING36);
				root_0 = (object)adaptor.BecomeRoot(STRING36_tree, root_0);
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("constant", 10);
			LeaveRule("constant", 10);
			Leave_constant();
		}
		DebugLocation(148, 1);
		} finally { DebugExitRule(GrammarFileName, "constant"); }
		return retval;

	}
	// $ANTLR end "constant"

	public class minus_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_minus_expr();
	partial void Leave_minus_expr();

	// $ANTLR start "minus_expr"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:150:1: minus_expr : MINUS e= expr -> ^( MINUS_UNARY $e) ;
	[GrammarRule("minus_expr")]
	private TigerGrammarParser.minus_expr_return minus_expr()
	{
		Enter_minus_expr();
		EnterRule("minus_expr", 11);
		TraceIn("minus_expr", 11);
		TigerGrammarParser.minus_expr_return retval = new TigerGrammarParser.minus_expr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MINUS37=null;
		TigerGrammarParser.expr_return e = default(TigerGrammarParser.expr_return);

		object MINUS37_tree=null;
		RewriteRuleITokenStream stream_MINUS=new RewriteRuleITokenStream(adaptor,"token MINUS");
		RewriteRuleSubtreeStream stream_expr=new RewriteRuleSubtreeStream(adaptor,"rule expr");
		try { DebugEnterRule(GrammarFileName, "minus_expr");
		DebugLocation(150, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:151:2: ( MINUS e= expr -> ^( MINUS_UNARY $e) )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:152:3: MINUS e= expr
			{
			DebugLocation(152, 3);
			MINUS37=(IToken)Match(input,MINUS,Follow._MINUS_in_minus_expr899); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_MINUS.Add(MINUS37);

			DebugLocation(152, 11);
			PushFollow(Follow._expr_in_minus_expr905);
			e=expr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expr.Add(e.Tree);


			{
			// AST REWRITE
			// elements: e
			// token labels: 
			// rule labels: retval, e
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_e=new RewriteRuleSubtreeStream(adaptor,"rule e",e!=null?e.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 152:18: -> ^( MINUS_UNARY $e)
			{
				DebugLocation(152, 21);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:152:21: ^( MINUS_UNARY $e)
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(152, 23);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MINUS_UNARY, "MINUS_UNARY"), root_1);

				DebugLocation(152, 35);
				adaptor.AddChild(root_1, stream_e.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("minus_expr", 11);
			LeaveRule("minus_expr", 11);
			Leave_minus_expr();
		}
		DebugLocation(153, 1);
		} finally { DebugExitRule(GrammarFileName, "minus_expr"); }
		return retval;

	}
	// $ANTLR end "minus_expr"

	public class control_instr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_control_instr();
	partial void Leave_control_instr();

	// $ANTLR start "control_instr"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:155:1: control_instr : ( WHILE expr DO expr | FOR ID ASSIGN expr TO expr DO expr | ( IF expr THEN expr ELSE )=> IF e1= expr THEN e2= expr ELSE e3= expr -> ^( IF_THEN_ELSE $e1 $e2 $e3) | IF e1= expr THEN e2= expr -> ^( IF_THEN $e1 $e2) | BREAK );
	[GrammarRule("control_instr")]
	private TigerGrammarParser.control_instr_return control_instr()
	{
		Enter_control_instr();
		EnterRule("control_instr", 12);
		TraceIn("control_instr", 12);
		TigerGrammarParser.control_instr_return retval = new TigerGrammarParser.control_instr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken WHILE38=null;
		IToken DO40=null;
		IToken FOR42=null;
		IToken ID43=null;
		IToken ASSIGN44=null;
		IToken TO46=null;
		IToken DO48=null;
		IToken IF50=null;
		IToken THEN51=null;
		IToken ELSE52=null;
		IToken IF53=null;
		IToken THEN54=null;
		IToken BREAK55=null;
		TigerGrammarParser.expr_return e1 = default(TigerGrammarParser.expr_return);
		TigerGrammarParser.expr_return e2 = default(TigerGrammarParser.expr_return);
		TigerGrammarParser.expr_return e3 = default(TigerGrammarParser.expr_return);
		TigerGrammarParser.expr_return expr39 = default(TigerGrammarParser.expr_return);
		TigerGrammarParser.expr_return expr41 = default(TigerGrammarParser.expr_return);
		TigerGrammarParser.expr_return expr45 = default(TigerGrammarParser.expr_return);
		TigerGrammarParser.expr_return expr47 = default(TigerGrammarParser.expr_return);
		TigerGrammarParser.expr_return expr49 = default(TigerGrammarParser.expr_return);

		object WHILE38_tree=null;
		object DO40_tree=null;
		object FOR42_tree=null;
		object ID43_tree=null;
		object ASSIGN44_tree=null;
		object TO46_tree=null;
		object DO48_tree=null;
		object IF50_tree=null;
		object THEN51_tree=null;
		object ELSE52_tree=null;
		object IF53_tree=null;
		object THEN54_tree=null;
		object BREAK55_tree=null;
		RewriteRuleITokenStream stream_THEN=new RewriteRuleITokenStream(adaptor,"token THEN");
		RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
		RewriteRuleITokenStream stream_ELSE=new RewriteRuleITokenStream(adaptor,"token ELSE");
		RewriteRuleSubtreeStream stream_expr=new RewriteRuleSubtreeStream(adaptor,"rule expr");
		try { DebugEnterRule(GrammarFileName, "control_instr");
		DebugLocation(155, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:156:2: ( WHILE expr DO expr | FOR ID ASSIGN expr TO expr DO expr | ( IF expr THEN expr ELSE )=> IF e1= expr THEN e2= expr ELSE e3= expr -> ^( IF_THEN_ELSE $e1 $e2 $e3) | IF e1= expr THEN e2= expr -> ^( IF_THEN $e1 $e2) | BREAK )
			int alt13=5;
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			switch (input.LA(1))
			{
			case WHILE:
				{
				alt13=1;
				}
				break;
			case FOR:
				{
				alt13=2;
				}
				break;
			case IF:
				{
				int LA13_3 = input.LA(2);

				if ((EvaluatePredicate(synpred5_TigerGrammar_fragment)))
				{
					alt13=3;
				}
				else if ((true))
				{
					alt13=4;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 13, 3, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case BREAK:
				{
				alt13=5;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 13, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(13); }
			switch (alt13)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:157:3: WHILE expr DO expr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(157, 8);
				WHILE38=(IToken)Match(input,WHILE,Follow._WHILE_in_control_instr928); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				WHILE38_tree = (object)adaptor.Create(WHILE38);
				root_0 = (object)adaptor.BecomeRoot(WHILE38_tree, root_0);
				}
				DebugLocation(157, 10);
				PushFollow(Follow._expr_in_control_instr931);
				expr39=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr39.Tree);
				DebugLocation(157, 17);
				DO40=(IToken)Match(input,DO,Follow._DO_in_control_instr933); if (state.failed) return retval;
				DebugLocation(157, 19);
				PushFollow(Follow._expr_in_control_instr936);
				expr41=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr41.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:158:10: FOR ID ASSIGN expr TO expr DO expr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(158, 13);
				FOR42=(IToken)Match(input,FOR,Follow._FOR_in_control_instr948); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				FOR42_tree = (object)adaptor.Create(FOR42);
				root_0 = (object)adaptor.BecomeRoot(FOR42_tree, root_0);
				}
				DebugLocation(158, 15);
				ID43=(IToken)Match(input,ID,Follow._ID_in_control_instr951); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ID43_tree = (object)adaptor.Create(ID43);
				adaptor.AddChild(root_0, ID43_tree);
				}
				DebugLocation(158, 24);
				ASSIGN44=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_control_instr953); if (state.failed) return retval;
				DebugLocation(158, 26);
				PushFollow(Follow._expr_in_control_instr956);
				expr45=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr45.Tree);
				DebugLocation(158, 33);
				TO46=(IToken)Match(input,TO,Follow._TO_in_control_instr958); if (state.failed) return retval;
				DebugLocation(158, 35);
				PushFollow(Follow._expr_in_control_instr961);
				expr47=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr47.Tree);
				DebugLocation(158, 42);
				DO48=(IToken)Match(input,DO,Follow._DO_in_control_instr963); if (state.failed) return retval;
				DebugLocation(158, 44);
				PushFollow(Follow._expr_in_control_instr966);
				expr49=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr49.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:159:9: ( IF expr THEN expr ELSE )=> IF e1= expr THEN e2= expr ELSE e3= expr
				{
				DebugLocation(159, 37);
				IF50=(IToken)Match(input,IF,Follow._IF_in_control_instr990); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IF.Add(IF50);

				DebugLocation(159, 43);
				PushFollow(Follow._expr_in_control_instr996);
				e1=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr.Add(e1.Tree);
				DebugLocation(159, 50);
				THEN51=(IToken)Match(input,THEN,Follow._THEN_in_control_instr998); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_THEN.Add(THEN51);

				DebugLocation(159, 58);
				PushFollow(Follow._expr_in_control_instr1004);
				e2=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr.Add(e2.Tree);
				DebugLocation(159, 65);
				ELSE52=(IToken)Match(input,ELSE,Follow._ELSE_in_control_instr1006); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ELSE.Add(ELSE52);

				DebugLocation(159, 73);
				PushFollow(Follow._expr_in_control_instr1012);
				e3=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr.Add(e3.Tree);


				{
				// AST REWRITE
				// elements: e2, e1, e3
				// token labels: 
				// rule labels: e3, retval, e1, e2
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_e3=new RewriteRuleSubtreeStream(adaptor,"rule e3",e3!=null?e3.Tree:null);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_e1=new RewriteRuleSubtreeStream(adaptor,"rule e1",e1!=null?e1.Tree:null);
				RewriteRuleSubtreeStream stream_e2=new RewriteRuleSubtreeStream(adaptor,"rule e2",e2!=null?e2.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 159:80: -> ^( IF_THEN_ELSE $e1 $e2 $e3)
				{
					DebugLocation(159, 83);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:159:83: ^( IF_THEN_ELSE $e1 $e2 $e3)
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(159, 85);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IF_THEN_ELSE, "IF_THEN_ELSE"), root_1);

					DebugLocation(159, 98);
					adaptor.AddChild(root_1, stream_e1.NextTree());
					DebugLocation(159, 102);
					adaptor.AddChild(root_1, stream_e2.NextTree());
					DebugLocation(159, 106);
					adaptor.AddChild(root_1, stream_e3.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:160:10: IF e1= expr THEN e2= expr
				{
				DebugLocation(160, 10);
				IF53=(IToken)Match(input,IF,Follow._IF_in_control_instr1038); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IF.Add(IF53);

				DebugLocation(160, 16);
				PushFollow(Follow._expr_in_control_instr1044);
				e1=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr.Add(e1.Tree);
				DebugLocation(160, 23);
				THEN54=(IToken)Match(input,THEN,Follow._THEN_in_control_instr1046); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_THEN.Add(THEN54);

				DebugLocation(160, 31);
				PushFollow(Follow._expr_in_control_instr1052);
				e2=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr.Add(e2.Tree);


				{
				// AST REWRITE
				// elements: e1, e2
				// token labels: 
				// rule labels: retval, e1, e2
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_e1=new RewriteRuleSubtreeStream(adaptor,"rule e1",e1!=null?e1.Tree:null);
				RewriteRuleSubtreeStream stream_e2=new RewriteRuleSubtreeStream(adaptor,"rule e2",e2!=null?e2.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 160:38: -> ^( IF_THEN $e1 $e2)
				{
					DebugLocation(160, 41);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:160:41: ^( IF_THEN $e1 $e2)
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(160, 43);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IF_THEN, "IF_THEN"), root_1);

					DebugLocation(160, 51);
					adaptor.AddChild(root_1, stream_e1.NextTree());
					DebugLocation(160, 55);
					adaptor.AddChild(root_1, stream_e2.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:161:10: BREAK
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(161, 15);
				BREAK55=(IToken)Match(input,BREAK,Follow._BREAK_in_control_instr1077); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				BREAK55_tree = (object)adaptor.Create(BREAK55);
				root_0 = (object)adaptor.BecomeRoot(BREAK55_tree, root_0);
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("control_instr", 12);
			LeaveRule("control_instr", 12);
			Leave_control_instr();
		}
		DebugLocation(162, 1);
		} finally { DebugExitRule(GrammarFileName, "control_instr"); }
		return retval;

	}
	// $ANTLR end "control_instr"

	public class let_in_end_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_let_in_end();
	partial void Leave_let_in_end();

	// $ANTLR start "let_in_end"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:164:1: let_in_end : LET (d= declarationList ) IN (e_seq1= expr_seq )? END -> ^( LET ^( DECLARATION_LIST $d) ^( EXPR_SEQ ( $e_seq1)? ) ) ;
	[GrammarRule("let_in_end")]
	private TigerGrammarParser.let_in_end_return let_in_end()
	{
		Enter_let_in_end();
		EnterRule("let_in_end", 13);
		TraceIn("let_in_end", 13);
		TigerGrammarParser.let_in_end_return retval = new TigerGrammarParser.let_in_end_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken LET56=null;
		IToken IN57=null;
		IToken END58=null;
		TigerGrammarParser.declarationList_return d = default(TigerGrammarParser.declarationList_return);
		TigerGrammarParser.expr_seq_return e_seq1 = default(TigerGrammarParser.expr_seq_return);

		object LET56_tree=null;
		object IN57_tree=null;
		object END58_tree=null;
		RewriteRuleITokenStream stream_IN=new RewriteRuleITokenStream(adaptor,"token IN");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_LET=new RewriteRuleITokenStream(adaptor,"token LET");
		RewriteRuleSubtreeStream stream_declarationList=new RewriteRuleSubtreeStream(adaptor,"rule declarationList");
		RewriteRuleSubtreeStream stream_expr_seq=new RewriteRuleSubtreeStream(adaptor,"rule expr_seq");
		try { DebugEnterRule(GrammarFileName, "let_in_end");
		DebugLocation(164, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:165:2: ( LET (d= declarationList ) IN (e_seq1= expr_seq )? END -> ^( LET ^( DECLARATION_LIST $d) ^( EXPR_SEQ ( $e_seq1)? ) ) )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:166:3: LET (d= declarationList ) IN (e_seq1= expr_seq )? END
			{
			DebugLocation(166, 3);
			LET56=(IToken)Match(input,LET,Follow._LET_in_let_in_end1093); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_LET.Add(LET56);

			DebugLocation(166, 7);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:166:7: (d= declarationList )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:166:8: d= declarationList
			{
			DebugLocation(166, 10);
			PushFollow(Follow._declarationList_in_let_in_end1100);
			d=declarationList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declarationList.Add(d.Tree);

			}

			DebugLocation(166, 29);
			IN57=(IToken)Match(input,IN,Follow._IN_in_let_in_end1103); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IN.Add(IN57);

			DebugLocation(166, 32);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:166:32: (e_seq1= expr_seq )?
			int alt14=2;
			try { DebugEnterSubRule(14);
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			try
			{
				alt14 = dfa14.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:166:33: e_seq1= expr_seq
				{
				DebugLocation(166, 40);
				PushFollow(Follow._expr_seq_in_let_in_end1110);
				e_seq1=expr_seq();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr_seq.Add(e_seq1.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(14); }

			DebugLocation(166, 53);
			END58=(IToken)Match(input,END,Follow._END_in_let_in_end1114); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END58);



			{
			// AST REWRITE
			// elements: e_seq1, d, LET
			// token labels: 
			// rule labels: retval, d, e_seq1
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_d=new RewriteRuleSubtreeStream(adaptor,"rule d",d!=null?d.Tree:null);
			RewriteRuleSubtreeStream stream_e_seq1=new RewriteRuleSubtreeStream(adaptor,"rule e_seq1",e_seq1!=null?e_seq1.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 166:57: -> ^( LET ^( DECLARATION_LIST $d) ^( EXPR_SEQ ( $e_seq1)? ) )
			{
				DebugLocation(166, 59);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:166:59: ^( LET ^( DECLARATION_LIST $d) ^( EXPR_SEQ ( $e_seq1)? ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(166, 61);
				root_1 = (object)adaptor.BecomeRoot(stream_LET.NextNode(), root_1);

				DebugLocation(166, 65);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:166:65: ^( DECLARATION_LIST $d)
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(166, 67);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(DECLARATION_LIST, "DECLARATION_LIST"), root_2);

				DebugLocation(166, 84);
				adaptor.AddChild(root_2, stream_d.NextTree());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(166, 88);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:166:88: ^( EXPR_SEQ ( $e_seq1)? )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(166, 90);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(EXPR_SEQ, "EXPR_SEQ"), root_2);

				DebugLocation(166, 99);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:166:99: ( $e_seq1)?
				if ( stream_e_seq1.HasNext )
				{
					DebugLocation(166, 99);
					adaptor.AddChild(root_2, stream_e_seq1.NextTree());

				}
				stream_e_seq1.Reset();

				adaptor.AddChild(root_1, root_2);
				}

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("let_in_end", 13);
			LeaveRule("let_in_end", 13);
			Leave_let_in_end();
		}
		DebugLocation(167, 1);
		} finally { DebugExitRule(GrammarFileName, "let_in_end"); }
		return retval;

	}
	// $ANTLR end "let_in_end"

	public class array_creation_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_array_creation();
	partial void Leave_array_creation();

	// $ANTLR start "array_creation"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:169:1: array_creation : id1= ID L_BRACKET e1= expr R_BRACKET OF e2= expr -> ^( ARRAY_CREATION $id1 $e1 $e2) ;
	[GrammarRule("array_creation")]
	private TigerGrammarParser.array_creation_return array_creation()
	{
		Enter_array_creation();
		EnterRule("array_creation", 14);
		TraceIn("array_creation", 14);
		TigerGrammarParser.array_creation_return retval = new TigerGrammarParser.array_creation_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken id1=null;
		IToken L_BRACKET59=null;
		IToken R_BRACKET60=null;
		IToken OF61=null;
		TigerGrammarParser.expr_return e1 = default(TigerGrammarParser.expr_return);
		TigerGrammarParser.expr_return e2 = default(TigerGrammarParser.expr_return);

		object id1_tree=null;
		object L_BRACKET59_tree=null;
		object R_BRACKET60_tree=null;
		object OF61_tree=null;
		RewriteRuleITokenStream stream_L_BRACKET=new RewriteRuleITokenStream(adaptor,"token L_BRACKET");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_OF=new RewriteRuleITokenStream(adaptor,"token OF");
		RewriteRuleITokenStream stream_R_BRACKET=new RewriteRuleITokenStream(adaptor,"token R_BRACKET");
		RewriteRuleSubtreeStream stream_expr=new RewriteRuleSubtreeStream(adaptor,"rule expr");
		try { DebugEnterRule(GrammarFileName, "array_creation");
		DebugLocation(169, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:170:2: (id1= ID L_BRACKET e1= expr R_BRACKET OF e2= expr -> ^( ARRAY_CREATION $id1 $e1 $e2) )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:171:3: id1= ID L_BRACKET e1= expr R_BRACKET OF e2= expr
			{
			DebugLocation(171, 7);
			id1=(IToken)Match(input,ID,Follow._ID_in_array_creation1153); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(id1);

			DebugLocation(171, 12);
			L_BRACKET59=(IToken)Match(input,L_BRACKET,Follow._L_BRACKET_in_array_creation1155); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_L_BRACKET.Add(L_BRACKET59);

			DebugLocation(171, 25);
			PushFollow(Follow._expr_in_array_creation1161);
			e1=expr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expr.Add(e1.Tree);
			DebugLocation(171, 32);
			R_BRACKET60=(IToken)Match(input,R_BRACKET,Follow._R_BRACKET_in_array_creation1163); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_R_BRACKET.Add(R_BRACKET60);

			DebugLocation(171, 42);
			OF61=(IToken)Match(input,OF,Follow._OF_in_array_creation1165); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OF.Add(OF61);

			DebugLocation(171, 48);
			PushFollow(Follow._expr_in_array_creation1171);
			e2=expr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expr.Add(e2.Tree);


			{
			// AST REWRITE
			// elements: id1, e2, e1
			// token labels: id1
			// rule labels: retval, e1, e2
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleITokenStream stream_id1=new RewriteRuleITokenStream(adaptor,"token id1",id1);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_e1=new RewriteRuleSubtreeStream(adaptor,"rule e1",e1!=null?e1.Tree:null);
			RewriteRuleSubtreeStream stream_e2=new RewriteRuleSubtreeStream(adaptor,"rule e2",e2!=null?e2.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 171:55: -> ^( ARRAY_CREATION $id1 $e1 $e2)
			{
				DebugLocation(171, 58);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:171:58: ^( ARRAY_CREATION $id1 $e1 $e2)
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(171, 60);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAY_CREATION, "ARRAY_CREATION"), root_1);

				DebugLocation(171, 75);
				adaptor.AddChild(root_1, stream_id1.NextNode());
				DebugLocation(171, 80);
				adaptor.AddChild(root_1, stream_e1.NextTree());
				DebugLocation(171, 84);
				adaptor.AddChild(root_1, stream_e2.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("array_creation", 14);
			LeaveRule("array_creation", 14);
			Leave_array_creation();
		}
		DebugLocation(172, 1);
		} finally { DebugExitRule(GrammarFileName, "array_creation"); }
		return retval;

	}
	// $ANTLR end "array_creation"

	public class assign_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_assign_expr();
	partial void Leave_assign_expr();

	// $ANTLR start "assign_expr"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:174:1: assign_expr : l= lvalue ASSIGN e= expr -> ^( ASSIGN $l $e) ;
	[GrammarRule("assign_expr")]
	private TigerGrammarParser.assign_expr_return assign_expr()
	{
		Enter_assign_expr();
		EnterRule("assign_expr", 15);
		TraceIn("assign_expr", 15);
		TigerGrammarParser.assign_expr_return retval = new TigerGrammarParser.assign_expr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ASSIGN62=null;
		TigerGrammarParser.lvalue_return l = default(TigerGrammarParser.lvalue_return);
		TigerGrammarParser.expr_return e = default(TigerGrammarParser.expr_return);

		object ASSIGN62_tree=null;
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_lvalue=new RewriteRuleSubtreeStream(adaptor,"rule lvalue");
		RewriteRuleSubtreeStream stream_expr=new RewriteRuleSubtreeStream(adaptor,"rule expr");
		try { DebugEnterRule(GrammarFileName, "assign_expr");
		DebugLocation(174, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:175:2: (l= lvalue ASSIGN e= expr -> ^( ASSIGN $l $e) )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:176:3: l= lvalue ASSIGN e= expr
			{
			DebugLocation(176, 5);
			PushFollow(Follow._lvalue_in_assign_expr1204);
			l=lvalue();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_lvalue.Add(l.Tree);
			DebugLocation(176, 14);
			ASSIGN62=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assign_expr1206); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN62);

			DebugLocation(176, 23);
			PushFollow(Follow._expr_in_assign_expr1212);
			e=expr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expr.Add(e.Tree);


			{
			// AST REWRITE
			// elements: l, e, ASSIGN
			// token labels: 
			// rule labels: retval, e, l
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_e=new RewriteRuleSubtreeStream(adaptor,"rule e",e!=null?e.Tree:null);
			RewriteRuleSubtreeStream stream_l=new RewriteRuleSubtreeStream(adaptor,"rule l",l!=null?l.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 176:30: -> ^( ASSIGN $l $e)
			{
				DebugLocation(176, 33);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:176:33: ^( ASSIGN $l $e)
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(176, 35);
				root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

				DebugLocation(176, 42);
				adaptor.AddChild(root_1, stream_l.NextTree());
				DebugLocation(176, 45);
				adaptor.AddChild(root_1, stream_e.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assign_expr", 15);
			LeaveRule("assign_expr", 15);
			Leave_assign_expr();
		}
		DebugLocation(177, 1);
		} finally { DebugExitRule(GrammarFileName, "assign_expr"); }
		return retval;

	}
	// $ANTLR end "assign_expr"

	public class lvalue_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_lvalue();
	partial void Leave_lvalue();

	// $ANTLR start "lvalue"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:179:1: lvalue : ( ( L_PARENT (e_seq= expr_seq )? R_PARENT -> ^( EXPR_SEQ ( $e_seq)? ) ) | ( ID L_BRACE )=> (t= type_id L_BRACE (f= field_list )? R_BRACE -> ^( RECORD_CREATION $t ( $f)? ) ) | ( ID L_PARENT )=> (id_callable= ID L_PARENT (callable_args= expr_list )? R_PARENT -> ^( CALLABLE_CALL $id_callable ( $callable_args)? ) ) | ( (id= ID ) -> ^( LVALUE_ID $id) ) ) ( DOT id2= ID -> ^( RECORD_ACCESS $lvalue $id2) | L_BRACKET e= expr R_BRACKET -> ^( ARRAY_ACCESS $lvalue $e) )* ;
	[GrammarRule("lvalue")]
	private TigerGrammarParser.lvalue_return lvalue()
	{
		Enter_lvalue();
		EnterRule("lvalue", 16);
		TraceIn("lvalue", 16);
		TigerGrammarParser.lvalue_return retval = new TigerGrammarParser.lvalue_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken id_callable=null;
		IToken id=null;
		IToken id2=null;
		IToken L_PARENT63=null;
		IToken R_PARENT64=null;
		IToken L_BRACE65=null;
		IToken R_BRACE66=null;
		IToken L_PARENT67=null;
		IToken R_PARENT68=null;
		IToken DOT69=null;
		IToken L_BRACKET70=null;
		IToken R_BRACKET71=null;
		TigerGrammarParser.expr_seq_return e_seq = default(TigerGrammarParser.expr_seq_return);
		TigerGrammarParser.type_id_return t = default(TigerGrammarParser.type_id_return);
		TigerGrammarParser.field_list_return f = default(TigerGrammarParser.field_list_return);
		TigerGrammarParser.expr_list_return callable_args = default(TigerGrammarParser.expr_list_return);
		TigerGrammarParser.expr_return e = default(TigerGrammarParser.expr_return);

		object id_callable_tree=null;
		object id_tree=null;
		object id2_tree=null;
		object L_PARENT63_tree=null;
		object R_PARENT64_tree=null;
		object L_BRACE65_tree=null;
		object R_BRACE66_tree=null;
		object L_PARENT67_tree=null;
		object R_PARENT68_tree=null;
		object DOT69_tree=null;
		object L_BRACKET70_tree=null;
		object R_BRACKET71_tree=null;
		RewriteRuleITokenStream stream_L_BRACE=new RewriteRuleITokenStream(adaptor,"token L_BRACE");
		RewriteRuleITokenStream stream_R_PARENT=new RewriteRuleITokenStream(adaptor,"token R_PARENT");
		RewriteRuleITokenStream stream_R_BRACE=new RewriteRuleITokenStream(adaptor,"token R_BRACE");
		RewriteRuleITokenStream stream_L_BRACKET=new RewriteRuleITokenStream(adaptor,"token L_BRACKET");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_DOT=new RewriteRuleITokenStream(adaptor,"token DOT");
		RewriteRuleITokenStream stream_L_PARENT=new RewriteRuleITokenStream(adaptor,"token L_PARENT");
		RewriteRuleITokenStream stream_R_BRACKET=new RewriteRuleITokenStream(adaptor,"token R_BRACKET");
		RewriteRuleSubtreeStream stream_field_list=new RewriteRuleSubtreeStream(adaptor,"rule field_list");
		RewriteRuleSubtreeStream stream_expr=new RewriteRuleSubtreeStream(adaptor,"rule expr");
		RewriteRuleSubtreeStream stream_type_id=new RewriteRuleSubtreeStream(adaptor,"rule type_id");
		RewriteRuleSubtreeStream stream_expr_seq=new RewriteRuleSubtreeStream(adaptor,"rule expr_seq");
		RewriteRuleSubtreeStream stream_expr_list=new RewriteRuleSubtreeStream(adaptor,"rule expr_list");
		try { DebugEnterRule(GrammarFileName, "lvalue");
		DebugLocation(179, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:180:2: ( ( ( L_PARENT (e_seq= expr_seq )? R_PARENT -> ^( EXPR_SEQ ( $e_seq)? ) ) | ( ID L_BRACE )=> (t= type_id L_BRACE (f= field_list )? R_BRACE -> ^( RECORD_CREATION $t ( $f)? ) ) | ( ID L_PARENT )=> (id_callable= ID L_PARENT (callable_args= expr_list )? R_PARENT -> ^( CALLABLE_CALL $id_callable ( $callable_args)? ) ) | ( (id= ID ) -> ^( LVALUE_ID $id) ) ) ( DOT id2= ID -> ^( RECORD_ACCESS $lvalue $id2) | L_BRACKET e= expr R_BRACKET -> ^( ARRAY_ACCESS $lvalue $e) )* )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:181:9: ( ( L_PARENT (e_seq= expr_seq )? R_PARENT -> ^( EXPR_SEQ ( $e_seq)? ) ) | ( ID L_BRACE )=> (t= type_id L_BRACE (f= field_list )? R_BRACE -> ^( RECORD_CREATION $t ( $f)? ) ) | ( ID L_PARENT )=> (id_callable= ID L_PARENT (callable_args= expr_list )? R_PARENT -> ^( CALLABLE_CALL $id_callable ( $callable_args)? ) ) | ( (id= ID ) -> ^( LVALUE_ID $id) ) ) ( DOT id2= ID -> ^( RECORD_ACCESS $lvalue $id2) | L_BRACKET e= expr R_BRACKET -> ^( ARRAY_ACCESS $lvalue $e) )*
			{
			DebugLocation(181, 9);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:181:9: ( ( L_PARENT (e_seq= expr_seq )? R_PARENT -> ^( EXPR_SEQ ( $e_seq)? ) ) | ( ID L_BRACE )=> (t= type_id L_BRACE (f= field_list )? R_BRACE -> ^( RECORD_CREATION $t ( $f)? ) ) | ( ID L_PARENT )=> (id_callable= ID L_PARENT (callable_args= expr_list )? R_PARENT -> ^( CALLABLE_CALL $id_callable ( $callable_args)? ) ) | ( (id= ID ) -> ^( LVALUE_ID $id) ) )
			int alt18=4;
			try { DebugEnterSubRule(18);
			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
			int LA18_0 = input.LA(1);

			if ((LA18_0==L_PARENT))
			{
				alt18=1;
			}
			else if ((LA18_0==ID))
			{
				int LA18_2 = input.LA(2);

				if ((EvaluatePredicate(synpred6_TigerGrammar_fragment)))
				{
					alt18=2;
				}
				else if ((EvaluatePredicate(synpred7_TigerGrammar_fragment)))
				{
					alt18=3;
				}
				else if ((true))
				{
					alt18=4;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 18, 2, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 18, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(18); }
			switch (alt18)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:183:7: ( L_PARENT (e_seq= expr_seq )? R_PARENT -> ^( EXPR_SEQ ( $e_seq)? ) )
				{
				DebugLocation(183, 7);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:183:7: ( L_PARENT (e_seq= expr_seq )? R_PARENT -> ^( EXPR_SEQ ( $e_seq)? ) )
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:183:8: L_PARENT (e_seq= expr_seq )? R_PARENT
				{
				DebugLocation(183, 8);
				L_PARENT63=(IToken)Match(input,L_PARENT,Follow._L_PARENT_in_lvalue1259); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_L_PARENT.Add(L_PARENT63);

				DebugLocation(183, 17);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:183:17: (e_seq= expr_seq )?
				int alt15=2;
				try { DebugEnterSubRule(15);
				try { DebugEnterDecision(15, decisionCanBacktrack[15]);
				try
				{
					alt15 = dfa15.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(15); }
				switch (alt15)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:183:18: e_seq= expr_seq
					{
					DebugLocation(183, 24);
					PushFollow(Follow._expr_seq_in_lvalue1266);
					e_seq=expr_seq();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_expr_seq.Add(e_seq.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(15); }

				DebugLocation(183, 37);
				R_PARENT64=(IToken)Match(input,R_PARENT,Follow._R_PARENT_in_lvalue1270); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_R_PARENT.Add(R_PARENT64);



				{
				// AST REWRITE
				// elements: e_seq
				// token labels: 
				// rule labels: retval, e_seq
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_e_seq=new RewriteRuleSubtreeStream(adaptor,"rule e_seq",e_seq!=null?e_seq.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 183:46: -> ^( EXPR_SEQ ( $e_seq)? )
				{
					DebugLocation(183, 49);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:183:49: ^( EXPR_SEQ ( $e_seq)? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(183, 51);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(EXPR_SEQ, "EXPR_SEQ"), root_1);

					DebugLocation(183, 60);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:183:60: ( $e_seq)?
					if ( stream_e_seq.HasNext )
					{
						DebugLocation(183, 60);
						adaptor.AddChild(root_1, stream_e_seq.NextTree());

					}
					stream_e_seq.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:186:14: ( ID L_BRACE )=> (t= type_id L_BRACE (f= field_list )? R_BRACE -> ^( RECORD_CREATION $t ( $f)? ) )
				{
				DebugLocation(186, 30);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:186:30: (t= type_id L_BRACE (f= field_list )? R_BRACE -> ^( RECORD_CREATION $t ( $f)? ) )
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:186:31: t= type_id L_BRACE (f= field_list )? R_BRACE
				{
				DebugLocation(186, 33);
				PushFollow(Follow._type_id_in_lvalue1327);
				t=type_id();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type_id.Add(t.Tree);
				DebugLocation(186, 43);
				L_BRACE65=(IToken)Match(input,L_BRACE,Follow._L_BRACE_in_lvalue1329); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_L_BRACE.Add(L_BRACE65);

				DebugLocation(186, 51);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:186:51: (f= field_list )?
				int alt16=2;
				try { DebugEnterSubRule(16);
				try { DebugEnterDecision(16, decisionCanBacktrack[16]);
				int LA16_0 = input.LA(1);

				if ((LA16_0==ID))
				{
					alt16=1;
				}
				} finally { DebugExitDecision(16); }
				switch (alt16)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:186:52: f= field_list
					{
					DebugLocation(186, 54);
					PushFollow(Follow._field_list_in_lvalue1336);
					f=field_list();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_field_list.Add(f.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(16); }

				DebugLocation(186, 69);
				R_BRACE66=(IToken)Match(input,R_BRACE,Follow._R_BRACE_in_lvalue1340); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_R_BRACE.Add(R_BRACE66);



				{
				// AST REWRITE
				// elements: t, f
				// token labels: 
				// rule labels: f, retval, t
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_f=new RewriteRuleSubtreeStream(adaptor,"rule f",f!=null?f.Tree:null);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_t=new RewriteRuleSubtreeStream(adaptor,"rule t",t!=null?t.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 186:77: -> ^( RECORD_CREATION $t ( $f)? )
				{
					DebugLocation(186, 80);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:186:80: ^( RECORD_CREATION $t ( $f)? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(186, 82);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RECORD_CREATION, "RECORD_CREATION"), root_1);

					DebugLocation(186, 98);
					adaptor.AddChild(root_1, stream_t.NextTree());
					DebugLocation(186, 101);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:186:101: ( $f)?
					if ( stream_f.HasNext )
					{
						DebugLocation(186, 101);
						adaptor.AddChild(root_1, stream_f.NextTree());

					}
					stream_f.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:189:14: ( ID L_PARENT )=> (id_callable= ID L_PARENT (callable_args= expr_list )? R_PARENT -> ^( CALLABLE_CALL $id_callable ( $callable_args)? ) )
				{
				DebugLocation(189, 31);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:189:31: (id_callable= ID L_PARENT (callable_args= expr_list )? R_PARENT -> ^( CALLABLE_CALL $id_callable ( $callable_args)? ) )
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:189:32: id_callable= ID L_PARENT (callable_args= expr_list )? R_PARENT
				{
				DebugLocation(189, 44);
				id_callable=(IToken)Match(input,ID,Follow._ID_in_lvalue1399); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(id_callable);

				DebugLocation(189, 49);
				L_PARENT67=(IToken)Match(input,L_PARENT,Follow._L_PARENT_in_lvalue1401); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_L_PARENT.Add(L_PARENT67);

				DebugLocation(189, 58);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:189:58: (callable_args= expr_list )?
				int alt17=2;
				try { DebugEnterSubRule(17);
				try { DebugEnterDecision(17, decisionCanBacktrack[17]);
				try
				{
					alt17 = dfa17.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(17); }
				switch (alt17)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:189:59: callable_args= expr_list
					{
					DebugLocation(189, 73);
					PushFollow(Follow._expr_list_in_lvalue1408);
					callable_args=expr_list();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_expr_list.Add(callable_args.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(17); }

				DebugLocation(189, 87);
				R_PARENT68=(IToken)Match(input,R_PARENT,Follow._R_PARENT_in_lvalue1412); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_R_PARENT.Add(R_PARENT68);



				{
				// AST REWRITE
				// elements: callable_args, id_callable
				// token labels: id_callable
				// rule labels: retval, callable_args
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_id_callable=new RewriteRuleITokenStream(adaptor,"token id_callable",id_callable);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_callable_args=new RewriteRuleSubtreeStream(adaptor,"rule callable_args",callable_args!=null?callable_args.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 189:96: -> ^( CALLABLE_CALL $id_callable ( $callable_args)? )
				{
					DebugLocation(189, 99);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:189:99: ^( CALLABLE_CALL $id_callable ( $callable_args)? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(189, 101);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CALLABLE_CALL, "CALLABLE_CALL"), root_1);

					DebugLocation(189, 115);
					adaptor.AddChild(root_1, stream_id_callable.NextNode());
					DebugLocation(189, 128);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:189:128: ( $callable_args)?
					if ( stream_callable_args.HasNext )
					{
						DebugLocation(189, 128);
						adaptor.AddChild(root_1, stream_callable_args.NextTree());

					}
					stream_callable_args.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}


				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:192:14: ( (id= ID ) -> ^( LVALUE_ID $id) )
				{
				DebugLocation(192, 14);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:192:14: ( (id= ID ) -> ^( LVALUE_ID $id) )
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:192:15: (id= ID )
				{
				DebugLocation(192, 15);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:192:15: (id= ID )
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:192:16: id= ID
				{
				DebugLocation(192, 19);
				id=(IToken)Match(input,ID,Follow._ID_in_lvalue1469); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(id);


				}



				{
				// AST REWRITE
				// elements: id
				// token labels: id
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_id=new RewriteRuleITokenStream(adaptor,"token id",id);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 192:25: -> ^( LVALUE_ID $id)
				{
					DebugLocation(192, 28);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:192:28: ^( LVALUE_ID $id)
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(192, 30);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LVALUE_ID, "LVALUE_ID"), root_1);

					DebugLocation(192, 40);
					adaptor.AddChild(root_1, stream_id.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}


				}
				break;

			}
			} finally { DebugExitSubRule(18); }

			DebugLocation(195, 3);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:195:3: ( DOT id2= ID -> ^( RECORD_ACCESS $lvalue $id2) | L_BRACKET e= expr R_BRACKET -> ^( ARRAY_ACCESS $lvalue $e) )*
			try { DebugEnterSubRule(19);
			while (true)
			{
				int alt19=3;
				try { DebugEnterDecision(19, decisionCanBacktrack[19]);
				int LA19_0 = input.LA(1);

				if ((LA19_0==DOT))
				{
					alt19=1;
				}
				else if ((LA19_0==L_BRACKET))
				{
					alt19=2;
				}


				} finally { DebugExitDecision(19); }
				switch ( alt19 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:196:7: DOT id2= ID
					{
					DebugLocation(196, 7);
					DOT69=(IToken)Match(input,DOT,Follow._DOT_in_lvalue1511); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_DOT.Add(DOT69);

					DebugLocation(196, 15);
					id2=(IToken)Match(input,ID,Follow._ID_in_lvalue1517); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_ID.Add(id2);



					{
					// AST REWRITE
					// elements: lvalue, id2
					// token labels: id2
					// rule labels: retval
					// token list labels: 
					// rule list labels: 
					// wildcard labels: 
					if ( state.backtracking == 0 ) {
					retval.Tree = root_0;
					RewriteRuleITokenStream stream_id2=new RewriteRuleITokenStream(adaptor,"token id2",id2);
					RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

					root_0 = (object)adaptor.Nil();
					// 196:20: -> ^( RECORD_ACCESS $lvalue $id2)
					{
						DebugLocation(196, 23);
						// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:196:23: ^( RECORD_ACCESS $lvalue $id2)
						{
						object root_1 = (object)adaptor.Nil();
						DebugLocation(196, 25);
						root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RECORD_ACCESS, "RECORD_ACCESS"), root_1);

						DebugLocation(196, 39);
						adaptor.AddChild(root_1, stream_retval.NextTree());
						DebugLocation(196, 47);
						adaptor.AddChild(root_1, stream_id2.NextNode());

						adaptor.AddChild(root_0, root_1);
						}

					}

					retval.Tree = root_0;
					}
					}

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:197:7: L_BRACKET e= expr R_BRACKET
					{
					DebugLocation(197, 7);
					L_BRACKET70=(IToken)Match(input,L_BRACKET,Follow._L_BRACKET_in_lvalue1537); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_L_BRACKET.Add(L_BRACKET70);

					DebugLocation(197, 19);
					PushFollow(Follow._expr_in_lvalue1543);
					e=expr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_expr.Add(e.Tree);
					DebugLocation(197, 26);
					R_BRACKET71=(IToken)Match(input,R_BRACKET,Follow._R_BRACKET_in_lvalue1545); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_R_BRACKET.Add(R_BRACKET71);



					{
					// AST REWRITE
					// elements: e, lvalue
					// token labels: 
					// rule labels: retval, e
					// token list labels: 
					// rule list labels: 
					// wildcard labels: 
					if ( state.backtracking == 0 ) {
					retval.Tree = root_0;
					RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
					RewriteRuleSubtreeStream stream_e=new RewriteRuleSubtreeStream(adaptor,"rule e",e!=null?e.Tree:null);

					root_0 = (object)adaptor.Nil();
					// 197:36: -> ^( ARRAY_ACCESS $lvalue $e)
					{
						DebugLocation(197, 39);
						// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:197:39: ^( ARRAY_ACCESS $lvalue $e)
						{
						object root_1 = (object)adaptor.Nil();
						DebugLocation(197, 41);
						root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAY_ACCESS, "ARRAY_ACCESS"), root_1);

						DebugLocation(197, 54);
						adaptor.AddChild(root_1, stream_retval.NextTree());
						DebugLocation(197, 62);
						adaptor.AddChild(root_1, stream_e.NextTree());

						adaptor.AddChild(root_0, root_1);
						}

					}

					retval.Tree = root_0;
					}
					}

					}
					break;

				default:
					goto loop19;
				}
			}

			loop19:
				;

			} finally { DebugExitSubRule(19); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("lvalue", 16);
			LeaveRule("lvalue", 16);
			Leave_lvalue();
		}
		DebugLocation(200, 1);
		} finally { DebugExitRule(GrammarFileName, "lvalue"); }
		return retval;

	}
	// $ANTLR end "lvalue"

	public class declarationList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_declarationList();
	partial void Leave_declarationList();

	// $ANTLR start "declarationList"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:202:1: declarationList : ( type_declaration | variable_declaration | callable_declaration )+ ;
	[GrammarRule("declarationList")]
	private TigerGrammarParser.declarationList_return declarationList()
	{
		Enter_declarationList();
		EnterRule("declarationList", 17);
		TraceIn("declarationList", 17);
		TigerGrammarParser.declarationList_return retval = new TigerGrammarParser.declarationList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		TigerGrammarParser.type_declaration_return type_declaration72 = default(TigerGrammarParser.type_declaration_return);
		TigerGrammarParser.variable_declaration_return variable_declaration73 = default(TigerGrammarParser.variable_declaration_return);
		TigerGrammarParser.callable_declaration_return callable_declaration74 = default(TigerGrammarParser.callable_declaration_return);


		try { DebugEnterRule(GrammarFileName, "declarationList");
		DebugLocation(202, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:203:2: ( ( type_declaration | variable_declaration | callable_declaration )+ )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:204:3: ( type_declaration | variable_declaration | callable_declaration )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(204, 3);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:204:3: ( type_declaration | variable_declaration | callable_declaration )+
			int cnt20=0;
			try { DebugEnterSubRule(20);
			while (true)
			{
				int alt20=4;
				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
				switch (input.LA(1))
				{
				case TYPE:
					{
					alt20=1;
					}
					break;
				case VAR:
					{
					alt20=2;
					}
					break;
				case FUNCTION:
					{
					alt20=3;
					}
					break;

				}

				} finally { DebugExitDecision(20); }
				switch (alt20)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:204:5: type_declaration
					{
					DebugLocation(204, 5);
					PushFollow(Follow._type_declaration_in_declarationList1580);
					type_declaration72=type_declaration();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type_declaration72.Tree);

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:204:24: variable_declaration
					{
					DebugLocation(204, 24);
					PushFollow(Follow._variable_declaration_in_declarationList1584);
					variable_declaration73=variable_declaration();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable_declaration73.Tree);

					}
					break;
				case 3:
					DebugEnterAlt(3);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:204:47: callable_declaration
					{
					DebugLocation(204, 47);
					PushFollow(Follow._callable_declaration_in_declarationList1588);
					callable_declaration74=callable_declaration();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, callable_declaration74.Tree);

					}
					break;

				default:
					if (cnt20 >= 1)
						goto loop20;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee20 = new EarlyExitException( 20, input );
					DebugRecognitionException(eee20);
					throw eee20;
				}
				cnt20++;
			}
			loop20:
				;

			} finally { DebugExitSubRule(20); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("declarationList", 17);
			LeaveRule("declarationList", 17);
			Leave_declarationList();
		}
		DebugLocation(205, 1);
		} finally { DebugExitRule(GrammarFileName, "declarationList"); }
		return retval;

	}
	// $ANTLR end "declarationList"

	public class type_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_type_declaration();
	partial void Leave_type_declaration();

	// $ANTLR start "type_declaration"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:207:1: type_declaration : TYPE id1= type_id EQUALS (id2= type_id -> ^( ALIAS_DECLARATION $id1 $id2) | L_BRACE ( type_fields )? R_BRACE -> ^( RECORD_DECLARATION $id1 ( type_fields )? ) | ARRAY OF id3= type_id -> ^( ARRAY_DECLARATION $id1 $id3) ) ;
	[GrammarRule("type_declaration")]
	private TigerGrammarParser.type_declaration_return type_declaration()
	{
		Enter_type_declaration();
		EnterRule("type_declaration", 18);
		TraceIn("type_declaration", 18);
		TigerGrammarParser.type_declaration_return retval = new TigerGrammarParser.type_declaration_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken TYPE75=null;
		IToken EQUALS76=null;
		IToken L_BRACE77=null;
		IToken R_BRACE79=null;
		IToken ARRAY80=null;
		IToken OF81=null;
		TigerGrammarParser.type_id_return id1 = default(TigerGrammarParser.type_id_return);
		TigerGrammarParser.type_id_return id2 = default(TigerGrammarParser.type_id_return);
		TigerGrammarParser.type_id_return id3 = default(TigerGrammarParser.type_id_return);
		TigerGrammarParser.type_fields_return type_fields78 = default(TigerGrammarParser.type_fields_return);

		object TYPE75_tree=null;
		object EQUALS76_tree=null;
		object L_BRACE77_tree=null;
		object R_BRACE79_tree=null;
		object ARRAY80_tree=null;
		object OF81_tree=null;
		RewriteRuleITokenStream stream_L_BRACE=new RewriteRuleITokenStream(adaptor,"token L_BRACE");
		RewriteRuleITokenStream stream_EQUALS=new RewriteRuleITokenStream(adaptor,"token EQUALS");
		RewriteRuleITokenStream stream_R_BRACE=new RewriteRuleITokenStream(adaptor,"token R_BRACE");
		RewriteRuleITokenStream stream_OF=new RewriteRuleITokenStream(adaptor,"token OF");
		RewriteRuleITokenStream stream_ARRAY=new RewriteRuleITokenStream(adaptor,"token ARRAY");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleSubtreeStream stream_type_fields=new RewriteRuleSubtreeStream(adaptor,"rule type_fields");
		RewriteRuleSubtreeStream stream_type_id=new RewriteRuleSubtreeStream(adaptor,"rule type_id");
		try { DebugEnterRule(GrammarFileName, "type_declaration");
		DebugLocation(207, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:208:2: ( TYPE id1= type_id EQUALS (id2= type_id -> ^( ALIAS_DECLARATION $id1 $id2) | L_BRACE ( type_fields )? R_BRACE -> ^( RECORD_DECLARATION $id1 ( type_fields )? ) | ARRAY OF id3= type_id -> ^( ARRAY_DECLARATION $id1 $id3) ) )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:209:3: TYPE id1= type_id EQUALS (id2= type_id -> ^( ALIAS_DECLARATION $id1 $id2) | L_BRACE ( type_fields )? R_BRACE -> ^( RECORD_DECLARATION $id1 ( type_fields )? ) | ARRAY OF id3= type_id -> ^( ARRAY_DECLARATION $id1 $id3) )
			{
			DebugLocation(209, 3);
			TYPE75=(IToken)Match(input,TYPE,Follow._TYPE_in_type_declaration1606); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE75);

			DebugLocation(209, 12);
			PushFollow(Follow._type_id_in_type_declaration1612);
			id1=type_id();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type_id.Add(id1.Tree);
			DebugLocation(209, 22);
			EQUALS76=(IToken)Match(input,EQUALS,Follow._EQUALS_in_type_declaration1614); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_EQUALS.Add(EQUALS76);

			DebugLocation(210, 3);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:210:3: (id2= type_id -> ^( ALIAS_DECLARATION $id1 $id2) | L_BRACE ( type_fields )? R_BRACE -> ^( RECORD_DECLARATION $id1 ( type_fields )? ) | ARRAY OF id3= type_id -> ^( ARRAY_DECLARATION $id1 $id3) )
			int alt22=3;
			try { DebugEnterSubRule(22);
			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
			switch (input.LA(1))
			{
			case ID:
				{
				alt22=1;
				}
				break;
			case L_BRACE:
				{
				alt22=2;
				}
				break;
			case ARRAY:
				{
				alt22=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 22, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(22); }
			switch (alt22)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:212:7: id2= type_id
				{
				DebugLocation(212, 11);
				PushFollow(Follow._type_id_in_type_declaration1636);
				id2=type_id();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type_id.Add(id2.Tree);


				{
				// AST REWRITE
				// elements: id1, id2
				// token labels: 
				// rule labels: retval, id2, id1
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_id2=new RewriteRuleSubtreeStream(adaptor,"rule id2",id2!=null?id2.Tree:null);
				RewriteRuleSubtreeStream stream_id1=new RewriteRuleSubtreeStream(adaptor,"rule id1",id1!=null?id1.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 212:21: -> ^( ALIAS_DECLARATION $id1 $id2)
				{
					DebugLocation(212, 24);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:212:24: ^( ALIAS_DECLARATION $id1 $id2)
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(212, 26);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ALIAS_DECLARATION, "ALIAS_DECLARATION"), root_1);

					DebugLocation(212, 44);
					adaptor.AddChild(root_1, stream_id1.NextTree());
					DebugLocation(212, 49);
					adaptor.AddChild(root_1, stream_id2.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:214:11: L_BRACE ( type_fields )? R_BRACE
				{
				DebugLocation(214, 11);
				L_BRACE77=(IToken)Match(input,L_BRACE,Follow._L_BRACE_in_type_declaration1667); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_L_BRACE.Add(L_BRACE77);

				DebugLocation(214, 19);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:214:19: ( type_fields )?
				int alt21=2;
				try { DebugEnterSubRule(21);
				try { DebugEnterDecision(21, decisionCanBacktrack[21]);
				int LA21_0 = input.LA(1);

				if ((LA21_0==ID))
				{
					alt21=1;
				}
				} finally { DebugExitDecision(21); }
				switch (alt21)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:214:20: type_fields
					{
					DebugLocation(214, 20);
					PushFollow(Follow._type_fields_in_type_declaration1670);
					type_fields78=type_fields();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_type_fields.Add(type_fields78.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(21); }

				DebugLocation(214, 34);
				R_BRACE79=(IToken)Match(input,R_BRACE,Follow._R_BRACE_in_type_declaration1674); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_R_BRACE.Add(R_BRACE79);



				{
				// AST REWRITE
				// elements: id1, type_fields
				// token labels: 
				// rule labels: retval, id1
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_id1=new RewriteRuleSubtreeStream(adaptor,"rule id1",id1!=null?id1.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 214:42: -> ^( RECORD_DECLARATION $id1 ( type_fields )? )
				{
					DebugLocation(214, 45);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:214:45: ^( RECORD_DECLARATION $id1 ( type_fields )? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(214, 47);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RECORD_DECLARATION, "RECORD_DECLARATION"), root_1);

					DebugLocation(214, 66);
					adaptor.AddChild(root_1, stream_id1.NextTree());
					DebugLocation(214, 71);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:214:71: ( type_fields )?
					if ( stream_type_fields.HasNext )
					{
						DebugLocation(214, 71);
						adaptor.AddChild(root_1, stream_type_fields.NextTree());

					}
					stream_type_fields.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:216:11: ARRAY OF id3= type_id
				{
				DebugLocation(216, 11);
				ARRAY80=(IToken)Match(input,ARRAY,Follow._ARRAY_in_type_declaration1709); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY.Add(ARRAY80);

				DebugLocation(216, 17);
				OF81=(IToken)Match(input,OF,Follow._OF_in_type_declaration1711); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OF.Add(OF81);

				DebugLocation(216, 24);
				PushFollow(Follow._type_id_in_type_declaration1717);
				id3=type_id();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type_id.Add(id3.Tree);


				{
				// AST REWRITE
				// elements: id3, id1
				// token labels: 
				// rule labels: retval, id1, id3
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_id1=new RewriteRuleSubtreeStream(adaptor,"rule id1",id1!=null?id1.Tree:null);
				RewriteRuleSubtreeStream stream_id3=new RewriteRuleSubtreeStream(adaptor,"rule id3",id3!=null?id3.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 216:34: -> ^( ARRAY_DECLARATION $id1 $id3)
				{
					DebugLocation(216, 37);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:216:37: ^( ARRAY_DECLARATION $id1 $id3)
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(216, 39);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAY_DECLARATION, "ARRAY_DECLARATION"), root_1);

					DebugLocation(216, 57);
					adaptor.AddChild(root_1, stream_id1.NextTree());
					DebugLocation(216, 62);
					adaptor.AddChild(root_1, stream_id3.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			} finally { DebugExitSubRule(22); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("type_declaration", 18);
			LeaveRule("type_declaration", 18);
			Leave_type_declaration();
		}
		DebugLocation(218, 1);
		} finally { DebugExitRule(GrammarFileName, "type_declaration"); }
		return retval;

	}
	// $ANTLR end "type_declaration"

	public class type_id_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_type_id();
	partial void Leave_type_id();

	// $ANTLR start "type_id"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:220:1: type_id : ID ;
	[GrammarRule("type_id")]
	private TigerGrammarParser.type_id_return type_id()
	{
		Enter_type_id();
		EnterRule("type_id", 19);
		TraceIn("type_id", 19);
		TigerGrammarParser.type_id_return retval = new TigerGrammarParser.type_id_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID82=null;

		object ID82_tree=null;

		try { DebugEnterRule(GrammarFileName, "type_id");
		DebugLocation(220, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:221:2: ( ID )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:222:3: ID
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(222, 3);
			ID82=(IToken)Match(input,ID,Follow._ID_in_type_id1748); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID82_tree = (object)adaptor.Create(ID82);
			adaptor.AddChild(root_0, ID82_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("type_id", 19);
			LeaveRule("type_id", 19);
			Leave_type_id();
		}
		DebugLocation(223, 1);
		} finally { DebugExitRule(GrammarFileName, "type_id"); }
		return retval;

	}
	// $ANTLR end "type_id"

	public class type_fields_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_type_fields();
	partial void Leave_type_fields();

	// $ANTLR start "type_fields"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:225:1: type_fields : type_field ( COMMA type_field )* ;
	[GrammarRule("type_fields")]
	private TigerGrammarParser.type_fields_return type_fields()
	{
		Enter_type_fields();
		EnterRule("type_fields", 20);
		TraceIn("type_fields", 20);
		TigerGrammarParser.type_fields_return retval = new TigerGrammarParser.type_fields_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken COMMA84=null;
		TigerGrammarParser.type_field_return type_field83 = default(TigerGrammarParser.type_field_return);
		TigerGrammarParser.type_field_return type_field85 = default(TigerGrammarParser.type_field_return);

		object COMMA84_tree=null;

		try { DebugEnterRule(GrammarFileName, "type_fields");
		DebugLocation(225, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:226:2: ( type_field ( COMMA type_field )* )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:227:3: type_field ( COMMA type_field )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(227, 3);
			PushFollow(Follow._type_field_in_type_fields1764);
			type_field83=type_field();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type_field83.Tree);
			DebugLocation(227, 14);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:227:14: ( COMMA type_field )*
			try { DebugEnterSubRule(23);
			while (true)
			{
				int alt23=2;
				try { DebugEnterDecision(23, decisionCanBacktrack[23]);
				int LA23_0 = input.LA(1);

				if ((LA23_0==COMMA))
				{
					alt23=1;
				}


				} finally { DebugExitDecision(23); }
				switch ( alt23 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:227:15: COMMA type_field
					{
					DebugLocation(227, 20);
					COMMA84=(IToken)Match(input,COMMA,Follow._COMMA_in_type_fields1767); if (state.failed) return retval;
					DebugLocation(227, 22);
					PushFollow(Follow._type_field_in_type_fields1770);
					type_field85=type_field();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type_field85.Tree);

					}
					break;

				default:
					goto loop23;
				}
			}

			loop23:
				;

			} finally { DebugExitSubRule(23); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("type_fields", 20);
			LeaveRule("type_fields", 20);
			Leave_type_fields();
		}
		DebugLocation(228, 1);
		} finally { DebugExitRule(GrammarFileName, "type_fields"); }
		return retval;

	}
	// $ANTLR end "type_fields"

	public class type_field_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_type_field();
	partial void Leave_type_field();

	// $ANTLR start "type_field"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:230:1: type_field : ID COLON type_id ;
	[GrammarRule("type_field")]
	private TigerGrammarParser.type_field_return type_field()
	{
		Enter_type_field();
		EnterRule("type_field", 21);
		TraceIn("type_field", 21);
		TigerGrammarParser.type_field_return retval = new TigerGrammarParser.type_field_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID86=null;
		IToken COLON87=null;
		TigerGrammarParser.type_id_return type_id88 = default(TigerGrammarParser.type_id_return);

		object ID86_tree=null;
		object COLON87_tree=null;

		try { DebugEnterRule(GrammarFileName, "type_field");
		DebugLocation(230, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:231:2: ( ID COLON type_id )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:232:3: ID COLON type_id
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(232, 3);
			ID86=(IToken)Match(input,ID,Follow._ID_in_type_field1787); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID86_tree = (object)adaptor.Create(ID86);
			adaptor.AddChild(root_0, ID86_tree);
			}
			DebugLocation(232, 11);
			COLON87=(IToken)Match(input,COLON,Follow._COLON_in_type_field1789); if (state.failed) return retval;
			DebugLocation(232, 13);
			PushFollow(Follow._type_id_in_type_field1792);
			type_id88=type_id();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type_id88.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("type_field", 21);
			LeaveRule("type_field", 21);
			Leave_type_field();
		}
		DebugLocation(233, 1);
		} finally { DebugExitRule(GrammarFileName, "type_field"); }
		return retval;

	}
	// $ANTLR end "type_field"

	public class variable_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_variable_declaration();
	partial void Leave_variable_declaration();

	// $ANTLR start "variable_declaration"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:235:1: variable_declaration : VAR id1= ID ( COLON id2= type_id ASSIGN e= expr -> ^( TYPED_VAR_DECLARATION $id1 $id2 $e) | ASSIGN e= expr -> ^( INFERRED_VAR_DECLARATION $id1 $e) ) ;
	[GrammarRule("variable_declaration")]
	private TigerGrammarParser.variable_declaration_return variable_declaration()
	{
		Enter_variable_declaration();
		EnterRule("variable_declaration", 22);
		TraceIn("variable_declaration", 22);
		TigerGrammarParser.variable_declaration_return retval = new TigerGrammarParser.variable_declaration_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken id1=null;
		IToken VAR89=null;
		IToken COLON90=null;
		IToken ASSIGN91=null;
		IToken ASSIGN92=null;
		TigerGrammarParser.type_id_return id2 = default(TigerGrammarParser.type_id_return);
		TigerGrammarParser.expr_return e = default(TigerGrammarParser.expr_return);

		object id1_tree=null;
		object VAR89_tree=null;
		object COLON90_tree=null;
		object ASSIGN91_tree=null;
		object ASSIGN92_tree=null;
		RewriteRuleITokenStream stream_COLON=new RewriteRuleITokenStream(adaptor,"token COLON");
		RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_expr=new RewriteRuleSubtreeStream(adaptor,"rule expr");
		RewriteRuleSubtreeStream stream_type_id=new RewriteRuleSubtreeStream(adaptor,"rule type_id");
		try { DebugEnterRule(GrammarFileName, "variable_declaration");
		DebugLocation(235, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:236:2: ( VAR id1= ID ( COLON id2= type_id ASSIGN e= expr -> ^( TYPED_VAR_DECLARATION $id1 $id2 $e) | ASSIGN e= expr -> ^( INFERRED_VAR_DECLARATION $id1 $e) ) )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:237:3: VAR id1= ID ( COLON id2= type_id ASSIGN e= expr -> ^( TYPED_VAR_DECLARATION $id1 $id2 $e) | ASSIGN e= expr -> ^( INFERRED_VAR_DECLARATION $id1 $e) )
			{
			DebugLocation(237, 3);
			VAR89=(IToken)Match(input,VAR,Follow._VAR_in_variable_declaration1808); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_VAR.Add(VAR89);

			DebugLocation(237, 11);
			id1=(IToken)Match(input,ID,Follow._ID_in_variable_declaration1814); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(id1);

			DebugLocation(237, 16);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:237:16: ( COLON id2= type_id ASSIGN e= expr -> ^( TYPED_VAR_DECLARATION $id1 $id2 $e) | ASSIGN e= expr -> ^( INFERRED_VAR_DECLARATION $id1 $e) )
			int alt24=2;
			try { DebugEnterSubRule(24);
			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
			int LA24_0 = input.LA(1);

			if ((LA24_0==COLON))
			{
				alt24=1;
			}
			else if ((LA24_0==ASSIGN))
			{
				alt24=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 24, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(24); }
			switch (alt24)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:237:17: COLON id2= type_id ASSIGN e= expr
				{
				DebugLocation(237, 17);
				COLON90=(IToken)Match(input,COLON,Follow._COLON_in_variable_declaration1817); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_COLON.Add(COLON90);

				DebugLocation(237, 27);
				PushFollow(Follow._type_id_in_variable_declaration1823);
				id2=type_id();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type_id.Add(id2.Tree);
				DebugLocation(237, 37);
				ASSIGN91=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_variable_declaration1825); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN91);

				DebugLocation(237, 46);
				PushFollow(Follow._expr_in_variable_declaration1831);
				e=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr.Add(e.Tree);


				{
				// AST REWRITE
				// elements: id2, id1, e
				// token labels: id1
				// rule labels: retval, e, id2
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_id1=new RewriteRuleITokenStream(adaptor,"token id1",id1);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_e=new RewriteRuleSubtreeStream(adaptor,"rule e",e!=null?e.Tree:null);
				RewriteRuleSubtreeStream stream_id2=new RewriteRuleSubtreeStream(adaptor,"rule id2",id2!=null?id2.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 237:53: -> ^( TYPED_VAR_DECLARATION $id1 $id2 $e)
				{
					DebugLocation(237, 56);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:237:56: ^( TYPED_VAR_DECLARATION $id1 $id2 $e)
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(237, 58);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPED_VAR_DECLARATION, "TYPED_VAR_DECLARATION"), root_1);

					DebugLocation(237, 80);
					adaptor.AddChild(root_1, stream_id1.NextNode());
					DebugLocation(237, 85);
					adaptor.AddChild(root_1, stream_id2.NextTree());
					DebugLocation(237, 90);
					adaptor.AddChild(root_1, stream_e.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:238:9: ASSIGN e= expr
				{
				DebugLocation(238, 9);
				ASSIGN92=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_variable_declaration1857); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN92);

				DebugLocation(238, 18);
				PushFollow(Follow._expr_in_variable_declaration1863);
				e=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr.Add(e.Tree);


				{
				// AST REWRITE
				// elements: id1, e
				// token labels: id1
				// rule labels: retval, e
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_id1=new RewriteRuleITokenStream(adaptor,"token id1",id1);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_e=new RewriteRuleSubtreeStream(adaptor,"rule e",e!=null?e.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 238:25: -> ^( INFERRED_VAR_DECLARATION $id1 $e)
				{
					DebugLocation(238, 28);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:238:28: ^( INFERRED_VAR_DECLARATION $id1 $e)
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(238, 30);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(INFERRED_VAR_DECLARATION, "INFERRED_VAR_DECLARATION"), root_1);

					DebugLocation(238, 55);
					adaptor.AddChild(root_1, stream_id1.NextNode());
					DebugLocation(238, 60);
					adaptor.AddChild(root_1, stream_e.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			} finally { DebugExitSubRule(24); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("variable_declaration", 22);
			LeaveRule("variable_declaration", 22);
			Leave_variable_declaration();
		}
		DebugLocation(239, 1);
		} finally { DebugExitRule(GrammarFileName, "variable_declaration"); }
		return retval;

	}
	// $ANTLR end "variable_declaration"

	public class callable_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_callable_declaration();
	partial void Leave_callable_declaration();

	// $ANTLR start "callable_declaration"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:241:1: callable_declaration : FUNCTION id1= ID L_PARENT (t= type_fields )? R_PARENT ( COLON t1= type_id EQUALS e= expr -> ^( FUNCTION_DECLARATION $id1 ( $t)? $t1 $e) | EQUALS e= expr -> ^( PROCEDURE_DECLARATION $id1 ( $t)? $e) ) ;
	[GrammarRule("callable_declaration")]
	private TigerGrammarParser.callable_declaration_return callable_declaration()
	{
		Enter_callable_declaration();
		EnterRule("callable_declaration", 23);
		TraceIn("callable_declaration", 23);
		TigerGrammarParser.callable_declaration_return retval = new TigerGrammarParser.callable_declaration_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken id1=null;
		IToken FUNCTION93=null;
		IToken L_PARENT94=null;
		IToken R_PARENT95=null;
		IToken COLON96=null;
		IToken EQUALS97=null;
		IToken EQUALS98=null;
		TigerGrammarParser.type_fields_return t = default(TigerGrammarParser.type_fields_return);
		TigerGrammarParser.type_id_return t1 = default(TigerGrammarParser.type_id_return);
		TigerGrammarParser.expr_return e = default(TigerGrammarParser.expr_return);

		object id1_tree=null;
		object FUNCTION93_tree=null;
		object L_PARENT94_tree=null;
		object R_PARENT95_tree=null;
		object COLON96_tree=null;
		object EQUALS97_tree=null;
		object EQUALS98_tree=null;
		RewriteRuleITokenStream stream_FUNCTION=new RewriteRuleITokenStream(adaptor,"token FUNCTION");
		RewriteRuleITokenStream stream_COLON=new RewriteRuleITokenStream(adaptor,"token COLON");
		RewriteRuleITokenStream stream_EQUALS=new RewriteRuleITokenStream(adaptor,"token EQUALS");
		RewriteRuleITokenStream stream_R_PARENT=new RewriteRuleITokenStream(adaptor,"token R_PARENT");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_L_PARENT=new RewriteRuleITokenStream(adaptor,"token L_PARENT");
		RewriteRuleSubtreeStream stream_type_fields=new RewriteRuleSubtreeStream(adaptor,"rule type_fields");
		RewriteRuleSubtreeStream stream_expr=new RewriteRuleSubtreeStream(adaptor,"rule expr");
		RewriteRuleSubtreeStream stream_type_id=new RewriteRuleSubtreeStream(adaptor,"rule type_id");
		try { DebugEnterRule(GrammarFileName, "callable_declaration");
		DebugLocation(241, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:242:2: ( FUNCTION id1= ID L_PARENT (t= type_fields )? R_PARENT ( COLON t1= type_id EQUALS e= expr -> ^( FUNCTION_DECLARATION $id1 ( $t)? $t1 $e) | EQUALS e= expr -> ^( PROCEDURE_DECLARATION $id1 ( $t)? $e) ) )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:243:3: FUNCTION id1= ID L_PARENT (t= type_fields )? R_PARENT ( COLON t1= type_id EQUALS e= expr -> ^( FUNCTION_DECLARATION $id1 ( $t)? $t1 $e) | EQUALS e= expr -> ^( PROCEDURE_DECLARATION $id1 ( $t)? $e) )
			{
			DebugLocation(243, 3);
			FUNCTION93=(IToken)Match(input,FUNCTION,Follow._FUNCTION_in_callable_declaration1893); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_FUNCTION.Add(FUNCTION93);

			DebugLocation(243, 16);
			id1=(IToken)Match(input,ID,Follow._ID_in_callable_declaration1899); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(id1);

			DebugLocation(243, 21);
			L_PARENT94=(IToken)Match(input,L_PARENT,Follow._L_PARENT_in_callable_declaration1901); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_L_PARENT.Add(L_PARENT94);

			DebugLocation(243, 30);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:243:30: (t= type_fields )?
			int alt25=2;
			try { DebugEnterSubRule(25);
			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
			int LA25_0 = input.LA(1);

			if ((LA25_0==ID))
			{
				alt25=1;
			}
			} finally { DebugExitDecision(25); }
			switch (alt25)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:243:31: t= type_fields
				{
				DebugLocation(243, 33);
				PushFollow(Follow._type_fields_in_callable_declaration1908);
				t=type_fields();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type_fields.Add(t.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(25); }

			DebugLocation(243, 49);
			R_PARENT95=(IToken)Match(input,R_PARENT,Follow._R_PARENT_in_callable_declaration1912); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_R_PARENT.Add(R_PARENT95);

			DebugLocation(244, 3);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:244:3: ( COLON t1= type_id EQUALS e= expr -> ^( FUNCTION_DECLARATION $id1 ( $t)? $t1 $e) | EQUALS e= expr -> ^( PROCEDURE_DECLARATION $id1 ( $t)? $e) )
			int alt26=2;
			try { DebugEnterSubRule(26);
			try { DebugEnterDecision(26, decisionCanBacktrack[26]);
			int LA26_0 = input.LA(1);

			if ((LA26_0==COLON))
			{
				alt26=1;
			}
			else if ((LA26_0==EQUALS))
			{
				alt26=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 26, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(26); }
			switch (alt26)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:244:4: COLON t1= type_id EQUALS e= expr
				{
				DebugLocation(244, 4);
				COLON96=(IToken)Match(input,COLON,Follow._COLON_in_callable_declaration1918); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_COLON.Add(COLON96);

				DebugLocation(244, 13);
				PushFollow(Follow._type_id_in_callable_declaration1924);
				t1=type_id();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type_id.Add(t1.Tree);
				DebugLocation(244, 23);
				EQUALS97=(IToken)Match(input,EQUALS,Follow._EQUALS_in_callable_declaration1926); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_EQUALS.Add(EQUALS97);

				DebugLocation(244, 32);
				PushFollow(Follow._expr_in_callable_declaration1932);
				e=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr.Add(e.Tree);


				{
				// AST REWRITE
				// elements: t, t1, e, id1
				// token labels: id1
				// rule labels: retval, t1, e, t
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_id1=new RewriteRuleITokenStream(adaptor,"token id1",id1);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_t1=new RewriteRuleSubtreeStream(adaptor,"rule t1",t1!=null?t1.Tree:null);
				RewriteRuleSubtreeStream stream_e=new RewriteRuleSubtreeStream(adaptor,"rule e",e!=null?e.Tree:null);
				RewriteRuleSubtreeStream stream_t=new RewriteRuleSubtreeStream(adaptor,"rule t",t!=null?t.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 244:39: -> ^( FUNCTION_DECLARATION $id1 ( $t)? $t1 $e)
				{
					DebugLocation(244, 42);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:244:42: ^( FUNCTION_DECLARATION $id1 ( $t)? $t1 $e)
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(244, 44);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCTION_DECLARATION, "FUNCTION_DECLARATION"), root_1);

					DebugLocation(244, 65);
					adaptor.AddChild(root_1, stream_id1.NextNode());
					DebugLocation(244, 70);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:244:70: ( $t)?
					if ( stream_t.HasNext )
					{
						DebugLocation(244, 70);
						adaptor.AddChild(root_1, stream_t.NextTree());

					}
					stream_t.Reset();
					DebugLocation(244, 74);
					adaptor.AddChild(root_1, stream_t1.NextTree());
					DebugLocation(244, 78);
					adaptor.AddChild(root_1, stream_e.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:244:84: EQUALS e= expr
				{
				DebugLocation(244, 84);
				EQUALS98=(IToken)Match(input,EQUALS,Follow._EQUALS_in_callable_declaration1955); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_EQUALS.Add(EQUALS98);

				DebugLocation(244, 93);
				PushFollow(Follow._expr_in_callable_declaration1961);
				e=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr.Add(e.Tree);


				{
				// AST REWRITE
				// elements: t, id1, e
				// token labels: id1
				// rule labels: retval, e, t
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_id1=new RewriteRuleITokenStream(adaptor,"token id1",id1);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_e=new RewriteRuleSubtreeStream(adaptor,"rule e",e!=null?e.Tree:null);
				RewriteRuleSubtreeStream stream_t=new RewriteRuleSubtreeStream(adaptor,"rule t",t!=null?t.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 244:100: -> ^( PROCEDURE_DECLARATION $id1 ( $t)? $e)
				{
					DebugLocation(244, 102);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:244:102: ^( PROCEDURE_DECLARATION $id1 ( $t)? $e)
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(244, 104);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROCEDURE_DECLARATION, "PROCEDURE_DECLARATION"), root_1);

					DebugLocation(244, 126);
					adaptor.AddChild(root_1, stream_id1.NextNode());
					DebugLocation(244, 131);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:244:131: ( $t)?
					if ( stream_t.HasNext )
					{
						DebugLocation(244, 131);
						adaptor.AddChild(root_1, stream_t.NextTree());

					}
					stream_t.Reset();
					DebugLocation(244, 135);
					adaptor.AddChild(root_1, stream_e.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			} finally { DebugExitSubRule(26); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("callable_declaration", 23);
			LeaveRule("callable_declaration", 23);
			Leave_callable_declaration();
		}
		DebugLocation(245, 1);
		} finally { DebugExitRule(GrammarFileName, "callable_declaration"); }
		return retval;

	}
	// $ANTLR end "callable_declaration"

	public class expr_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr_list();
	partial void Leave_expr_list();

	// $ANTLR start "expr_list"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:247:1: expr_list : expr ( COMMA expr )* ;
	[GrammarRule("expr_list")]
	private TigerGrammarParser.expr_list_return expr_list()
	{
		Enter_expr_list();
		EnterRule("expr_list", 24);
		TraceIn("expr_list", 24);
		TigerGrammarParser.expr_list_return retval = new TigerGrammarParser.expr_list_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken COMMA100=null;
		TigerGrammarParser.expr_return expr99 = default(TigerGrammarParser.expr_return);
		TigerGrammarParser.expr_return expr101 = default(TigerGrammarParser.expr_return);

		object COMMA100_tree=null;

		try { DebugEnterRule(GrammarFileName, "expr_list");
		DebugLocation(247, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:248:2: ( expr ( COMMA expr )* )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:249:3: expr ( COMMA expr )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(249, 3);
			PushFollow(Follow._expr_in_expr_list1993);
			expr99=expr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr99.Tree);
			DebugLocation(249, 8);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:249:8: ( COMMA expr )*
			try { DebugEnterSubRule(27);
			while (true)
			{
				int alt27=2;
				try { DebugEnterDecision(27, decisionCanBacktrack[27]);
				int LA27_0 = input.LA(1);

				if ((LA27_0==COMMA))
				{
					alt27=1;
				}


				} finally { DebugExitDecision(27); }
				switch ( alt27 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:249:9: COMMA expr
					{
					DebugLocation(249, 14);
					COMMA100=(IToken)Match(input,COMMA,Follow._COMMA_in_expr_list1996); if (state.failed) return retval;
					DebugLocation(249, 16);
					PushFollow(Follow._expr_in_expr_list1999);
					expr101=expr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr101.Tree);

					}
					break;

				default:
					goto loop27;
				}
			}

			loop27:
				;

			} finally { DebugExitSubRule(27); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr_list", 24);
			LeaveRule("expr_list", 24);
			Leave_expr_list();
		}
		DebugLocation(250, 1);
		} finally { DebugExitRule(GrammarFileName, "expr_list"); }
		return retval;

	}
	// $ANTLR end "expr_list"

	public class expr_seq_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr_seq();
	partial void Leave_expr_seq();

	// $ANTLR start "expr_seq"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:252:1: expr_seq : expr ( SEMICOLON expr )* ;
	[GrammarRule("expr_seq")]
	private TigerGrammarParser.expr_seq_return expr_seq()
	{
		Enter_expr_seq();
		EnterRule("expr_seq", 25);
		TraceIn("expr_seq", 25);
		TigerGrammarParser.expr_seq_return retval = new TigerGrammarParser.expr_seq_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken SEMICOLON103=null;
		TigerGrammarParser.expr_return expr102 = default(TigerGrammarParser.expr_return);
		TigerGrammarParser.expr_return expr104 = default(TigerGrammarParser.expr_return);

		object SEMICOLON103_tree=null;

		try { DebugEnterRule(GrammarFileName, "expr_seq");
		DebugLocation(252, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:253:2: ( expr ( SEMICOLON expr )* )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:254:3: expr ( SEMICOLON expr )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(254, 3);
			PushFollow(Follow._expr_in_expr_seq2018);
			expr102=expr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr102.Tree);
			DebugLocation(254, 8);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:254:8: ( SEMICOLON expr )*
			try { DebugEnterSubRule(28);
			while (true)
			{
				int alt28=2;
				try { DebugEnterDecision(28, decisionCanBacktrack[28]);
				int LA28_0 = input.LA(1);

				if ((LA28_0==SEMICOLON))
				{
					alt28=1;
				}


				} finally { DebugExitDecision(28); }
				switch ( alt28 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:254:9: SEMICOLON expr
					{
					DebugLocation(254, 18);
					SEMICOLON103=(IToken)Match(input,SEMICOLON,Follow._SEMICOLON_in_expr_seq2021); if (state.failed) return retval;
					DebugLocation(254, 20);
					PushFollow(Follow._expr_in_expr_seq2024);
					expr104=expr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr104.Tree);

					}
					break;

				default:
					goto loop28;
				}
			}

			loop28:
				;

			} finally { DebugExitSubRule(28); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr_seq", 25);
			LeaveRule("expr_seq", 25);
			Leave_expr_seq();
		}
		DebugLocation(255, 1);
		} finally { DebugExitRule(GrammarFileName, "expr_seq"); }
		return retval;

	}
	// $ANTLR end "expr_seq"

	public class field_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_field_list();
	partial void Leave_field_list();

	// $ANTLR start "field_list"
	// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:257:1: field_list : ID EQUALS expr ( COMMA ID EQUALS expr )* ;
	[GrammarRule("field_list")]
	private TigerGrammarParser.field_list_return field_list()
	{
		Enter_field_list();
		EnterRule("field_list", 26);
		TraceIn("field_list", 26);
		TigerGrammarParser.field_list_return retval = new TigerGrammarParser.field_list_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID105=null;
		IToken EQUALS106=null;
		IToken COMMA108=null;
		IToken ID109=null;
		IToken EQUALS110=null;
		TigerGrammarParser.expr_return expr107 = default(TigerGrammarParser.expr_return);
		TigerGrammarParser.expr_return expr111 = default(TigerGrammarParser.expr_return);

		object ID105_tree=null;
		object EQUALS106_tree=null;
		object COMMA108_tree=null;
		object ID109_tree=null;
		object EQUALS110_tree=null;

		try { DebugEnterRule(GrammarFileName, "field_list");
		DebugLocation(257, 1);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:258:2: ( ID EQUALS expr ( COMMA ID EQUALS expr )* )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:259:3: ID EQUALS expr ( COMMA ID EQUALS expr )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(259, 3);
			ID105=(IToken)Match(input,ID,Follow._ID_in_field_list2042); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			ID105_tree = (object)adaptor.Create(ID105);
			adaptor.AddChild(root_0, ID105_tree);
			}
			DebugLocation(259, 12);
			EQUALS106=(IToken)Match(input,EQUALS,Follow._EQUALS_in_field_list2044); if (state.failed) return retval;
			DebugLocation(259, 14);
			PushFollow(Follow._expr_in_field_list2047);
			expr107=expr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr107.Tree);
			DebugLocation(259, 19);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:259:19: ( COMMA ID EQUALS expr )*
			try { DebugEnterSubRule(29);
			while (true)
			{
				int alt29=2;
				try { DebugEnterDecision(29, decisionCanBacktrack[29]);
				int LA29_0 = input.LA(1);

				if ((LA29_0==COMMA))
				{
					alt29=1;
				}


				} finally { DebugExitDecision(29); }
				switch ( alt29 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:259:20: COMMA ID EQUALS expr
					{
					DebugLocation(259, 25);
					COMMA108=(IToken)Match(input,COMMA,Follow._COMMA_in_field_list2050); if (state.failed) return retval;
					DebugLocation(259, 27);
					ID109=(IToken)Match(input,ID,Follow._ID_in_field_list2053); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					ID109_tree = (object)adaptor.Create(ID109);
					adaptor.AddChild(root_0, ID109_tree);
					}
					DebugLocation(259, 36);
					EQUALS110=(IToken)Match(input,EQUALS,Follow._EQUALS_in_field_list2055); if (state.failed) return retval;
					DebugLocation(259, 38);
					PushFollow(Follow._expr_in_field_list2058);
					expr111=expr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr111.Tree);

					}
					break;

				default:
					goto loop29;
				}
			}

			loop29:
				;

			} finally { DebugExitSubRule(29); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("field_list", 26);
			LeaveRule("field_list", 26);
			Leave_field_list();
		}
		DebugLocation(260, 1);
		} finally { DebugExitRule(GrammarFileName, "field_list"); }
		return retval;

	}
	// $ANTLR end "field_list"

	partial void Enter_synpred1_TigerGrammar_fragment();
	partial void Leave_synpred1_TigerGrammar_fragment();

	// $ANTLR start synpred1_TigerGrammar
	public void synpred1_TigerGrammar_fragment()
	{
		Enter_synpred1_TigerGrammar_fragment();
		EnterRule("synpred1_TigerGrammar_fragment", 27);
		TraceIn("synpred1_TigerGrammar_fragment", 27);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:99:4: ( array_creation )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:99:4: array_creation
			{
			DebugLocation(99, 4);
			PushFollow(Follow._array_creation_in_synpred1_TigerGrammar577);
			array_creation();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred1_TigerGrammar_fragment", 27);
			LeaveRule("synpred1_TigerGrammar_fragment", 27);
			Leave_synpred1_TigerGrammar_fragment();
		}
	}
	// $ANTLR end synpred1_TigerGrammar

	partial void Enter_synpred2_TigerGrammar_fragment();
	partial void Leave_synpred2_TigerGrammar_fragment();

	// $ANTLR start synpred2_TigerGrammar
	public void synpred2_TigerGrammar_fragment()
	{
		Enter_synpred2_TigerGrammar_fragment();
		EnterRule("synpred2_TigerGrammar_fragment", 28);
		TraceIn("synpred2_TigerGrammar_fragment", 28);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:100:10: ( assign_expr )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:100:10: assign_expr
			{
			DebugLocation(100, 10);
			PushFollow(Follow._assign_expr_in_synpred2_TigerGrammar588);
			assign_expr();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred2_TigerGrammar_fragment", 28);
			LeaveRule("synpred2_TigerGrammar_fragment", 28);
			Leave_synpred2_TigerGrammar_fragment();
		}
	}
	// $ANTLR end synpred2_TigerGrammar

	partial void Enter_synpred3_TigerGrammar_fragment();
	partial void Leave_synpred3_TigerGrammar_fragment();

	// $ANTLR start synpred3_TigerGrammar
	public void synpred3_TigerGrammar_fragment()
	{
		Enter_synpred3_TigerGrammar_fragment();
		EnterRule("synpred3_TigerGrammar_fragment", 29);
		TraceIn("synpred3_TigerGrammar_fragment", 29);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:101:10: ( expr_or )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:101:10: expr_or
			{
			DebugLocation(101, 10);
			PushFollow(Follow._expr_or_in_synpred3_TigerGrammar600);
			expr_or();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred3_TigerGrammar_fragment", 29);
			LeaveRule("synpred3_TigerGrammar_fragment", 29);
			Leave_synpred3_TigerGrammar_fragment();
		}
	}
	// $ANTLR end synpred3_TigerGrammar

	partial void Enter_synpred5_TigerGrammar_fragment();
	partial void Leave_synpred5_TigerGrammar_fragment();

	// $ANTLR start synpred5_TigerGrammar
	public void synpred5_TigerGrammar_fragment()
	{
		Enter_synpred5_TigerGrammar_fragment();
		EnterRule("synpred5_TigerGrammar_fragment", 31);
		TraceIn("synpred5_TigerGrammar_fragment", 31);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:159:9: ( IF expr THEN expr ELSE )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:159:10: IF expr THEN expr ELSE
			{
			DebugLocation(159, 10);
			Match(input,IF,Follow._IF_in_synpred5_TigerGrammar977); if (state.failed) return;
			DebugLocation(159, 13);
			PushFollow(Follow._expr_in_synpred5_TigerGrammar979);
			expr();
			PopFollow();
			if (state.failed) return;
			DebugLocation(159, 18);
			Match(input,THEN,Follow._THEN_in_synpred5_TigerGrammar981); if (state.failed) return;
			DebugLocation(159, 23);
			PushFollow(Follow._expr_in_synpred5_TigerGrammar983);
			expr();
			PopFollow();
			if (state.failed) return;
			DebugLocation(159, 28);
			Match(input,ELSE,Follow._ELSE_in_synpred5_TigerGrammar985); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred5_TigerGrammar_fragment", 31);
			LeaveRule("synpred5_TigerGrammar_fragment", 31);
			Leave_synpred5_TigerGrammar_fragment();
		}
	}
	// $ANTLR end synpred5_TigerGrammar

	partial void Enter_synpred6_TigerGrammar_fragment();
	partial void Leave_synpred6_TigerGrammar_fragment();

	// $ANTLR start synpred6_TigerGrammar
	public void synpred6_TigerGrammar_fragment()
	{
		Enter_synpred6_TigerGrammar_fragment();
		EnterRule("synpred6_TigerGrammar_fragment", 32);
		TraceIn("synpred6_TigerGrammar_fragment", 32);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:186:14: ( ID L_BRACE )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:186:15: ID L_BRACE
			{
			DebugLocation(186, 15);
			Match(input,ID,Follow._ID_in_synpred6_TigerGrammar1315); if (state.failed) return;
			DebugLocation(186, 18);
			Match(input,L_BRACE,Follow._L_BRACE_in_synpred6_TigerGrammar1317); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred6_TigerGrammar_fragment", 32);
			LeaveRule("synpred6_TigerGrammar_fragment", 32);
			Leave_synpred6_TigerGrammar_fragment();
		}
	}
	// $ANTLR end synpred6_TigerGrammar

	partial void Enter_synpred7_TigerGrammar_fragment();
	partial void Leave_synpred7_TigerGrammar_fragment();

	// $ANTLR start synpred7_TigerGrammar
	public void synpred7_TigerGrammar_fragment()
	{
		Enter_synpred7_TigerGrammar_fragment();
		EnterRule("synpred7_TigerGrammar_fragment", 33);
		TraceIn("synpred7_TigerGrammar_fragment", 33);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:189:14: ( ID L_PARENT )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:189:15: ID L_PARENT
			{
			DebugLocation(189, 15);
			Match(input,ID,Follow._ID_in_synpred7_TigerGrammar1387); if (state.failed) return;
			DebugLocation(189, 18);
			Match(input,L_PARENT,Follow._L_PARENT_in_synpred7_TigerGrammar1389); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred7_TigerGrammar_fragment", 33);
			LeaveRule("synpred7_TigerGrammar_fragment", 33);
			Leave_synpred7_TigerGrammar_fragment();
		}
	}
	// $ANTLR end synpred7_TigerGrammar
	#endregion Rules

	#region Synpreds
	private bool EvaluatePredicate(System.Action fragment)
	{
		bool success = false;
		state.backtracking++;
		try { DebugBeginBacktrack(state.backtracking);
		int start = input.Mark();
		try
		{
			fragment();
		}
		catch ( RecognitionException re )
		{
			System.Console.Error.WriteLine("impossible: "+re);
		}
		success = !state.failed;
		input.Rewind(start);
		} finally { DebugEndBacktrack(state.backtracking, success); }
		state.backtracking--;
		state.failed=false;
		return success;
	}
	#endregion Synpreds


	#region DFA
	DFA1 dfa1;
	DFA14 dfa14;
	DFA15 dfa15;
	DFA17 dfa17;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa1 = new DFA1( this, SpecialStateTransition1 );
		dfa14 = new DFA14( this );
		dfa15 = new DFA15( this );
		dfa17 = new DFA17( this );
	}

	private class DFA1 : DFA
	{
		private const string DFA1_eotS =
			"\xE\xFFFF";
		private const string DFA1_eofS =
			"\xE\xFFFF";
		private const string DFA1_minS =
			"\x1\x5\x2\x0\xB\xFFFF";
		private const string DFA1_maxS =
			"\x1\x42\x2\x0\xB\xFFFF";
		private const string DFA1_acceptS =
			"\x3\xFFFF\x1\x3\x3\xFFFF\x1\x4\x3\xFFFF\x1\x5\x1\x1\x1\x2";
		private const string DFA1_specialS =
			"\x1\xFFFF\x1\x0\x1\x1\xB\xFFFF}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x1\x7\x2\xFFFF\x2\x7\x2\xFFFF\x1\xB\x3\xFFFF\x1\x7\x1\x3\x7\xFFFF"+
				"\x1\x2\x6\xFFFF\x1\x3\x1F\xFFFF\x2\x3\x1\x1",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA1_eot = DFA.UnpackEncodedString(DFA1_eotS);
		private static readonly short[] DFA1_eof = DFA.UnpackEncodedString(DFA1_eofS);
		private static readonly char[] DFA1_min = DFA.UnpackEncodedStringToUnsignedChars(DFA1_minS);
		private static readonly char[] DFA1_max = DFA.UnpackEncodedStringToUnsignedChars(DFA1_maxS);
		private static readonly short[] DFA1_accept = DFA.UnpackEncodedString(DFA1_acceptS);
		private static readonly short[] DFA1_special = DFA.UnpackEncodedString(DFA1_specialS);
		private static readonly short[][] DFA1_transition;

		static DFA1()
		{
			int numStates = DFA1_transitionS.Length;
			DFA1_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA1_transition[i] = DFA.UnpackEncodedString(DFA1_transitionS[i]);
			}
		}

		public DFA1( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 1;
			this.eot = DFA1_eot;
			this.eof = DFA1_eof;
			this.min = DFA1_min;
			this.max = DFA1_max;
			this.accept = DFA1_accept;
			this.special = DFA1_special;
			this.transition = DFA1_transition;
		}

		public override string Description { get { return "98:1: expr options {backtrack=true; memoize=true; } : ( array_creation | assign_expr | expr_or | control_instr | let_in_end );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition1(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA1_1 = input.LA(1);


				int index1_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred1_TigerGrammar_fragment)) ) {s = 12;}

				else if ( (EvaluatePredicate(synpred2_TigerGrammar_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred3_TigerGrammar_fragment)) ) {s = 3;}


				input.Seek(index1_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA1_2 = input.LA(1);


				int index1_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred2_TigerGrammar_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred3_TigerGrammar_fragment)) ) {s = 3;}


				input.Seek(index1_2);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 1, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA14 : DFA
	{
		private const string DFA14_eotS =
			"\xD\xFFFF";
		private const string DFA14_eofS =
			"\xD\xFFFF";
		private const string DFA14_minS =
			"\x1\x5\xC\xFFFF";
		private const string DFA14_maxS =
			"\x1\x42\xC\xFFFF";
		private const string DFA14_acceptS =
			"\x1\xFFFF\x1\x1\xA\xFFFF\x1\x2";
		private const string DFA14_specialS =
			"\xD\xFFFF}>";
		private static readonly string[] DFA14_transitionS =
			{
				"\x1\x1\x2\xFFFF\x2\x1\x2\xFFFF\x1\x1\x1\xFFFF\x1\xC\x1\xFFFF\x2\x1"+
				"\x7\xFFFF\x1\x1\x6\xFFFF\x1\x1\x1F\xFFFF\x3\x1",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA14_eot = DFA.UnpackEncodedString(DFA14_eotS);
		private static readonly short[] DFA14_eof = DFA.UnpackEncodedString(DFA14_eofS);
		private static readonly char[] DFA14_min = DFA.UnpackEncodedStringToUnsignedChars(DFA14_minS);
		private static readonly char[] DFA14_max = DFA.UnpackEncodedStringToUnsignedChars(DFA14_maxS);
		private static readonly short[] DFA14_accept = DFA.UnpackEncodedString(DFA14_acceptS);
		private static readonly short[] DFA14_special = DFA.UnpackEncodedString(DFA14_specialS);
		private static readonly short[][] DFA14_transition;

		static DFA14()
		{
			int numStates = DFA14_transitionS.Length;
			DFA14_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA14_transition[i] = DFA.UnpackEncodedString(DFA14_transitionS[i]);
			}
		}

		public DFA14( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 14;
			this.eot = DFA14_eot;
			this.eof = DFA14_eof;
			this.min = DFA14_min;
			this.max = DFA14_max;
			this.accept = DFA14_accept;
			this.special = DFA14_special;
			this.transition = DFA14_transition;
		}

		public override string Description { get { return "166:32: (e_seq1= expr_seq )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA15 : DFA
	{
		private const string DFA15_eotS =
			"\xD\xFFFF";
		private const string DFA15_eofS =
			"\xD\xFFFF";
		private const string DFA15_minS =
			"\x1\x5\xC\xFFFF";
		private const string DFA15_maxS =
			"\x1\x42\xC\xFFFF";
		private const string DFA15_acceptS =
			"\x1\xFFFF\x1\x1\xA\xFFFF\x1\x2";
		private const string DFA15_specialS =
			"\xD\xFFFF}>";
		private static readonly string[] DFA15_transitionS =
			{
				"\x1\x1\x2\xFFFF\x2\x1\x2\xFFFF\x1\x1\x3\xFFFF\x2\x1\x7\xFFFF\x1\x1"+
				"\x1\xC\x5\xFFFF\x1\x1\x1F\xFFFF\x3\x1",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA15_eot = DFA.UnpackEncodedString(DFA15_eotS);
		private static readonly short[] DFA15_eof = DFA.UnpackEncodedString(DFA15_eofS);
		private static readonly char[] DFA15_min = DFA.UnpackEncodedStringToUnsignedChars(DFA15_minS);
		private static readonly char[] DFA15_max = DFA.UnpackEncodedStringToUnsignedChars(DFA15_maxS);
		private static readonly short[] DFA15_accept = DFA.UnpackEncodedString(DFA15_acceptS);
		private static readonly short[] DFA15_special = DFA.UnpackEncodedString(DFA15_specialS);
		private static readonly short[][] DFA15_transition;

		static DFA15()
		{
			int numStates = DFA15_transitionS.Length;
			DFA15_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA15_transition[i] = DFA.UnpackEncodedString(DFA15_transitionS[i]);
			}
		}

		public DFA15( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 15;
			this.eot = DFA15_eot;
			this.eof = DFA15_eof;
			this.min = DFA15_min;
			this.max = DFA15_max;
			this.accept = DFA15_accept;
			this.special = DFA15_special;
			this.transition = DFA15_transition;
		}

		public override string Description { get { return "183:17: (e_seq= expr_seq )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA17 : DFA
	{
		private const string DFA17_eotS =
			"\xD\xFFFF";
		private const string DFA17_eofS =
			"\xD\xFFFF";
		private const string DFA17_minS =
			"\x1\x5\xC\xFFFF";
		private const string DFA17_maxS =
			"\x1\x42\xC\xFFFF";
		private const string DFA17_acceptS =
			"\x1\xFFFF\x1\x1\xA\xFFFF\x1\x2";
		private const string DFA17_specialS =
			"\xD\xFFFF}>";
		private static readonly string[] DFA17_transitionS =
			{
				"\x1\x1\x2\xFFFF\x2\x1\x2\xFFFF\x1\x1\x3\xFFFF\x2\x1\x7\xFFFF\x1\x1"+
				"\x1\xC\x5\xFFFF\x1\x1\x1F\xFFFF\x3\x1",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
		private static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
		private static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
		private static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
		private static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
		private static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
		private static readonly short[][] DFA17_transition;

		static DFA17()
		{
			int numStates = DFA17_transitionS.Length;
			DFA17_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA17_transition[i] = DFA.UnpackEncodedString(DFA17_transitionS[i]);
			}
		}

		public DFA17( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 17;
			this.eot = DFA17_eot;
			this.eof = DFA17_eof;
			this.min = DFA17_min;
			this.max = DFA17_max;
			this.accept = DFA17_accept;
			this.special = DFA17_special;
			this.transition = DFA17_transition;
		}

		public override string Description { get { return "189:58: (callable_args= expr_list )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _expr_in_program545 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_program547 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_creation_in_expr577 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_expr_in_expr588 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_or_in_expr600 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _control_instr_in_expr611 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _let_in_end_in_expr622 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_and_in_expr_or638 = new BitSet(new ulong[]{0x40000000002UL});
		public static readonly BitSet _OR_in_expr_or641 = new BitSet(new ulong[]{0x102020000UL,0x7UL});
		public static readonly BitSet _expr_and_in_expr_or644 = new BitSet(new ulong[]{0x40000000002UL});
		public static readonly BitSet _expr_rel_in_expr_and660 = new BitSet(new ulong[]{0x20000000002UL});
		public static readonly BitSet _AND_in_expr_and663 = new BitSet(new ulong[]{0x102020000UL,0x7UL});
		public static readonly BitSet _expr_rel_in_expr_and666 = new BitSet(new ulong[]{0x20000000002UL});
		public static readonly BitSet _expr_arit_in_expr_rel682 = new BitSet(new ulong[]{0x1F800000002UL});
		public static readonly BitSet _EQUALS_in_expr_rel686 = new BitSet(new ulong[]{0x102020000UL,0x7UL});
		public static readonly BitSet _NOT_EQUALS_in_expr_rel692 = new BitSet(new ulong[]{0x102020000UL,0x7UL});
		public static readonly BitSet _LESS_in_expr_rel697 = new BitSet(new ulong[]{0x102020000UL,0x7UL});
		public static readonly BitSet _LESS_EQUALS_in_expr_rel702 = new BitSet(new ulong[]{0x102020000UL,0x7UL});
		public static readonly BitSet _GREATER_in_expr_rel707 = new BitSet(new ulong[]{0x102020000UL,0x7UL});
		public static readonly BitSet _GREATER_EQUALS_in_expr_rel712 = new BitSet(new ulong[]{0x102020000UL,0x7UL});
		public static readonly BitSet _expr_arit_in_expr_rel716 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_expr_arit732 = new BitSet(new ulong[]{0x180000002UL});
		public static readonly BitSet _MINUS_in_expr_arit736 = new BitSet(new ulong[]{0x102020000UL,0x7UL});
		public static readonly BitSet _PLUS_in_expr_arit741 = new BitSet(new ulong[]{0x102020000UL,0x7UL});
		public static readonly BitSet _term_in_expr_arit745 = new BitSet(new ulong[]{0x180000002UL});
		public static readonly BitSet _factor_in_term762 = new BitSet(new ulong[]{0x600000002UL});
		public static readonly BitSet _MULT_in_term766 = new BitSet(new ulong[]{0x102020000UL,0x7UL});
		public static readonly BitSet _DIV_in_term771 = new BitSet(new ulong[]{0x102020000UL,0x7UL});
		public static readonly BitSet _factor_in_term775 = new BitSet(new ulong[]{0x600000002UL});
		public static readonly BitSet _MINUS_in_factor792 = new BitSet(new ulong[]{0x102020000UL,0x7UL});
		public static readonly BitSet _unsigned_factor_in_factor798 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _unsigned_factor_in_factor819 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _constant_in_unsigned_factor834 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _lvalue_in_unsigned_factor845 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NIL_in_constant858 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INT_in_constant870 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _STRING_in_constant882 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MINUS_in_minus_expr899 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_minus_expr905 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_control_instr928 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_control_instr931 = new BitSet(new ulong[]{0x800UL});
		public static readonly BitSet _DO_in_control_instr933 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_control_instr936 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_control_instr948 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _ID_in_control_instr951 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _ASSIGN_in_control_instr953 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_control_instr956 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _TO_in_control_instr958 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_control_instr961 = new BitSet(new ulong[]{0x800UL});
		public static readonly BitSet _DO_in_control_instr963 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_control_instr966 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_control_instr990 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_control_instr996 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _THEN_in_control_instr998 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_control_instr1004 = new BitSet(new ulong[]{0x80UL});
		public static readonly BitSet _ELSE_in_control_instr1006 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_control_instr1012 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_control_instr1038 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_control_instr1044 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _THEN_in_control_instr1046 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_control_instr1052 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _BREAK_in_control_instr1077 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LET_in_let_in_end1093 = new BitSet(new ulong[]{0x1C0000UL});
		public static readonly BitSet _declarationList_in_let_in_end1100 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _IN_in_let_in_end1103 = new BitSet(new ulong[]{0x102035320UL,0x7UL});
		public static readonly BitSet _expr_seq_in_let_in_end1110 = new BitSet(new ulong[]{0x4000UL});
		public static readonly BitSet _END_in_let_in_end1114 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_array_creation1153 = new BitSet(new ulong[]{0x8000000UL});
		public static readonly BitSet _L_BRACKET_in_array_creation1155 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_array_creation1161 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _R_BRACKET_in_array_creation1163 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _OF_in_array_creation1165 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_array_creation1171 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _lvalue_in_assign_expr1204 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _ASSIGN_in_assign_expr1206 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_assign_expr1212 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _L_PARENT_in_lvalue1259 = new BitSet(new ulong[]{0x106031320UL,0x7UL});
		public static readonly BitSet _expr_seq_in_lvalue1266 = new BitSet(new ulong[]{0x4000000UL});
		public static readonly BitSet _R_PARENT_in_lvalue1270 = new BitSet(new ulong[]{0x8200002UL});
		public static readonly BitSet _type_id_in_lvalue1327 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _L_BRACE_in_lvalue1329 = new BitSet(new ulong[]{0x40000000UL,0x4UL});
		public static readonly BitSet _field_list_in_lvalue1336 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _R_BRACE_in_lvalue1340 = new BitSet(new ulong[]{0x8200002UL});
		public static readonly BitSet _ID_in_lvalue1399 = new BitSet(new ulong[]{0x2000000UL});
		public static readonly BitSet _L_PARENT_in_lvalue1401 = new BitSet(new ulong[]{0x106031320UL,0x7UL});
		public static readonly BitSet _expr_list_in_lvalue1408 = new BitSet(new ulong[]{0x4000000UL});
		public static readonly BitSet _R_PARENT_in_lvalue1412 = new BitSet(new ulong[]{0x8200002UL});
		public static readonly BitSet _ID_in_lvalue1469 = new BitSet(new ulong[]{0x8200002UL});
		public static readonly BitSet _DOT_in_lvalue1511 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _ID_in_lvalue1517 = new BitSet(new ulong[]{0x8200002UL});
		public static readonly BitSet _L_BRACKET_in_lvalue1537 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_lvalue1543 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _R_BRACKET_in_lvalue1545 = new BitSet(new ulong[]{0x8200002UL});
		public static readonly BitSet _type_declaration_in_declarationList1580 = new BitSet(new ulong[]{0x1C0002UL});
		public static readonly BitSet _variable_declaration_in_declarationList1584 = new BitSet(new ulong[]{0x1C0002UL});
		public static readonly BitSet _callable_declaration_in_declarationList1588 = new BitSet(new ulong[]{0x1C0002UL});
		public static readonly BitSet _TYPE_in_type_declaration1606 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _type_id_in_type_declaration1612 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _EQUALS_in_type_declaration1614 = new BitSet(new ulong[]{0x20000010UL,0x4UL});
		public static readonly BitSet _type_id_in_type_declaration1636 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _L_BRACE_in_type_declaration1667 = new BitSet(new ulong[]{0x40000000UL,0x4UL});
		public static readonly BitSet _type_fields_in_type_declaration1670 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _R_BRACE_in_type_declaration1674 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ARRAY_in_type_declaration1709 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _OF_in_type_declaration1711 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _type_id_in_type_declaration1717 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_type_id1748 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_field_in_type_fields1764 = new BitSet(new ulong[]{0x400002UL});
		public static readonly BitSet _COMMA_in_type_fields1767 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _type_field_in_type_fields1770 = new BitSet(new ulong[]{0x400002UL});
		public static readonly BitSet _ID_in_type_field1787 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _COLON_in_type_field1789 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _type_id_in_type_field1792 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VAR_in_variable_declaration1808 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _ID_in_variable_declaration1814 = new BitSet(new ulong[]{0x80000800000UL});
		public static readonly BitSet _COLON_in_variable_declaration1817 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _type_id_in_variable_declaration1823 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _ASSIGN_in_variable_declaration1825 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_variable_declaration1831 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ASSIGN_in_variable_declaration1857 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_variable_declaration1863 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FUNCTION_in_callable_declaration1893 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _ID_in_callable_declaration1899 = new BitSet(new ulong[]{0x2000000UL});
		public static readonly BitSet _L_PARENT_in_callable_declaration1901 = new BitSet(new ulong[]{0x4000000UL,0x4UL});
		public static readonly BitSet _type_fields_in_callable_declaration1908 = new BitSet(new ulong[]{0x4000000UL});
		public static readonly BitSet _R_PARENT_in_callable_declaration1912 = new BitSet(new ulong[]{0x800800000UL});
		public static readonly BitSet _COLON_in_callable_declaration1918 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _type_id_in_callable_declaration1924 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _EQUALS_in_callable_declaration1926 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_callable_declaration1932 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _EQUALS_in_callable_declaration1955 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_callable_declaration1961 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_in_expr_list1993 = new BitSet(new ulong[]{0x400002UL});
		public static readonly BitSet _COMMA_in_expr_list1996 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_expr_list1999 = new BitSet(new ulong[]{0x400002UL});
		public static readonly BitSet _expr_in_expr_seq2018 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _SEMICOLON_in_expr_seq2021 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_expr_seq2024 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _ID_in_field_list2042 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _EQUALS_in_field_list2044 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_field_list2047 = new BitSet(new ulong[]{0x400002UL});
		public static readonly BitSet _COMMA_in_field_list2050 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _ID_in_field_list2053 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _EQUALS_in_field_list2055 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_field_list2058 = new BitSet(new ulong[]{0x400002UL});
		public static readonly BitSet _array_creation_in_synpred1_TigerGrammar577 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_expr_in_synpred2_TigerGrammar588 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_or_in_synpred3_TigerGrammar600 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_synpred5_TigerGrammar977 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_synpred5_TigerGrammar979 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _THEN_in_synpred5_TigerGrammar981 = new BitSet(new ulong[]{0x102031320UL,0x7UL});
		public static readonly BitSet _expr_in_synpred5_TigerGrammar983 = new BitSet(new ulong[]{0x80UL});
		public static readonly BitSet _ELSE_in_synpred5_TigerGrammar985 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_synpred6_TigerGrammar1315 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _L_BRACE_in_synpred6_TigerGrammar1317 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_synpred7_TigerGrammar1387 = new BitSet(new ulong[]{0x2000000UL});
		public static readonly BitSet _L_PARENT_in_synpred7_TigerGrammar1389 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}
