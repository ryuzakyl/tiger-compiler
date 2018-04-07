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

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
[System.CLSCompliant(false)]
public partial class TigerGrammarLexer : Antlr.Runtime.Lexer
{
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

	public TigerGrammarLexer()
	{
		OnCreated();
	}

	public TigerGrammarLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public TigerGrammarLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_ARRAY();
	partial void Leave_ARRAY();

	// $ANTLR start "ARRAY"
	[GrammarRule("ARRAY")]
	private void mARRAY()
	{
		Enter_ARRAY();
		EnterRule("ARRAY", 1);
		TraceIn("ARRAY", 1);
		try
		{
			int _type = ARRAY;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:7:7: ( 'array' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:7:9: 'array'
			{
			DebugLocation(7, 9);
			Match("array"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAY", 1);
			LeaveRule("ARRAY", 1);
			Leave_ARRAY();
		}
	}
	// $ANTLR end "ARRAY"

	partial void Enter_IF();
	partial void Leave_IF();

	// $ANTLR start "IF"
	[GrammarRule("IF")]
	private void mIF()
	{
		Enter_IF();
		EnterRule("IF", 2);
		TraceIn("IF", 2);
		try
		{
			int _type = IF;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:8:4: ( 'if' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:8:6: 'if'
			{
			DebugLocation(8, 6);
			Match("if"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IF", 2);
			LeaveRule("IF", 2);
			Leave_IF();
		}
	}
	// $ANTLR end "IF"

	partial void Enter_THEN();
	partial void Leave_THEN();

	// $ANTLR start "THEN"
	[GrammarRule("THEN")]
	private void mTHEN()
	{
		Enter_THEN();
		EnterRule("THEN", 3);
		TraceIn("THEN", 3);
		try
		{
			int _type = THEN;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:9:6: ( 'then' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:9:8: 'then'
			{
			DebugLocation(9, 8);
			Match("then"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("THEN", 3);
			LeaveRule("THEN", 3);
			Leave_THEN();
		}
	}
	// $ANTLR end "THEN"

	partial void Enter_ELSE();
	partial void Leave_ELSE();

	// $ANTLR start "ELSE"
	[GrammarRule("ELSE")]
	private void mELSE()
	{
		Enter_ELSE();
		EnterRule("ELSE", 4);
		TraceIn("ELSE", 4);
		try
		{
			int _type = ELSE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:10:6: ( 'else' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:10:8: 'else'
			{
			DebugLocation(10, 8);
			Match("else"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ELSE", 4);
			LeaveRule("ELSE", 4);
			Leave_ELSE();
		}
	}
	// $ANTLR end "ELSE"

	partial void Enter_WHILE();
	partial void Leave_WHILE();

	// $ANTLR start "WHILE"
	[GrammarRule("WHILE")]
	private void mWHILE()
	{
		Enter_WHILE();
		EnterRule("WHILE", 5);
		TraceIn("WHILE", 5);
		try
		{
			int _type = WHILE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:11:7: ( 'while' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:11:9: 'while'
			{
			DebugLocation(11, 9);
			Match("while"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHILE", 5);
			LeaveRule("WHILE", 5);
			Leave_WHILE();
		}
	}
	// $ANTLR end "WHILE"

	partial void Enter_FOR();
	partial void Leave_FOR();

	// $ANTLR start "FOR"
	[GrammarRule("FOR")]
	private void mFOR()
	{
		Enter_FOR();
		EnterRule("FOR", 6);
		TraceIn("FOR", 6);
		try
		{
			int _type = FOR;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:12:5: ( 'for' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:12:7: 'for'
			{
			DebugLocation(12, 7);
			Match("for"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FOR", 6);
			LeaveRule("FOR", 6);
			Leave_FOR();
		}
	}
	// $ANTLR end "FOR"

	partial void Enter_TO();
	partial void Leave_TO();

	// $ANTLR start "TO"
	[GrammarRule("TO")]
	private void mTO()
	{
		Enter_TO();
		EnterRule("TO", 7);
		TraceIn("TO", 7);
		try
		{
			int _type = TO;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:13:4: ( 'to' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:13:6: 'to'
			{
			DebugLocation(13, 6);
			Match("to"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TO", 7);
			LeaveRule("TO", 7);
			Leave_TO();
		}
	}
	// $ANTLR end "TO"

	partial void Enter_DO();
	partial void Leave_DO();

	// $ANTLR start "DO"
	[GrammarRule("DO")]
	private void mDO()
	{
		Enter_DO();
		EnterRule("DO", 8);
		TraceIn("DO", 8);
		try
		{
			int _type = DO;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:14:4: ( 'do' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:14:6: 'do'
			{
			DebugLocation(14, 6);
			Match("do"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DO", 8);
			LeaveRule("DO", 8);
			Leave_DO();
		}
	}
	// $ANTLR end "DO"

	partial void Enter_LET();
	partial void Leave_LET();

	// $ANTLR start "LET"
	[GrammarRule("LET")]
	private void mLET()
	{
		Enter_LET();
		EnterRule("LET", 9);
		TraceIn("LET", 9);
		try
		{
			int _type = LET;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:15:5: ( 'let' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:15:7: 'let'
			{
			DebugLocation(15, 7);
			Match("let"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LET", 9);
			LeaveRule("LET", 9);
			Leave_LET();
		}
	}
	// $ANTLR end "LET"

	partial void Enter_IN();
	partial void Leave_IN();

	// $ANTLR start "IN"
	[GrammarRule("IN")]
	private void mIN()
	{
		Enter_IN();
		EnterRule("IN", 10);
		TraceIn("IN", 10);
		try
		{
			int _type = IN;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:16:4: ( 'in' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:16:6: 'in'
			{
			DebugLocation(16, 6);
			Match("in"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IN", 10);
			LeaveRule("IN", 10);
			Leave_IN();
		}
	}
	// $ANTLR end "IN"

	partial void Enter_END();
	partial void Leave_END();

	// $ANTLR start "END"
	[GrammarRule("END")]
	private void mEND()
	{
		Enter_END();
		EnterRule("END", 11);
		TraceIn("END", 11);
		try
		{
			int _type = END;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:17:5: ( 'end' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:17:7: 'end'
			{
			DebugLocation(17, 7);
			Match("end"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("END", 11);
			LeaveRule("END", 11);
			Leave_END();
		}
	}
	// $ANTLR end "END"

	partial void Enter_OF();
	partial void Leave_OF();

	// $ANTLR start "OF"
	[GrammarRule("OF")]
	private void mOF()
	{
		Enter_OF();
		EnterRule("OF", 12);
		TraceIn("OF", 12);
		try
		{
			int _type = OF;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:18:4: ( 'of' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:18:6: 'of'
			{
			DebugLocation(18, 6);
			Match("of"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OF", 12);
			LeaveRule("OF", 12);
			Leave_OF();
		}
	}
	// $ANTLR end "OF"

	partial void Enter_BREAK();
	partial void Leave_BREAK();

	// $ANTLR start "BREAK"
	[GrammarRule("BREAK")]
	private void mBREAK()
	{
		Enter_BREAK();
		EnterRule("BREAK", 13);
		TraceIn("BREAK", 13);
		try
		{
			int _type = BREAK;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:19:7: ( 'break' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:19:9: 'break'
			{
			DebugLocation(19, 9);
			Match("break"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BREAK", 13);
			LeaveRule("BREAK", 13);
			Leave_BREAK();
		}
	}
	// $ANTLR end "BREAK"

	partial void Enter_NIL();
	partial void Leave_NIL();

	// $ANTLR start "NIL"
	[GrammarRule("NIL")]
	private void mNIL()
	{
		Enter_NIL();
		EnterRule("NIL", 14);
		TraceIn("NIL", 14);
		try
		{
			int _type = NIL;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:20:5: ( 'nil' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:20:7: 'nil'
			{
			DebugLocation(20, 7);
			Match("nil"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NIL", 14);
			LeaveRule("NIL", 14);
			Leave_NIL();
		}
	}
	// $ANTLR end "NIL"

	partial void Enter_FUNCTION();
	partial void Leave_FUNCTION();

	// $ANTLR start "FUNCTION"
	[GrammarRule("FUNCTION")]
	private void mFUNCTION()
	{
		Enter_FUNCTION();
		EnterRule("FUNCTION", 15);
		TraceIn("FUNCTION", 15);
		try
		{
			int _type = FUNCTION;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:21:10: ( 'function' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:21:12: 'function'
			{
			DebugLocation(21, 12);
			Match("function"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FUNCTION", 15);
			LeaveRule("FUNCTION", 15);
			Leave_FUNCTION();
		}
	}
	// $ANTLR end "FUNCTION"

	partial void Enter_VAR();
	partial void Leave_VAR();

	// $ANTLR start "VAR"
	[GrammarRule("VAR")]
	private void mVAR()
	{
		Enter_VAR();
		EnterRule("VAR", 16);
		TraceIn("VAR", 16);
		try
		{
			int _type = VAR;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:22:5: ( 'var' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:22:7: 'var'
			{
			DebugLocation(22, 7);
			Match("var"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VAR", 16);
			LeaveRule("VAR", 16);
			Leave_VAR();
		}
	}
	// $ANTLR end "VAR"

	partial void Enter_TYPE();
	partial void Leave_TYPE();

	// $ANTLR start "TYPE"
	[GrammarRule("TYPE")]
	private void mTYPE()
	{
		Enter_TYPE();
		EnterRule("TYPE", 17);
		TraceIn("TYPE", 17);
		try
		{
			int _type = TYPE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:23:6: ( 'type' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:23:8: 'type'
			{
			DebugLocation(23, 8);
			Match("type"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TYPE", 17);
			LeaveRule("TYPE", 17);
			Leave_TYPE();
		}
	}
	// $ANTLR end "TYPE"

	partial void Enter_DOT();
	partial void Leave_DOT();

	// $ANTLR start "DOT"
	[GrammarRule("DOT")]
	private void mDOT()
	{
		Enter_DOT();
		EnterRule("DOT", 18);
		TraceIn("DOT", 18);
		try
		{
			int _type = DOT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:24:5: ( '.' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:24:7: '.'
			{
			DebugLocation(24, 7);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOT", 18);
			LeaveRule("DOT", 18);
			Leave_DOT();
		}
	}
	// $ANTLR end "DOT"

	partial void Enter_COMMA();
	partial void Leave_COMMA();

	// $ANTLR start "COMMA"
	[GrammarRule("COMMA")]
	private void mCOMMA()
	{
		Enter_COMMA();
		EnterRule("COMMA", 19);
		TraceIn("COMMA", 19);
		try
		{
			int _type = COMMA;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:25:7: ( ',' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:25:9: ','
			{
			DebugLocation(25, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COMMA", 19);
			LeaveRule("COMMA", 19);
			Leave_COMMA();
		}
	}
	// $ANTLR end "COMMA"

	partial void Enter_COLON();
	partial void Leave_COLON();

	// $ANTLR start "COLON"
	[GrammarRule("COLON")]
	private void mCOLON()
	{
		Enter_COLON();
		EnterRule("COLON", 20);
		TraceIn("COLON", 20);
		try
		{
			int _type = COLON;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:26:7: ( ':' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:26:9: ':'
			{
			DebugLocation(26, 9);
			Match(':'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COLON", 20);
			LeaveRule("COLON", 20);
			Leave_COLON();
		}
	}
	// $ANTLR end "COLON"

	partial void Enter_SEMICOLON();
	partial void Leave_SEMICOLON();

	// $ANTLR start "SEMICOLON"
	[GrammarRule("SEMICOLON")]
	private void mSEMICOLON()
	{
		Enter_SEMICOLON();
		EnterRule("SEMICOLON", 21);
		TraceIn("SEMICOLON", 21);
		try
		{
			int _type = SEMICOLON;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:27:11: ( ';' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:27:13: ';'
			{
			DebugLocation(27, 13);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SEMICOLON", 21);
			LeaveRule("SEMICOLON", 21);
			Leave_SEMICOLON();
		}
	}
	// $ANTLR end "SEMICOLON"

	partial void Enter_L_PARENT();
	partial void Leave_L_PARENT();

	// $ANTLR start "L_PARENT"
	[GrammarRule("L_PARENT")]
	private void mL_PARENT()
	{
		Enter_L_PARENT();
		EnterRule("L_PARENT", 22);
		TraceIn("L_PARENT", 22);
		try
		{
			int _type = L_PARENT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:28:10: ( '(' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:28:12: '('
			{
			DebugLocation(28, 12);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("L_PARENT", 22);
			LeaveRule("L_PARENT", 22);
			Leave_L_PARENT();
		}
	}
	// $ANTLR end "L_PARENT"

	partial void Enter_R_PARENT();
	partial void Leave_R_PARENT();

	// $ANTLR start "R_PARENT"
	[GrammarRule("R_PARENT")]
	private void mR_PARENT()
	{
		Enter_R_PARENT();
		EnterRule("R_PARENT", 23);
		TraceIn("R_PARENT", 23);
		try
		{
			int _type = R_PARENT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:29:10: ( ')' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:29:12: ')'
			{
			DebugLocation(29, 12);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("R_PARENT", 23);
			LeaveRule("R_PARENT", 23);
			Leave_R_PARENT();
		}
	}
	// $ANTLR end "R_PARENT"

	partial void Enter_L_BRACKET();
	partial void Leave_L_BRACKET();

	// $ANTLR start "L_BRACKET"
	[GrammarRule("L_BRACKET")]
	private void mL_BRACKET()
	{
		Enter_L_BRACKET();
		EnterRule("L_BRACKET", 24);
		TraceIn("L_BRACKET", 24);
		try
		{
			int _type = L_BRACKET;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:30:11: ( '[' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:30:13: '['
			{
			DebugLocation(30, 13);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("L_BRACKET", 24);
			LeaveRule("L_BRACKET", 24);
			Leave_L_BRACKET();
		}
	}
	// $ANTLR end "L_BRACKET"

	partial void Enter_R_BRACKET();
	partial void Leave_R_BRACKET();

	// $ANTLR start "R_BRACKET"
	[GrammarRule("R_BRACKET")]
	private void mR_BRACKET()
	{
		Enter_R_BRACKET();
		EnterRule("R_BRACKET", 25);
		TraceIn("R_BRACKET", 25);
		try
		{
			int _type = R_BRACKET;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:31:11: ( ']' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:31:13: ']'
			{
			DebugLocation(31, 13);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("R_BRACKET", 25);
			LeaveRule("R_BRACKET", 25);
			Leave_R_BRACKET();
		}
	}
	// $ANTLR end "R_BRACKET"

	partial void Enter_L_BRACE();
	partial void Leave_L_BRACE();

	// $ANTLR start "L_BRACE"
	[GrammarRule("L_BRACE")]
	private void mL_BRACE()
	{
		Enter_L_BRACE();
		EnterRule("L_BRACE", 26);
		TraceIn("L_BRACE", 26);
		try
		{
			int _type = L_BRACE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:32:9: ( '{' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:32:11: '{'
			{
			DebugLocation(32, 11);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("L_BRACE", 26);
			LeaveRule("L_BRACE", 26);
			Leave_L_BRACE();
		}
	}
	// $ANTLR end "L_BRACE"

	partial void Enter_R_BRACE();
	partial void Leave_R_BRACE();

	// $ANTLR start "R_BRACE"
	[GrammarRule("R_BRACE")]
	private void mR_BRACE()
	{
		Enter_R_BRACE();
		EnterRule("R_BRACE", 27);
		TraceIn("R_BRACE", 27);
		try
		{
			int _type = R_BRACE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:33:9: ( '}' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:33:11: '}'
			{
			DebugLocation(33, 11);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("R_BRACE", 27);
			LeaveRule("R_BRACE", 27);
			Leave_R_BRACE();
		}
	}
	// $ANTLR end "R_BRACE"

	partial void Enter_PLUS();
	partial void Leave_PLUS();

	// $ANTLR start "PLUS"
	[GrammarRule("PLUS")]
	private void mPLUS()
	{
		Enter_PLUS();
		EnterRule("PLUS", 28);
		TraceIn("PLUS", 28);
		try
		{
			int _type = PLUS;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:34:6: ( '+' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:34:8: '+'
			{
			DebugLocation(34, 8);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PLUS", 28);
			LeaveRule("PLUS", 28);
			Leave_PLUS();
		}
	}
	// $ANTLR end "PLUS"

	partial void Enter_MINUS();
	partial void Leave_MINUS();

	// $ANTLR start "MINUS"
	[GrammarRule("MINUS")]
	private void mMINUS()
	{
		Enter_MINUS();
		EnterRule("MINUS", 29);
		TraceIn("MINUS", 29);
		try
		{
			int _type = MINUS;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:35:7: ( '-' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:35:9: '-'
			{
			DebugLocation(35, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MINUS", 29);
			LeaveRule("MINUS", 29);
			Leave_MINUS();
		}
	}
	// $ANTLR end "MINUS"

	partial void Enter_MULT();
	partial void Leave_MULT();

	// $ANTLR start "MULT"
	[GrammarRule("MULT")]
	private void mMULT()
	{
		Enter_MULT();
		EnterRule("MULT", 30);
		TraceIn("MULT", 30);
		try
		{
			int _type = MULT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:36:6: ( '*' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:36:8: '*'
			{
			DebugLocation(36, 8);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MULT", 30);
			LeaveRule("MULT", 30);
			Leave_MULT();
		}
	}
	// $ANTLR end "MULT"

	partial void Enter_DIV();
	partial void Leave_DIV();

	// $ANTLR start "DIV"
	[GrammarRule("DIV")]
	private void mDIV()
	{
		Enter_DIV();
		EnterRule("DIV", 31);
		TraceIn("DIV", 31);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:37:5: ( '/' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:37:7: '/'
			{
			DebugLocation(37, 7);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 31);
			LeaveRule("DIV", 31);
			Leave_DIV();
		}
	}
	// $ANTLR end "DIV"

	partial void Enter_EQUALS();
	partial void Leave_EQUALS();

	// $ANTLR start "EQUALS"
	[GrammarRule("EQUALS")]
	private void mEQUALS()
	{
		Enter_EQUALS();
		EnterRule("EQUALS", 32);
		TraceIn("EQUALS", 32);
		try
		{
			int _type = EQUALS;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:38:8: ( '=' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:38:10: '='
			{
			DebugLocation(38, 10);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQUALS", 32);
			LeaveRule("EQUALS", 32);
			Leave_EQUALS();
		}
	}
	// $ANTLR end "EQUALS"

	partial void Enter_NOT_EQUALS();
	partial void Leave_NOT_EQUALS();

	// $ANTLR start "NOT_EQUALS"
	[GrammarRule("NOT_EQUALS")]
	private void mNOT_EQUALS()
	{
		Enter_NOT_EQUALS();
		EnterRule("NOT_EQUALS", 33);
		TraceIn("NOT_EQUALS", 33);
		try
		{
			int _type = NOT_EQUALS;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:39:12: ( '<>' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:39:14: '<>'
			{
			DebugLocation(39, 14);
			Match("<>"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOT_EQUALS", 33);
			LeaveRule("NOT_EQUALS", 33);
			Leave_NOT_EQUALS();
		}
	}
	// $ANTLR end "NOT_EQUALS"

	partial void Enter_LESS();
	partial void Leave_LESS();

	// $ANTLR start "LESS"
	[GrammarRule("LESS")]
	private void mLESS()
	{
		Enter_LESS();
		EnterRule("LESS", 34);
		TraceIn("LESS", 34);
		try
		{
			int _type = LESS;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:40:6: ( '<' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:40:8: '<'
			{
			DebugLocation(40, 8);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LESS", 34);
			LeaveRule("LESS", 34);
			Leave_LESS();
		}
	}
	// $ANTLR end "LESS"

	partial void Enter_LESS_EQUALS();
	partial void Leave_LESS_EQUALS();

	// $ANTLR start "LESS_EQUALS"
	[GrammarRule("LESS_EQUALS")]
	private void mLESS_EQUALS()
	{
		Enter_LESS_EQUALS();
		EnterRule("LESS_EQUALS", 35);
		TraceIn("LESS_EQUALS", 35);
		try
		{
			int _type = LESS_EQUALS;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:41:13: ( '<=' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:41:15: '<='
			{
			DebugLocation(41, 15);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LESS_EQUALS", 35);
			LeaveRule("LESS_EQUALS", 35);
			Leave_LESS_EQUALS();
		}
	}
	// $ANTLR end "LESS_EQUALS"

	partial void Enter_GREATER();
	partial void Leave_GREATER();

	// $ANTLR start "GREATER"
	[GrammarRule("GREATER")]
	private void mGREATER()
	{
		Enter_GREATER();
		EnterRule("GREATER", 36);
		TraceIn("GREATER", 36);
		try
		{
			int _type = GREATER;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:42:9: ( '>' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:42:11: '>'
			{
			DebugLocation(42, 11);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREATER", 36);
			LeaveRule("GREATER", 36);
			Leave_GREATER();
		}
	}
	// $ANTLR end "GREATER"

	partial void Enter_GREATER_EQUALS();
	partial void Leave_GREATER_EQUALS();

	// $ANTLR start "GREATER_EQUALS"
	[GrammarRule("GREATER_EQUALS")]
	private void mGREATER_EQUALS()
	{
		Enter_GREATER_EQUALS();
		EnterRule("GREATER_EQUALS", 37);
		TraceIn("GREATER_EQUALS", 37);
		try
		{
			int _type = GREATER_EQUALS;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:43:16: ( '>=' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:43:18: '>='
			{
			DebugLocation(43, 18);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREATER_EQUALS", 37);
			LeaveRule("GREATER_EQUALS", 37);
			Leave_GREATER_EQUALS();
		}
	}
	// $ANTLR end "GREATER_EQUALS"

	partial void Enter_AND();
	partial void Leave_AND();

	// $ANTLR start "AND"
	[GrammarRule("AND")]
	private void mAND()
	{
		Enter_AND();
		EnterRule("AND", 38);
		TraceIn("AND", 38);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:44:5: ( '&' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:44:7: '&'
			{
			DebugLocation(44, 7);
			Match('&'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 38);
			LeaveRule("AND", 38);
			Leave_AND();
		}
	}
	// $ANTLR end "AND"

	partial void Enter_OR();
	partial void Leave_OR();

	// $ANTLR start "OR"
	[GrammarRule("OR")]
	private void mOR()
	{
		Enter_OR();
		EnterRule("OR", 39);
		TraceIn("OR", 39);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:45:4: ( '|' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:45:6: '|'
			{
			DebugLocation(45, 6);
			Match('|'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 39);
			LeaveRule("OR", 39);
			Leave_OR();
		}
	}
	// $ANTLR end "OR"

	partial void Enter_ASSIGN();
	partial void Leave_ASSIGN();

	// $ANTLR start "ASSIGN"
	[GrammarRule("ASSIGN")]
	private void mASSIGN()
	{
		Enter_ASSIGN();
		EnterRule("ASSIGN", 40);
		TraceIn("ASSIGN", 40);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:46:8: ( ':=' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:46:10: ':='
			{
			DebugLocation(46, 10);
			Match(":="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 40);
			LeaveRule("ASSIGN", 40);
			Leave_ASSIGN();
		}
	}
	// $ANTLR end "ASSIGN"

	partial void Enter_OPEN_COMMENT();
	partial void Leave_OPEN_COMMENT();

	// $ANTLR start "OPEN_COMMENT"
	[GrammarRule("OPEN_COMMENT")]
	private void mOPEN_COMMENT()
	{
		Enter_OPEN_COMMENT();
		EnterRule("OPEN_COMMENT", 41);
		TraceIn("OPEN_COMMENT", 41);
		try
		{
			int _type = OPEN_COMMENT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:47:14: ( '/*' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:47:16: '/*'
			{
			DebugLocation(47, 16);
			Match("/*"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OPEN_COMMENT", 41);
			LeaveRule("OPEN_COMMENT", 41);
			Leave_OPEN_COMMENT();
		}
	}
	// $ANTLR end "OPEN_COMMENT"

	partial void Enter_CLOSE_COMMENT();
	partial void Leave_CLOSE_COMMENT();

	// $ANTLR start "CLOSE_COMMENT"
	[GrammarRule("CLOSE_COMMENT")]
	private void mCLOSE_COMMENT()
	{
		Enter_CLOSE_COMMENT();
		EnterRule("CLOSE_COMMENT", 42);
		TraceIn("CLOSE_COMMENT", 42);
		try
		{
			int _type = CLOSE_COMMENT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:48:15: ( '*/' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:48:17: '*/'
			{
			DebugLocation(48, 17);
			Match("*/"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CLOSE_COMMENT", 42);
			LeaveRule("CLOSE_COMMENT", 42);
			Leave_CLOSE_COMMENT();
		}
	}
	// $ANTLR end "CLOSE_COMMENT"

	partial void Enter_ID();
	partial void Leave_ID();

	// $ANTLR start "ID"
	[GrammarRule("ID")]
	private void mID()
	{
		Enter_ID();
		EnterRule("ID", 43);
		TraceIn("ID", 43);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:266:2: ( LETTER ( LETTER | DEC_DIGIT | '_' )* )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:267:3: LETTER ( LETTER | DEC_DIGIT | '_' )*
			{
			DebugLocation(267, 3);
			mLETTER(); 
			DebugLocation(267, 10);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:267:10: ( LETTER | DEC_DIGIT | '_' )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=4;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				switch (input.LA(1))
				{
				case 'A':
				case 'B':
				case 'C':
				case 'D':
				case 'E':
				case 'F':
				case 'G':
				case 'H':
				case 'I':
				case 'J':
				case 'K':
				case 'L':
				case 'M':
				case 'N':
				case 'O':
				case 'P':
				case 'Q':
				case 'R':
				case 'S':
				case 'T':
				case 'U':
				case 'V':
				case 'W':
				case 'X':
				case 'Y':
				case 'Z':
				case 'a':
				case 'b':
				case 'c':
				case 'd':
				case 'e':
				case 'f':
				case 'g':
				case 'h':
				case 'i':
				case 'j':
				case 'k':
				case 'l':
				case 'm':
				case 'n':
				case 'o':
				case 'p':
				case 'q':
				case 'r':
				case 's':
				case 't':
				case 'u':
				case 'v':
				case 'w':
				case 'x':
				case 'y':
				case 'z':
					{
					alt1=1;
					}
					break;
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
					{
					alt1=2;
					}
					break;
				case '_':
					{
					alt1=3;
					}
					break;

				}

				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:267:11: LETTER
					{
					DebugLocation(267, 11);
					mLETTER(); 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:267:20: DEC_DIGIT
					{
					DebugLocation(267, 20);
					mDEC_DIGIT(); 

					}
					break;
				case 3:
					DebugEnterAlt(3);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:267:32: '_'
					{
					DebugLocation(267, 32);
					Match('_'); 

					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ID", 43);
			LeaveRule("ID", 43);
			Leave_ID();
		}
	}
	// $ANTLR end "ID"

	partial void Enter_LETTER();
	partial void Leave_LETTER();

	// $ANTLR start "LETTER"
	[GrammarRule("LETTER")]
	private void mLETTER()
	{
		Enter_LETTER();
		EnterRule("LETTER", 44);
		TraceIn("LETTER", 44);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:272:2: ( ( 'a' .. 'z' | 'A' .. 'Z' ) )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:273:3: ( 'a' .. 'z' | 'A' .. 'Z' )
			{
			DebugLocation(273, 3);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}


			}

		}
		finally
		{
			TraceOut("LETTER", 44);
			LeaveRule("LETTER", 44);
			Leave_LETTER();
		}
	}
	// $ANTLR end "LETTER"

	partial void Enter_INT();
	partial void Leave_INT();

	// $ANTLR start "INT"
	[GrammarRule("INT")]
	private void mINT()
	{
		Enter_INT();
		EnterRule("INT", 45);
		TraceIn("INT", 45);
		try
		{
			int _type = INT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:278:2: ( ( DEC_DIGIT )+ )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:279:3: ( DEC_DIGIT )+
			{
			DebugLocation(279, 3);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:279:3: ( DEC_DIGIT )+
			int cnt2=0;
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if (((LA2_0>='0' && LA2_0<='9')))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch (alt2)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:279:3: DEC_DIGIT
					{
					DebugLocation(279, 3);
					mDEC_DIGIT(); 

					}
					break;

				default:
					if (cnt2 >= 1)
						goto loop2;

					EarlyExitException eee2 = new EarlyExitException( 2, input );
					DebugRecognitionException(eee2);
					throw eee2;
				}
				cnt2++;
			}
			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INT", 45);
			LeaveRule("INT", 45);
			Leave_INT();
		}
	}
	// $ANTLR end "INT"

	partial void Enter_COMMENT();
	partial void Leave_COMMENT();

	// $ANTLR start "COMMENT"
	[GrammarRule("COMMENT")]
	private void mCOMMENT()
	{
		Enter_COMMENT();
		EnterRule("COMMENT", 46);
		TraceIn("COMMENT", 46);
		try
		{
			int _type = COMMENT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:284:2: ( OPEN_COMMENT ( options {greedy=false; } : COMMENT | . )* CLOSE_COMMENT )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:285:7: OPEN_COMMENT ( options {greedy=false; } : COMMENT | . )* CLOSE_COMMENT
			{
			DebugLocation(285, 7);
			mOPEN_COMMENT(); 
			DebugLocation(285, 20);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:285:20: ( options {greedy=false; } : COMMENT | . )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=3;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if ((LA3_0=='*'))
				{
					int LA3_1 = input.LA(2);

					if ((LA3_1=='/'))
					{
						alt3=3;
					}
					else if (((LA3_1>='\u0000' && LA3_1<='.')||(LA3_1>='0' && LA3_1<='\uFFFF')))
					{
						alt3=2;
					}


				}
				else if ((LA3_0=='/'))
				{
					int LA3_2 = input.LA(2);

					if ((LA3_2=='*'))
					{
						alt3=1;
					}
					else if (((LA3_2>='\u0000' && LA3_2<=')')||(LA3_2>='+' && LA3_2<='\uFFFF')))
					{
						alt3=2;
					}


				}
				else if (((LA3_0>='\u0000' && LA3_0<=')')||(LA3_0>='+' && LA3_0<='.')||(LA3_0>='0' && LA3_0<='\uFFFF')))
				{
					alt3=2;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:285:48: COMMENT
					{
					DebugLocation(285, 48);
					mCOMMENT(); 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:285:58: .
					{
					DebugLocation(285, 58);
					MatchAny(); 

					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }

			DebugLocation(285, 63);
			mCLOSE_COMMENT(); 
			DebugLocation(285, 77);
			_channel = Hidden;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COMMENT", 46);
			LeaveRule("COMMENT", 46);
			Leave_COMMENT();
		}
	}
	// $ANTLR end "COMMENT"

	partial void Enter_WS();
	partial void Leave_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		Enter_WS();
		EnterRule("WS", 47);
		TraceIn("WS", 47);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:290:2: ( ( ' ' | '\\t' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:291:3: ( ' ' | '\\t' | '\\r' | '\\n' )+
			{
			DebugLocation(291, 3);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:291:3: ( ' ' | '\\t' | '\\r' | '\\n' )+
			int cnt4=0;
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if (((LA4_0>='\t' && LA4_0<='\n')||LA4_0=='\r'||LA4_0==' '))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch (alt4)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:
					{
					DebugLocation(291, 3);
					if ((input.LA(1)>='\t' && input.LA(1)<='\n')||input.LA(1)=='\r'||input.LA(1)==' ')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					if (cnt4 >= 1)
						goto loop4;

					EarlyExitException eee4 = new EarlyExitException( 4, input );
					DebugRecognitionException(eee4);
					throw eee4;
				}
				cnt4++;
			}
			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(291, 32);
			_channel = Hidden;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 47);
			LeaveRule("WS", 47);
			Leave_WS();
		}
	}
	// $ANTLR end "WS"

	partial void Enter_STRING();
	partial void Leave_STRING();

	// $ANTLR start "STRING"
	[GrammarRule("STRING")]
	private void mSTRING()
	{
		Enter_STRING();
		EnterRule("STRING", 48);
		TraceIn("STRING", 48);
		try
		{
			int _type = STRING;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:295:6: ( '\"' ( ESC_SEQ | ~ ( '\\\\' | '\"' ) )* '\"' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:296:7: '\"' ( ESC_SEQ | ~ ( '\\\\' | '\"' ) )* '\"'
			{
			DebugLocation(296, 7);
			Match('\"'); 
			DebugLocation(296, 11);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:296:11: ( ESC_SEQ | ~ ( '\\\\' | '\"' ) )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=3;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if ((LA5_0=='\\'))
				{
					alt5=1;
				}
				else if (((LA5_0>='\u0000' && LA5_0<='!')||(LA5_0>='#' && LA5_0<='[')||(LA5_0>=']' && LA5_0<='\uFFFF')))
				{
					alt5=2;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:296:13: ESC_SEQ
					{
					DebugLocation(296, 13);
					mESC_SEQ(); 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:296:23: ~ ( '\\\\' | '\"' )
					{
					DebugLocation(296, 23);
					if ((input.LA(1)>='\u0000' && input.LA(1)<='!')||(input.LA(1)>='#' && input.LA(1)<='[')||(input.LA(1)>=']' && input.LA(1)<='\uFFFF'))
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop5;
				}
			}

			loop5:
				;

			} finally { DebugExitSubRule(5); }

			DebugLocation(296, 40);
			Match('\"'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STRING", 48);
			LeaveRule("STRING", 48);
			Leave_STRING();
		}
	}
	// $ANTLR end "STRING"

	partial void Enter_DEC_DIGIT();
	partial void Leave_DEC_DIGIT();

	// $ANTLR start "DEC_DIGIT"
	[GrammarRule("DEC_DIGIT")]
	private void mDEC_DIGIT()
	{
		Enter_DEC_DIGIT();
		EnterRule("DEC_DIGIT", 49);
		TraceIn("DEC_DIGIT", 49);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:301:2: ( ( '0' .. '9' ) )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:302:3: ( '0' .. '9' )
			{
			DebugLocation(302, 3);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:302:3: ( '0' .. '9' )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:302:4: '0' .. '9'
			{
			DebugLocation(302, 4);
			MatchRange('0','9'); 

			}


			}

		}
		finally
		{
			TraceOut("DEC_DIGIT", 49);
			LeaveRule("DEC_DIGIT", 49);
			Leave_DEC_DIGIT();
		}
	}
	// $ANTLR end "DEC_DIGIT"

	partial void Enter_HEX_DIGIT();
	partial void Leave_HEX_DIGIT();

	// $ANTLR start "HEX_DIGIT"
	[GrammarRule("HEX_DIGIT")]
	private void mHEX_DIGIT()
	{
		Enter_HEX_DIGIT();
		EnterRule("HEX_DIGIT", 50);
		TraceIn("HEX_DIGIT", 50);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:307:2: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:308:3: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
			{
			DebugLocation(308, 3);
			if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='F')||(input.LA(1)>='a' && input.LA(1)<='f'))
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}


			}

		}
		finally
		{
			TraceOut("HEX_DIGIT", 50);
			LeaveRule("HEX_DIGIT", 50);
			Leave_HEX_DIGIT();
		}
	}
	// $ANTLR end "HEX_DIGIT"

	partial void Enter_ESC_SEQ();
	partial void Leave_ESC_SEQ();

	// $ANTLR start "ESC_SEQ"
	[GrammarRule("ESC_SEQ")]
	private void mESC_SEQ()
	{
		Enter_ESC_SEQ();
		EnterRule("ESC_SEQ", 51);
		TraceIn("ESC_SEQ", 51);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:313:6: ( '\\\\' ( 'n' | 't' | 'r' | '\"' | '\\\\' | '^' ( '@' .. '_' ) | ASCII_ESC | ( WS )+ '\\\\' ) )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:314:7: '\\\\' ( 'n' | 't' | 'r' | '\"' | '\\\\' | '^' ( '@' .. '_' ) | ASCII_ESC | ( WS )+ '\\\\' )
			{
			DebugLocation(314, 7);
			Match('\\'); 
			DebugLocation(315, 7);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:315:7: ( 'n' | 't' | 'r' | '\"' | '\\\\' | '^' ( '@' .. '_' ) | ASCII_ESC | ( WS )+ '\\\\' )
			int alt7=8;
			try { DebugEnterSubRule(7);
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			switch (input.LA(1))
			{
			case 'n':
				{
				alt7=1;
				}
				break;
			case 't':
				{
				alt7=2;
				}
				break;
			case 'r':
				{
				alt7=3;
				}
				break;
			case '\"':
				{
				alt7=4;
				}
				break;
			case '\\':
				{
				alt7=5;
				}
				break;
			case '^':
				{
				alt7=6;
				}
				break;
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
				{
				alt7=7;
				}
				break;
			case '\t':
			case '\n':
			case '\r':
			case ' ':
				{
				alt7=8;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 7, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:315:8: 'n'
				{
				DebugLocation(315, 8);
				Match('n'); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:316:8: 't'
				{
				DebugLocation(316, 8);
				Match('t'); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:317:8: 'r'
				{
				DebugLocation(317, 8);
				Match('r'); 

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:318:8: '\"'
				{
				DebugLocation(318, 8);
				Match('\"'); 

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:319:8: '\\\\'
				{
				DebugLocation(319, 8);
				Match('\\'); 

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:320:8: '^' ( '@' .. '_' )
				{
				DebugLocation(320, 8);
				Match('^'); 
				DebugLocation(320, 11);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:320:11: ( '@' .. '_' )
				DebugEnterAlt(1);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:320:12: '@' .. '_'
				{
				DebugLocation(320, 12);
				MatchRange('@','_'); 

				}


				}
				break;
			case 7:
				DebugEnterAlt(7);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:321:8: ASCII_ESC
				{
				DebugLocation(321, 8);
				mASCII_ESC(); 

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:322:8: ( WS )+ '\\\\'
				{
				DebugLocation(322, 8);
				// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:322:8: ( WS )+
				int cnt6=0;
				try { DebugEnterSubRule(6);
				while (true)
				{
					int alt6=2;
					try { DebugEnterDecision(6, decisionCanBacktrack[6]);
					int LA6_0 = input.LA(1);

					if (((LA6_0>='\t' && LA6_0<='\n')||LA6_0=='\r'||LA6_0==' '))
					{
						alt6=1;
					}


					} finally { DebugExitDecision(6); }
					switch (alt6)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:322:9: WS
						{
						DebugLocation(322, 9);
						mWS(); 

						}
						break;

					default:
						if (cnt6 >= 1)
							goto loop6;

						EarlyExitException eee6 = new EarlyExitException( 6, input );
						DebugRecognitionException(eee6);
						throw eee6;
					}
					cnt6++;
				}
				loop6:
					;

				} finally { DebugExitSubRule(6); }

				DebugLocation(322, 14);
				Match('\\'); 

				}
				break;

			}
			} finally { DebugExitSubRule(7); }


			}

		}
		finally
		{
			TraceOut("ESC_SEQ", 51);
			LeaveRule("ESC_SEQ", 51);
			Leave_ESC_SEQ();
		}
	}
	// $ANTLR end "ESC_SEQ"

	partial void Enter_ASCII_ESC();
	partial void Leave_ASCII_ESC();

	// $ANTLR start "ASCII_ESC"
	[GrammarRule("ASCII_ESC")]
	private void mASCII_ESC()
	{
		Enter_ASCII_ESC();
		EnterRule("ASCII_ESC", 52);
		TraceIn("ASCII_ESC", 52);
		try
		{
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:328:2: ( DEC_DIGIT DEC_DIGIT DEC_DIGIT )
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:329:3: DEC_DIGIT DEC_DIGIT DEC_DIGIT
			{
			DebugLocation(329, 3);
			mDEC_DIGIT(); 
			DebugLocation(329, 13);
			mDEC_DIGIT(); 
			DebugLocation(329, 23);
			mDEC_DIGIT(); 

			}

		}
		finally
		{
			TraceOut("ASCII_ESC", 52);
			LeaveRule("ASCII_ESC", 52);
			Leave_ASCII_ESC();
		}
	}
	// $ANTLR end "ASCII_ESC"

	public override void mTokens()
	{
		// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:8: ( ARRAY | IF | THEN | ELSE | WHILE | FOR | TO | DO | LET | IN | END | OF | BREAK | NIL | FUNCTION | VAR | TYPE | DOT | COMMA | COLON | SEMICOLON | L_PARENT | R_PARENT | L_BRACKET | R_BRACKET | L_BRACE | R_BRACE | PLUS | MINUS | MULT | DIV | EQUALS | NOT_EQUALS | LESS | LESS_EQUALS | GREATER | GREATER_EQUALS | AND | OR | ASSIGN | OPEN_COMMENT | CLOSE_COMMENT | ID | INT | COMMENT | WS | STRING )
		int alt8=47;
		try { DebugEnterDecision(8, decisionCanBacktrack[8]);
		try
		{
			alt8 = dfa8.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(8); }
		switch (alt8)
		{
		case 1:
			DebugEnterAlt(1);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:10: ARRAY
			{
			DebugLocation(1, 10);
			mARRAY(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:16: IF
			{
			DebugLocation(1, 16);
			mIF(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:19: THEN
			{
			DebugLocation(1, 19);
			mTHEN(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:24: ELSE
			{
			DebugLocation(1, 24);
			mELSE(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:29: WHILE
			{
			DebugLocation(1, 29);
			mWHILE(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:35: FOR
			{
			DebugLocation(1, 35);
			mFOR(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:39: TO
			{
			DebugLocation(1, 39);
			mTO(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:42: DO
			{
			DebugLocation(1, 42);
			mDO(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:45: LET
			{
			DebugLocation(1, 45);
			mLET(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:49: IN
			{
			DebugLocation(1, 49);
			mIN(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:52: END
			{
			DebugLocation(1, 52);
			mEND(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:56: OF
			{
			DebugLocation(1, 56);
			mOF(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:59: BREAK
			{
			DebugLocation(1, 59);
			mBREAK(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:65: NIL
			{
			DebugLocation(1, 65);
			mNIL(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:69: FUNCTION
			{
			DebugLocation(1, 69);
			mFUNCTION(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:78: VAR
			{
			DebugLocation(1, 78);
			mVAR(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:82: TYPE
			{
			DebugLocation(1, 82);
			mTYPE(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:87: DOT
			{
			DebugLocation(1, 87);
			mDOT(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:91: COMMA
			{
			DebugLocation(1, 91);
			mCOMMA(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:97: COLON
			{
			DebugLocation(1, 97);
			mCOLON(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:103: SEMICOLON
			{
			DebugLocation(1, 103);
			mSEMICOLON(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:113: L_PARENT
			{
			DebugLocation(1, 113);
			mL_PARENT(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:122: R_PARENT
			{
			DebugLocation(1, 122);
			mR_PARENT(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:131: L_BRACKET
			{
			DebugLocation(1, 131);
			mL_BRACKET(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:141: R_BRACKET
			{
			DebugLocation(1, 141);
			mR_BRACKET(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:151: L_BRACE
			{
			DebugLocation(1, 151);
			mL_BRACE(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:159: R_BRACE
			{
			DebugLocation(1, 159);
			mR_BRACE(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:167: PLUS
			{
			DebugLocation(1, 167);
			mPLUS(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:172: MINUS
			{
			DebugLocation(1, 172);
			mMINUS(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:178: MULT
			{
			DebugLocation(1, 178);
			mMULT(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:183: DIV
			{
			DebugLocation(1, 183);
			mDIV(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:187: EQUALS
			{
			DebugLocation(1, 187);
			mEQUALS(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:194: NOT_EQUALS
			{
			DebugLocation(1, 194);
			mNOT_EQUALS(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:205: LESS
			{
			DebugLocation(1, 205);
			mLESS(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:210: LESS_EQUALS
			{
			DebugLocation(1, 210);
			mLESS_EQUALS(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:222: GREATER
			{
			DebugLocation(1, 222);
			mGREATER(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:230: GREATER_EQUALS
			{
			DebugLocation(1, 230);
			mGREATER_EQUALS(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:245: AND
			{
			DebugLocation(1, 245);
			mAND(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:249: OR
			{
			DebugLocation(1, 249);
			mOR(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:252: ASSIGN
			{
			DebugLocation(1, 252);
			mASSIGN(); 

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:259: OPEN_COMMENT
			{
			DebugLocation(1, 259);
			mOPEN_COMMENT(); 

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:272: CLOSE_COMMENT
			{
			DebugLocation(1, 272);
			mCLOSE_COMMENT(); 

			}
			break;
		case 43:
			DebugEnterAlt(43);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:286: ID
			{
			DebugLocation(1, 286);
			mID(); 

			}
			break;
		case 44:
			DebugEnterAlt(44);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:289: INT
			{
			DebugLocation(1, 289);
			mINT(); 

			}
			break;
		case 45:
			DebugEnterAlt(45);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:293: COMMENT
			{
			DebugLocation(1, 293);
			mCOMMENT(); 

			}
			break;
		case 46:
			DebugEnterAlt(46);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:301: WS
			{
			DebugLocation(1, 301);
			mWS(); 

			}
			break;
		case 47:
			DebugEnterAlt(47);
			// C:\\Users\\Victor Manuel\\Desktop\\Projects\\GRAMMARS\\TigerGrammar.g:1:304: STRING
			{
			DebugLocation(1, 304);
			mSTRING(); 

			}
			break;

		}

	}


	#region DFA
	DFA8 dfa8;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa8 = new DFA8(this, SpecialStateTransition8);
	}

	private class DFA8 : DFA
	{
		private const string DFA8_eotS =
			"\x1\xFFFF\xC\x20\x2\xFFFF\x1\x36\x9\xFFFF\x1\x38\x1\x3A\x1\xFFFF\x1"+
			"\x3D\x1\x3F\x6\xFFFF\x1\x20\x1\x41\x1\x42\x1\x20\x1\x44\x6\x20\x1\x4B"+
			"\x1\x20\x1\x4D\x3\x20\x4\xFFFF\x1\x51\x6\xFFFF\x1\x20\x2\xFFFF\x1\x20"+
			"\x1\xFFFF\x2\x20\x1\x57\x1\x20\x1\x59\x1\x20\x1\xFFFF\x1\x5B\x1\xFFFF"+
			"\x1\x20\x1\x5D\x1\x5E\x2\xFFFF\x1\x20\x1\x60\x1\x61\x1\x62\x1\xFFFF\x1"+
			"\x20\x1\xFFFF\x1\x20\x1\xFFFF\x1\x20\x2\xFFFF\x1\x66\x3\xFFFF\x1\x67"+
			"\x1\x20\x1\x69\x2\xFFFF\x1\x20\x1\xFFFF\x1\x20\x1\x6C\x1\xFFFF";
		private const string DFA8_eofS =
			"\x6D\xFFFF";
		private const string DFA8_minS =
			"\x1\x9\x1\x72\x1\x66\x1\x68\x1\x6C\x1\x68\x2\x6F\x1\x65\x1\x66\x1\x72"+
			"\x1\x69\x1\x61\x2\xFFFF\x1\x3D\x9\xFFFF\x1\x2F\x1\x2A\x1\xFFFF\x2\x3D"+
			"\x6\xFFFF\x1\x72\x2\x30\x1\x65\x1\x30\x1\x70\x1\x73\x1\x64\x1\x69\x1"+
			"\x72\x1\x6E\x1\x30\x1\x74\x1\x30\x1\x65\x1\x6C\x1\x72\x4\xFFFF\x1\x0"+
			"\x6\xFFFF\x1\x61\x2\xFFFF\x1\x6E\x1\xFFFF\x2\x65\x1\x30\x1\x6C\x1\x30"+
			"\x1\x63\x1\xFFFF\x1\x30\x1\xFFFF\x1\x61\x2\x30\x2\xFFFF\x1\x79\x3\x30"+
			"\x1\xFFFF\x1\x65\x1\xFFFF\x1\x74\x1\xFFFF\x1\x6B\x2\xFFFF\x1\x30\x3\xFFFF"+
			"\x1\x30\x1\x69\x1\x30\x2\xFFFF\x1\x6F\x1\xFFFF\x1\x6E\x1\x30\x1\xFFFF";
		private const string DFA8_maxS =
			"\x1\x7D\x1\x72\x1\x6E\x1\x79\x1\x6E\x1\x68\x1\x75\x1\x6F\x1\x65\x1\x66"+
			"\x1\x72\x1\x69\x1\x61\x2\xFFFF\x1\x3D\x9\xFFFF\x1\x2F\x1\x2A\x1\xFFFF"+
			"\x1\x3E\x1\x3D\x6\xFFFF\x1\x72\x2\x7A\x1\x65\x1\x7A\x1\x70\x1\x73\x1"+
			"\x64\x1\x69\x1\x72\x1\x6E\x1\x7A\x1\x74\x1\x7A\x1\x65\x1\x6C\x1\x72\x4"+
			"\xFFFF\x1\xFFFF\x6\xFFFF\x1\x61\x2\xFFFF\x1\x6E\x1\xFFFF\x2\x65\x1\x7A"+
			"\x1\x6C\x1\x7A\x1\x63\x1\xFFFF\x1\x7A\x1\xFFFF\x1\x61\x2\x7A\x2\xFFFF"+
			"\x1\x79\x3\x7A\x1\xFFFF\x1\x65\x1\xFFFF\x1\x74\x1\xFFFF\x1\x6B\x2\xFFFF"+
			"\x1\x7A\x3\xFFFF\x1\x7A\x1\x69\x1\x7A\x2\xFFFF\x1\x6F\x1\xFFFF\x1\x6E"+
			"\x1\x7A\x1\xFFFF";
		private const string DFA8_acceptS =
			"\xD\xFFFF\x1\x12\x1\x13\x1\xFFFF\x1\x15\x1\x16\x1\x17\x1\x18\x1\x19"+
			"\x1\x1A\x1\x1B\x1\x1C\x1\x1D\x2\xFFFF\x1\x20\x2\xFFFF\x1\x26\x1\x27\x1"+
			"\x2B\x1\x2C\x1\x2E\x1\x2F\x11\xFFFF\x1\x28\x1\x14\x1\x2A\x1\x1E\x1\xFFFF"+
			"\x1\x1F\x1\x21\x1\x23\x1\x22\x1\x25\x1\x24\x1\xFFFF\x1\x2\x1\xA\x1\xFFFF"+
			"\x1\x7\x6\xFFFF\x1\x8\x1\xFFFF\x1\xC\x3\xFFFF\x1\x29\x1\x2D\x4\xFFFF"+
			"\x1\xB\x1\xFFFF\x1\x6\x1\xFFFF\x1\x9\x1\xFFFF\x1\xE\x1\x10\x1\xFFFF\x1"+
			"\x3\x1\x11\x1\x4\x3\xFFFF\x1\x1\x1\x5\x1\xFFFF\x1\xD\x2\xFFFF\x1\xF";
		private const string DFA8_specialS =
			"\x39\xFFFF\x1\x0\x33\xFFFF}>";
		private static readonly string[] DFA8_transitionS =
			{
				"\x2\x22\x2\xFFFF\x1\x22\x12\xFFFF\x1\x22\x1\xFFFF\x1\x23\x3\xFFFF\x1"+
				"\x1E\x1\xFFFF\x1\x11\x1\x12\x1\x19\x1\x17\x1\xE\x1\x18\x1\xD\x1\x1A"+
				"\xA\x21\x1\xF\x1\x10\x1\x1C\x1\x1B\x1\x1D\x2\xFFFF\x1A\x20\x1\x13\x1"+
				"\xFFFF\x1\x14\x3\xFFFF\x1\x1\x1\xA\x1\x20\x1\x7\x1\x4\x1\x6\x2\x20\x1"+
				"\x2\x2\x20\x1\x8\x1\x20\x1\xB\x1\x9\x4\x20\x1\x3\x1\x20\x1\xC\x1\x5"+
				"\x3\x20\x1\x15\x1\x1F\x1\x16",
				"\x1\x24",
				"\x1\x25\x7\xFFFF\x1\x26",
				"\x1\x27\x6\xFFFF\x1\x28\x9\xFFFF\x1\x29",
				"\x1\x2A\x1\xFFFF\x1\x2B",
				"\x1\x2C",
				"\x1\x2D\x5\xFFFF\x1\x2E",
				"\x1\x2F",
				"\x1\x30",
				"\x1\x31",
				"\x1\x32",
				"\x1\x33",
				"\x1\x34",
				"",
				"",
				"\x1\x35",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x37",
				"\x1\x39",
				"",
				"\x1\x3C\x1\x3B",
				"\x1\x3E",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x40",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x43",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x45",
				"\x1\x46",
				"\x1\x47",
				"\x1\x48",
				"\x1\x49",
				"\x1\x4A",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x4C",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x4E",
				"\x1\x4F",
				"\x1\x50",
				"",
				"",
				"",
				"",
				"\x0\x52",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x53",
				"",
				"",
				"\x1\x54",
				"",
				"\x1\x55",
				"\x1\x56",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x58",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x5A",
				"",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"",
				"\x1\x5C",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"",
				"",
				"\x1\x5F",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"",
				"\x1\x63",
				"",
				"\x1\x64",
				"",
				"\x1\x65",
				"",
				"",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"",
				"",
				"",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x68",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"",
				"",
				"\x1\x6A",
				"",
				"\x1\x6B",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				""
			};

		private static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
		private static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
		private static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
		private static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
		private static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
		private static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
		private static readonly short[][] DFA8_transition;

		static DFA8()
		{
			int numStates = DFA8_transitionS.Length;
			DFA8_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA8_transition[i] = DFA.UnpackEncodedString(DFA8_transitionS[i]);
			}
		}

		public DFA8( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 8;
			this.eot = DFA8_eot;
			this.eof = DFA8_eof;
			this.min = DFA8_min;
			this.max = DFA8_max;
			this.accept = DFA8_accept;
			this.special = DFA8_special;
			this.transition = DFA8_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( ARRAY | IF | THEN | ELSE | WHILE | FOR | TO | DO | LET | IN | END | OF | BREAK | NIL | FUNCTION | VAR | TYPE | DOT | COMMA | COLON | SEMICOLON | L_PARENT | R_PARENT | L_BRACKET | R_BRACKET | L_BRACE | R_BRACE | PLUS | MINUS | MULT | DIV | EQUALS | NOT_EQUALS | LESS | LESS_EQUALS | GREATER | GREATER_EQUALS | AND | OR | ASSIGN | OPEN_COMMENT | CLOSE_COMMENT | ID | INT | COMMENT | WS | STRING );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition8(DFA dfa, int s, IIntStream _input)
	{
		IIntStream input = _input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA8_57 = input.LA(1);

				s = -1;
				if ( ((LA8_57>='\u0000' && LA8_57<='\uFFFF')) ) {s = 82;}

				else s = 81;

				if ( s>=0 ) return s;
				break;
		}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 8, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
 
	#endregion

}
