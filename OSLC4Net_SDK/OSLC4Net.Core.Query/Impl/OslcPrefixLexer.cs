//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.5 ../Grammars/OslcPrefix.g 2013-06-26 11:32:38

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.5")]
[System.CLSCompliant(false)]
public partial class OslcPrefixLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__21=21;
	public const int CLOSE_CURLY_BRACE=4;
	public const int COMMA=5;
	public const int DIGIT=6;
	public const int DOT=7;
	public const int EOL=8;
	public const int GREATER=9;
	public const int IRI_REF=10;
	public const int LESS=11;
	public const int MINUS=12;
	public const int OPEN_CURLY_BRACE=13;
	public const int PN_CHARS=14;
	public const int PN_CHARS_BASE=15;
	public const int PN_CHARS_U=16;
	public const int PN_PREFIX=17;
	public const int PREFIX=18;
	public const int PREFIX_LIST=19;
	public const int WS=20;

    // delegates
    // delegators

	public OslcPrefixLexer()
	{
		OnCreated();
	}

	public OslcPrefixLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public OslcPrefixLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
	public override string GrammarFileName { get { return "../Grammars/OslcPrefix.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void EnterRule_PREFIX();
	partial void LeaveRule_PREFIX();

	// $ANTLR start "PREFIX"
	[GrammarRule("PREFIX")]
	private void mPREFIX()
	{
		EnterRule_PREFIX();
		EnterRule("PREFIX", 1);
		TraceIn("PREFIX", 1);
		try
		{
			int _type = PREFIX;
			int _channel = DefaultTokenChannel;
			// ../Grammars/OslcPrefix.g:7:8: ( 'prefix' )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:7:10: 'prefix'
			{
			DebugLocation(7, 10);
			Match("prefix"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PREFIX", 1);
			LeaveRule("PREFIX", 1);
			LeaveRule_PREFIX();
		}
	}
	// $ANTLR end "PREFIX"

	partial void EnterRule_PREFIX_LIST();
	partial void LeaveRule_PREFIX_LIST();

	// $ANTLR start "PREFIX_LIST"
	[GrammarRule("PREFIX_LIST")]
	private void mPREFIX_LIST()
	{
		EnterRule_PREFIX_LIST();
		EnterRule("PREFIX_LIST", 2);
		TraceIn("PREFIX_LIST", 2);
		try
		{
			int _type = PREFIX_LIST;
			int _channel = DefaultTokenChannel;
			// ../Grammars/OslcPrefix.g:8:13: ( 'prefix_list' )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:8:15: 'prefix_list'
			{
			DebugLocation(8, 15);
			Match("prefix_list"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PREFIX_LIST", 2);
			LeaveRule("PREFIX_LIST", 2);
			LeaveRule_PREFIX_LIST();
		}
	}
	// $ANTLR end "PREFIX_LIST"

	partial void EnterRule_T__21();
	partial void LeaveRule_T__21();

	// $ANTLR start "T__21"
	[GrammarRule("T__21")]
	private void mT__21()
	{
		EnterRule_T__21();
		EnterRule("T__21", 3);
		TraceIn("T__21", 3);
		try
		{
			int _type = T__21;
			int _channel = DefaultTokenChannel;
			// ../Grammars/OslcPrefix.g:9:7: ( '=' )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:9:9: '='
			{
			DebugLocation(9, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__21", 3);
			LeaveRule("T__21", 3);
			LeaveRule_T__21();
		}
	}
	// $ANTLR end "T__21"

	partial void EnterRule_WS();
	partial void LeaveRule_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		EnterRule_WS();
		EnterRule("WS", 4);
		TraceIn("WS", 4);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// ../Grammars/OslcPrefix.g:54:5: ( ( ' ' | '\\t' | EOL )+ )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:54:7: ( ' ' | '\\t' | EOL )+
			{
			DebugLocation(54, 7);
			// ../Grammars/OslcPrefix.g:54:7: ( ' ' | '\\t' | EOL )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, false);
				int LA1_1 = input.LA(1);

				if (((LA1_1>='\t' && LA1_1<='\n')||LA1_1=='\r'||LA1_1==' '))
				{
					alt1 = 1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// ../Grammars/OslcPrefix.g:
					{
					DebugLocation(54, 7);
					input.Consume();


					}
					break;

				default:
					if (cnt1 >= 1)
						goto loop1;

					EarlyExitException eee1 = new EarlyExitException( 1, input );
					DebugRecognitionException(eee1);
					throw eee1;
				}
				cnt1++;
			}
			loop1:
				;

			} finally { DebugExitSubRule(1); }

			DebugLocation(54, 25);
			 Skip(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 4);
			LeaveRule("WS", 4);
			LeaveRule_WS();
		}
	}
	// $ANTLR end "WS"

	partial void EnterRule_EOL();
	partial void LeaveRule_EOL();

	// $ANTLR start "EOL"
	[GrammarRule("EOL")]
	private void mEOL()
	{
		EnterRule_EOL();
		EnterRule("EOL", 5);
		TraceIn("EOL", 5);
		try
		{
			// ../Grammars/OslcPrefix.g:60:5: ( '\\n' | '\\r' )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:
			{
			DebugLocation(60, 5);
			if (input.LA(1)=='\n'||input.LA(1)=='\r')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("EOL", 5);
			LeaveRule("EOL", 5);
			LeaveRule_EOL();
		}
	}
	// $ANTLR end "EOL"

	partial void EnterRule_PN_PREFIX();
	partial void LeaveRule_PN_PREFIX();

	// $ANTLR start "PN_PREFIX"
	[GrammarRule("PN_PREFIX")]
	private void mPN_PREFIX()
	{
		EnterRule_PN_PREFIX();
		EnterRule("PN_PREFIX", 6);
		TraceIn("PN_PREFIX", 6);
		try
		{
			int _type = PN_PREFIX;
			int _channel = DefaultTokenChannel;
			// ../Grammars/OslcPrefix.g:63:5: ( PN_CHARS_BASE ( ( PN_CHARS | DOT )* PN_CHARS )? )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:63:7: PN_CHARS_BASE ( ( PN_CHARS | DOT )* PN_CHARS )?
			{
			DebugLocation(63, 7);
			mPN_CHARS_BASE(); 
			DebugLocation(63, 21);
			// ../Grammars/OslcPrefix.g:63:21: ( ( PN_CHARS | DOT )* PN_CHARS )?
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, false);
			int LA3_1 = input.LA(1);

			if (((LA3_1>='-' && LA3_1<='.')||(LA3_1>='0' && LA3_1<='9')||(LA3_1>='A' && LA3_1<='Z')||LA3_1=='_'||(LA3_1>='a' && LA3_1<='z')||LA3_1=='\u00B7'||(LA3_1>='\u00C0' && LA3_1<='\u00D6')||(LA3_1>='\u00D8' && LA3_1<='\u00F6')||(LA3_1>='\u00F8' && LA3_1<='\u037D')||(LA3_1>='\u037F' && LA3_1<='\u1FFF')||(LA3_1>='\u200C' && LA3_1<='\u200D')||(LA3_1>='\u203F' && LA3_1<='\u2040')||(LA3_1>='\u2070' && LA3_1<='\u218F')||(LA3_1>='\u2C00' && LA3_1<='\u2FEF')||(LA3_1>='\u3001' && LA3_1<='\uD7FF')||(LA3_1>='\uF900' && LA3_1<='\uFDCF')||(LA3_1>='\uFDF0' && LA3_1<='\uFFFD')))
			{
				alt3 = 1;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// ../Grammars/OslcPrefix.g:63:22: ( PN_CHARS | DOT )* PN_CHARS
				{
				DebugLocation(63, 22);
				// ../Grammars/OslcPrefix.g:63:22: ( PN_CHARS | DOT )*
				try { DebugEnterSubRule(2);
				while (true)
				{
					int alt2=2;
					try { DebugEnterDecision(2, false);
					int LA2_1 = input.LA(1);

					if ((LA2_1=='-'||(LA2_1>='0' && LA2_1<='9')||(LA2_1>='A' && LA2_1<='Z')||LA2_1=='_'||(LA2_1>='a' && LA2_1<='z')||LA2_1=='\u00B7'||(LA2_1>='\u00C0' && LA2_1<='\u00D6')||(LA2_1>='\u00D8' && LA2_1<='\u00F6')||(LA2_1>='\u00F8' && LA2_1<='\u037D')||(LA2_1>='\u037F' && LA2_1<='\u1FFF')||(LA2_1>='\u200C' && LA2_1<='\u200D')||(LA2_1>='\u203F' && LA2_1<='\u2040')||(LA2_1>='\u2070' && LA2_1<='\u218F')||(LA2_1>='\u2C00' && LA2_1<='\u2FEF')||(LA2_1>='\u3001' && LA2_1<='\uD7FF')||(LA2_1>='\uF900' && LA2_1<='\uFDCF')||(LA2_1>='\uFDF0' && LA2_1<='\uFFFD')))
					{
						int LA2_2 = input.LA(2);

						if (((LA2_2>='-' && LA2_2<='.')||(LA2_2>='0' && LA2_2<='9')||(LA2_2>='A' && LA2_2<='Z')||LA2_2=='_'||(LA2_2>='a' && LA2_2<='z')||LA2_2=='\u00B7'||(LA2_2>='\u00C0' && LA2_2<='\u00D6')||(LA2_2>='\u00D8' && LA2_2<='\u00F6')||(LA2_2>='\u00F8' && LA2_2<='\u037D')||(LA2_2>='\u037F' && LA2_2<='\u1FFF')||(LA2_2>='\u200C' && LA2_2<='\u200D')||(LA2_2>='\u203F' && LA2_2<='\u2040')||(LA2_2>='\u2070' && LA2_2<='\u218F')||(LA2_2>='\u2C00' && LA2_2<='\u2FEF')||(LA2_2>='\u3001' && LA2_2<='\uD7FF')||(LA2_2>='\uF900' && LA2_2<='\uFDCF')||(LA2_2>='\uFDF0' && LA2_2<='\uFFFD')))
						{
							alt2 = 1;
						}


					}
					else if ((LA2_1=='.'))
					{
						alt2 = 1;
					}


					} finally { DebugExitDecision(2); }
					switch ( alt2 )
					{
					case 1:
						DebugEnterAlt(1);
						// ../Grammars/OslcPrefix.g:
						{
						DebugLocation(63, 22);
						input.Consume();


						}
						break;

					default:
						goto loop2;
					}
				}

				loop2:
					;

				} finally { DebugExitSubRule(2); }

				DebugLocation(63, 38);
				mPN_CHARS(); 

				}
				break;

			}
			} finally { DebugExitSubRule(3); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PN_PREFIX", 6);
			LeaveRule("PN_PREFIX", 6);
			LeaveRule_PN_PREFIX();
		}
	}
	// $ANTLR end "PN_PREFIX"

	partial void EnterRule_PN_CHARS_BASE();
	partial void LeaveRule_PN_CHARS_BASE();

	// $ANTLR start "PN_CHARS_BASE"
	[GrammarRule("PN_CHARS_BASE")]
	private void mPN_CHARS_BASE()
	{
		EnterRule_PN_CHARS_BASE();
		EnterRule("PN_CHARS_BASE", 7);
		TraceIn("PN_CHARS_BASE", 7);
		try
		{
			// ../Grammars/OslcPrefix.g:69:5: ( 'A' .. 'Z' | 'a' .. 'z' | '\\u00C0' .. '\\u00D6' | '\\u00D8' .. '\\u00F6' | '\\u00F8' .. '\\u02FF' | '\\u0370' .. '\\u037D' | '\\u037F' .. '\\u1FFF' | '\\u200C' .. '\\u200D' | '\\u2070' .. '\\u218F' | '\\u2C00' .. '\\u2FEF' | '\\u3001' .. '\\uD7FF' | '\\uF900' .. '\\uFDCF' | '\\uFDF0' .. '\\uFFFD' )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:
			{
			DebugLocation(69, 5);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||(input.LA(1)>='a' && input.LA(1)<='z')||(input.LA(1)>='\u00C0' && input.LA(1)<='\u00D6')||(input.LA(1)>='\u00D8' && input.LA(1)<='\u00F6')||(input.LA(1)>='\u00F8' && input.LA(1)<='\u02FF')||(input.LA(1)>='\u0370' && input.LA(1)<='\u037D')||(input.LA(1)>='\u037F' && input.LA(1)<='\u1FFF')||(input.LA(1)>='\u200C' && input.LA(1)<='\u200D')||(input.LA(1)>='\u2070' && input.LA(1)<='\u218F')||(input.LA(1)>='\u2C00' && input.LA(1)<='\u2FEF')||(input.LA(1)>='\u3001' && input.LA(1)<='\uD7FF')||(input.LA(1)>='\uF900' && input.LA(1)<='\uFDCF')||(input.LA(1)>='\uFDF0' && input.LA(1)<='\uFFFD'))
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("PN_CHARS_BASE", 7);
			LeaveRule("PN_CHARS_BASE", 7);
			LeaveRule_PN_CHARS_BASE();
		}
	}
	// $ANTLR end "PN_CHARS_BASE"

	partial void EnterRule_PN_CHARS();
	partial void LeaveRule_PN_CHARS();

	// $ANTLR start "PN_CHARS"
	[GrammarRule("PN_CHARS")]
	private void mPN_CHARS()
	{
		EnterRule_PN_CHARS();
		EnterRule("PN_CHARS", 8);
		TraceIn("PN_CHARS", 8);
		try
		{
			// ../Grammars/OslcPrefix.g:86:5: ( PN_CHARS_U | MINUS | DIGIT | '\\u00B7' | '\\u0300' .. '\\u036F' | '\\u203F' .. '\\u2040' )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:
			{
			DebugLocation(86, 5);
			if (input.LA(1)=='-'||(input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z')||input.LA(1)=='\u00B7'||(input.LA(1)>='\u00C0' && input.LA(1)<='\u00D6')||(input.LA(1)>='\u00D8' && input.LA(1)<='\u00F6')||(input.LA(1)>='\u00F8' && input.LA(1)<='\u037D')||(input.LA(1)>='\u037F' && input.LA(1)<='\u1FFF')||(input.LA(1)>='\u200C' && input.LA(1)<='\u200D')||(input.LA(1)>='\u203F' && input.LA(1)<='\u2040')||(input.LA(1)>='\u2070' && input.LA(1)<='\u218F')||(input.LA(1)>='\u2C00' && input.LA(1)<='\u2FEF')||(input.LA(1)>='\u3001' && input.LA(1)<='\uD7FF')||(input.LA(1)>='\uF900' && input.LA(1)<='\uFDCF')||(input.LA(1)>='\uFDF0' && input.LA(1)<='\uFFFD'))
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("PN_CHARS", 8);
			LeaveRule("PN_CHARS", 8);
			LeaveRule_PN_CHARS();
		}
	}
	// $ANTLR end "PN_CHARS"

	partial void EnterRule_PN_CHARS_U();
	partial void LeaveRule_PN_CHARS_U();

	// $ANTLR start "PN_CHARS_U"
	[GrammarRule("PN_CHARS_U")]
	private void mPN_CHARS_U()
	{
		EnterRule_PN_CHARS_U();
		EnterRule("PN_CHARS_U", 9);
		TraceIn("PN_CHARS_U", 9);
		try
		{
			// ../Grammars/OslcPrefix.g:96:5: ( PN_CHARS_BASE | '_' )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:
			{
			DebugLocation(96, 5);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z')||(input.LA(1)>='\u00C0' && input.LA(1)<='\u00D6')||(input.LA(1)>='\u00D8' && input.LA(1)<='\u00F6')||(input.LA(1)>='\u00F8' && input.LA(1)<='\u02FF')||(input.LA(1)>='\u0370' && input.LA(1)<='\u037D')||(input.LA(1)>='\u037F' && input.LA(1)<='\u1FFF')||(input.LA(1)>='\u200C' && input.LA(1)<='\u200D')||(input.LA(1)>='\u2070' && input.LA(1)<='\u218F')||(input.LA(1)>='\u2C00' && input.LA(1)<='\u2FEF')||(input.LA(1)>='\u3001' && input.LA(1)<='\uD7FF')||(input.LA(1)>='\uF900' && input.LA(1)<='\uFDCF')||(input.LA(1)>='\uFDF0' && input.LA(1)<='\uFFFD'))
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("PN_CHARS_U", 9);
			LeaveRule("PN_CHARS_U", 9);
			LeaveRule_PN_CHARS_U();
		}
	}
	// $ANTLR end "PN_CHARS_U"

	partial void EnterRule_DIGIT();
	partial void LeaveRule_DIGIT();

	// $ANTLR start "DIGIT"
	[GrammarRule("DIGIT")]
	private void mDIGIT()
	{
		EnterRule_DIGIT();
		EnterRule("DIGIT", 10);
		TraceIn("DIGIT", 10);
		try
		{
			// ../Grammars/OslcPrefix.g:101:5: ( '0' .. '9' )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:
			{
			DebugLocation(101, 5);
			if ((input.LA(1)>='0' && input.LA(1)<='9'))
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("DIGIT", 10);
			LeaveRule("DIGIT", 10);
			LeaveRule_DIGIT();
		}
	}
	// $ANTLR end "DIGIT"

	partial void EnterRule_IRI_REF();
	partial void LeaveRule_IRI_REF();

	// $ANTLR start "IRI_REF"
	[GrammarRule("IRI_REF")]
	private void mIRI_REF()
	{
		EnterRule_IRI_REF();
		EnterRule("IRI_REF", 11);
		TraceIn("IRI_REF", 11);
		try
		{
			int _type = IRI_REF;
			int _channel = DefaultTokenChannel;
			// ../Grammars/OslcPrefix.g:104:5: ( LESS ( options {greedy=false; } :~ ( LESS | GREATER | '\"' | OPEN_CURLY_BRACE | CLOSE_CURLY_BRACE | '|' | '^' | '\\\\' | '`' | ( '\\u0000' .. '\\u0020' ) ) )* GREATER )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:104:7: LESS ( options {greedy=false; } :~ ( LESS | GREATER | '\"' | OPEN_CURLY_BRACE | CLOSE_CURLY_BRACE | '|' | '^' | '\\\\' | '`' | ( '\\u0000' .. '\\u0020' ) ) )* GREATER
			{
			DebugLocation(104, 7);
			mLESS(); 
			DebugLocation(104, 12);
			// ../Grammars/OslcPrefix.g:104:12: ( options {greedy=false; } :~ ( LESS | GREATER | '\"' | OPEN_CURLY_BRACE | CLOSE_CURLY_BRACE | '|' | '^' | '\\\\' | '`' | ( '\\u0000' .. '\\u0020' ) ) )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, false);
				int LA4_1 = input.LA(1);

				if ((LA4_1=='!'||(LA4_1>='#' && LA4_1<=';')||LA4_1=='='||(LA4_1>='?' && LA4_1<='[')||LA4_1==']'||LA4_1=='_'||(LA4_1>='a' && LA4_1<='z')||(LA4_1>='~' && LA4_1<='\uFFFF')))
				{
					alt4 = 1;
				}
				else if ((LA4_1=='>'))
				{
					alt4 = 2;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// ../Grammars/OslcPrefix.g:104:40: ~ ( LESS | GREATER | '\"' | OPEN_CURLY_BRACE | CLOSE_CURLY_BRACE | '|' | '^' | '\\\\' | '`' | ( '\\u0000' .. '\\u0020' ) )
					{
					DebugLocation(104, 40);
					input.Consume();


					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(104, 154);
			mGREATER(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IRI_REF", 11);
			LeaveRule("IRI_REF", 11);
			LeaveRule_IRI_REF();
		}
	}
	// $ANTLR end "IRI_REF"

	partial void EnterRule_COMMA();
	partial void LeaveRule_COMMA();

	// $ANTLR start "COMMA"
	[GrammarRule("COMMA")]
	private void mCOMMA()
	{
		EnterRule_COMMA();
		EnterRule("COMMA", 12);
		TraceIn("COMMA", 12);
		try
		{
			int _type = COMMA;
			int _channel = DefaultTokenChannel;
			// ../Grammars/OslcPrefix.g:108:5: ( ',' )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:108:7: ','
			{
			DebugLocation(108, 7);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COMMA", 12);
			LeaveRule("COMMA", 12);
			LeaveRule_COMMA();
		}
	}
	// $ANTLR end "COMMA"

	partial void EnterRule_DOT();
	partial void LeaveRule_DOT();

	// $ANTLR start "DOT"
	[GrammarRule("DOT")]
	private void mDOT()
	{
		EnterRule_DOT();
		EnterRule("DOT", 13);
		TraceIn("DOT", 13);
		try
		{
			int _type = DOT;
			int _channel = DefaultTokenChannel;
			// ../Grammars/OslcPrefix.g:112:5: ( '.' )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:112:7: '.'
			{
			DebugLocation(112, 7);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOT", 13);
			LeaveRule("DOT", 13);
			LeaveRule_DOT();
		}
	}
	// $ANTLR end "DOT"

	partial void EnterRule_MINUS();
	partial void LeaveRule_MINUS();

	// $ANTLR start "MINUS"
	[GrammarRule("MINUS")]
	private void mMINUS()
	{
		EnterRule_MINUS();
		EnterRule("MINUS", 14);
		TraceIn("MINUS", 14);
		try
		{
			int _type = MINUS;
			int _channel = DefaultTokenChannel;
			// ../Grammars/OslcPrefix.g:116:5: ( '-' )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:116:7: '-'
			{
			DebugLocation(116, 7);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MINUS", 14);
			LeaveRule("MINUS", 14);
			LeaveRule_MINUS();
		}
	}
	// $ANTLR end "MINUS"

	partial void EnterRule_OPEN_CURLY_BRACE();
	partial void LeaveRule_OPEN_CURLY_BRACE();

	// $ANTLR start "OPEN_CURLY_BRACE"
	[GrammarRule("OPEN_CURLY_BRACE")]
	private void mOPEN_CURLY_BRACE()
	{
		EnterRule_OPEN_CURLY_BRACE();
		EnterRule("OPEN_CURLY_BRACE", 15);
		TraceIn("OPEN_CURLY_BRACE", 15);
		try
		{
			int _type = OPEN_CURLY_BRACE;
			int _channel = DefaultTokenChannel;
			// ../Grammars/OslcPrefix.g:120:5: ( '{' )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:120:7: '{'
			{
			DebugLocation(120, 7);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OPEN_CURLY_BRACE", 15);
			LeaveRule("OPEN_CURLY_BRACE", 15);
			LeaveRule_OPEN_CURLY_BRACE();
		}
	}
	// $ANTLR end "OPEN_CURLY_BRACE"

	partial void EnterRule_CLOSE_CURLY_BRACE();
	partial void LeaveRule_CLOSE_CURLY_BRACE();

	// $ANTLR start "CLOSE_CURLY_BRACE"
	[GrammarRule("CLOSE_CURLY_BRACE")]
	private void mCLOSE_CURLY_BRACE()
	{
		EnterRule_CLOSE_CURLY_BRACE();
		EnterRule("CLOSE_CURLY_BRACE", 16);
		TraceIn("CLOSE_CURLY_BRACE", 16);
		try
		{
			int _type = CLOSE_CURLY_BRACE;
			int _channel = DefaultTokenChannel;
			// ../Grammars/OslcPrefix.g:124:5: ( '}' )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:124:7: '}'
			{
			DebugLocation(124, 7);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CLOSE_CURLY_BRACE", 16);
			LeaveRule("CLOSE_CURLY_BRACE", 16);
			LeaveRule_CLOSE_CURLY_BRACE();
		}
	}
	// $ANTLR end "CLOSE_CURLY_BRACE"

	partial void EnterRule_LESS();
	partial void LeaveRule_LESS();

	// $ANTLR start "LESS"
	[GrammarRule("LESS")]
	private void mLESS()
	{
		EnterRule_LESS();
		EnterRule("LESS", 17);
		TraceIn("LESS", 17);
		try
		{
			int _type = LESS;
			int _channel = DefaultTokenChannel;
			// ../Grammars/OslcPrefix.g:128:5: ( '<' )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:128:7: '<'
			{
			DebugLocation(128, 7);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LESS", 17);
			LeaveRule("LESS", 17);
			LeaveRule_LESS();
		}
	}
	// $ANTLR end "LESS"

	partial void EnterRule_GREATER();
	partial void LeaveRule_GREATER();

	// $ANTLR start "GREATER"
	[GrammarRule("GREATER")]
	private void mGREATER()
	{
		EnterRule_GREATER();
		EnterRule("GREATER", 18);
		TraceIn("GREATER", 18);
		try
		{
			int _type = GREATER;
			int _channel = DefaultTokenChannel;
			// ../Grammars/OslcPrefix.g:132:5: ( '>' )
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:132:7: '>'
			{
			DebugLocation(132, 7);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREATER", 18);
			LeaveRule("GREATER", 18);
			LeaveRule_GREATER();
		}
	}
	// $ANTLR end "GREATER"

	public override void mTokens()
	{
		// ../Grammars/OslcPrefix.g:1:8: ( PREFIX | PREFIX_LIST | T__21 | WS | PN_PREFIX | IRI_REF | COMMA | DOT | MINUS | OPEN_CURLY_BRACE | CLOSE_CURLY_BRACE | LESS | GREATER )
		int alt5=13;
		try { DebugEnterDecision(5, false);
		int LA5_1 = input.LA(1);

		if ((LA5_1=='p'))
		{
			int LA5_2 = input.LA(2);

			if ((LA5_2=='r'))
			{
				int LA5_3 = input.LA(3);

				if ((LA5_3=='e'))
				{
					int LA5_4 = input.LA(4);

					if ((LA5_4=='f'))
					{
						int LA5_5 = input.LA(5);

						if ((LA5_5=='i'))
						{
							int LA5_6 = input.LA(6);

							if ((LA5_6=='x'))
							{
								int LA5_7 = input.LA(7);

								if ((LA5_7=='_'))
								{
									int LA5_8 = input.LA(8);

									if ((LA5_8=='l'))
									{
										int LA5_9 = input.LA(9);

										if ((LA5_9=='i'))
										{
											int LA5_10 = input.LA(10);

											if ((LA5_10=='s'))
											{
												int LA5_11 = input.LA(11);

												if ((LA5_11=='t'))
												{
													int LA5_12 = input.LA(12);

													if (((LA5_12>='-' && LA5_12<='.')||(LA5_12>='0' && LA5_12<='9')||(LA5_12>='A' && LA5_12<='Z')||LA5_12=='_'||(LA5_12>='a' && LA5_12<='z')||LA5_12=='\u00B7'||(LA5_12>='\u00C0' && LA5_12<='\u00D6')||(LA5_12>='\u00D8' && LA5_12<='\u00F6')||(LA5_12>='\u00F8' && LA5_12<='\u037D')||(LA5_12>='\u037F' && LA5_12<='\u1FFF')||(LA5_12>='\u200C' && LA5_12<='\u200D')||(LA5_12>='\u203F' && LA5_12<='\u2040')||(LA5_12>='\u2070' && LA5_12<='\u218F')||(LA5_12>='\u2C00' && LA5_12<='\u2FEF')||(LA5_12>='\u3001' && LA5_12<='\uD7FF')||(LA5_12>='\uF900' && LA5_12<='\uFDCF')||(LA5_12>='\uFDF0' && LA5_12<='\uFFFD')))
													{
														alt5 = 5;
													}
													else
													{
														alt5 = 2;
													}
												}
												else
												{
													alt5 = 5;
												}
											}
											else
											{
												alt5 = 5;
											}
										}
										else
										{
											alt5 = 5;
										}
									}
									else
									{
										alt5 = 5;
									}
								}
								else if (((LA5_7>='-' && LA5_7<='.')||(LA5_7>='0' && LA5_7<='9')||(LA5_7>='A' && LA5_7<='Z')||(LA5_7>='a' && LA5_7<='z')||LA5_7=='\u00B7'||(LA5_7>='\u00C0' && LA5_7<='\u00D6')||(LA5_7>='\u00D8' && LA5_7<='\u00F6')||(LA5_7>='\u00F8' && LA5_7<='\u037D')||(LA5_7>='\u037F' && LA5_7<='\u1FFF')||(LA5_7>='\u200C' && LA5_7<='\u200D')||(LA5_7>='\u203F' && LA5_7<='\u2040')||(LA5_7>='\u2070' && LA5_7<='\u218F')||(LA5_7>='\u2C00' && LA5_7<='\u2FEF')||(LA5_7>='\u3001' && LA5_7<='\uD7FF')||(LA5_7>='\uF900' && LA5_7<='\uFDCF')||(LA5_7>='\uFDF0' && LA5_7<='\uFFFD')))
								{
									alt5 = 5;
								}
								else
								{
									alt5 = 1;
								}
							}
							else
							{
								alt5 = 5;
							}
						}
						else
						{
							alt5 = 5;
						}
					}
					else
					{
						alt5 = 5;
					}
				}
				else
				{
					alt5 = 5;
				}
			}
			else
			{
				alt5 = 5;
			}
		}
		else if ((LA5_1=='='))
		{
			alt5 = 3;
		}
		else if (((LA5_1>='\t' && LA5_1<='\n')||LA5_1=='\r'||LA5_1==' '))
		{
			alt5 = 4;
		}
		else if (((LA5_1>='A' && LA5_1<='Z')||(LA5_1>='a' && LA5_1<='o')||(LA5_1>='q' && LA5_1<='z')||(LA5_1>='\u00C0' && LA5_1<='\u00D6')||(LA5_1>='\u00D8' && LA5_1<='\u00F6')||(LA5_1>='\u00F8' && LA5_1<='\u02FF')||(LA5_1>='\u0370' && LA5_1<='\u037D')||(LA5_1>='\u037F' && LA5_1<='\u1FFF')||(LA5_1>='\u200C' && LA5_1<='\u200D')||(LA5_1>='\u2070' && LA5_1<='\u218F')||(LA5_1>='\u2C00' && LA5_1<='\u2FEF')||(LA5_1>='\u3001' && LA5_1<='\uD7FF')||(LA5_1>='\uF900' && LA5_1<='\uFDCF')||(LA5_1>='\uFDF0' && LA5_1<='\uFFFD')))
		{
			alt5 = 5;
		}
		else if ((LA5_1=='<'))
		{
			int LA5_2 = input.LA(2);

			if ((LA5_2=='!'||(LA5_2>='#' && LA5_2<=';')||(LA5_2>='=' && LA5_2<='[')||LA5_2==']'||LA5_2=='_'||(LA5_2>='a' && LA5_2<='z')||(LA5_2>='~' && LA5_2<='\uFFFF')))
			{
				alt5 = 6;
			}
			else
			{
				alt5 = 12;
			}
		}
		else if ((LA5_1==','))
		{
			alt5 = 7;
		}
		else if ((LA5_1=='.'))
		{
			alt5 = 8;
		}
		else if ((LA5_1=='-'))
		{
			alt5 = 9;
		}
		else if ((LA5_1=='{'))
		{
			alt5 = 10;
		}
		else if ((LA5_1=='}'))
		{
			alt5 = 11;
		}
		else if ((LA5_1=='>'))
		{
			alt5 = 13;
		}
		else
		{
			NoViableAltException nvae = new NoViableAltException("", 5, 0, input, 1);
			DebugRecognitionException(nvae);
			throw nvae;
		}
		} finally { DebugExitDecision(5); }
		switch (alt5)
		{
		case 1:
			DebugEnterAlt(1);
			// ../Grammars/OslcPrefix.g:1:10: PREFIX
			{
			DebugLocation(1, 10);
			mPREFIX(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// ../Grammars/OslcPrefix.g:1:17: PREFIX_LIST
			{
			DebugLocation(1, 17);
			mPREFIX_LIST(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// ../Grammars/OslcPrefix.g:1:29: T__21
			{
			DebugLocation(1, 29);
			mT__21(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// ../Grammars/OslcPrefix.g:1:35: WS
			{
			DebugLocation(1, 35);
			mWS(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// ../Grammars/OslcPrefix.g:1:38: PN_PREFIX
			{
			DebugLocation(1, 38);
			mPN_PREFIX(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// ../Grammars/OslcPrefix.g:1:48: IRI_REF
			{
			DebugLocation(1, 48);
			mIRI_REF(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// ../Grammars/OslcPrefix.g:1:56: COMMA
			{
			DebugLocation(1, 56);
			mCOMMA(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// ../Grammars/OslcPrefix.g:1:62: DOT
			{
			DebugLocation(1, 62);
			mDOT(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// ../Grammars/OslcPrefix.g:1:66: MINUS
			{
			DebugLocation(1, 66);
			mMINUS(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// ../Grammars/OslcPrefix.g:1:72: OPEN_CURLY_BRACE
			{
			DebugLocation(1, 72);
			mOPEN_CURLY_BRACE(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// ../Grammars/OslcPrefix.g:1:89: CLOSE_CURLY_BRACE
			{
			DebugLocation(1, 89);
			mCLOSE_CURLY_BRACE(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// ../Grammars/OslcPrefix.g:1:107: LESS
			{
			DebugLocation(1, 107);
			mLESS(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// ../Grammars/OslcPrefix.g:1:112: GREATER
			{
			DebugLocation(1, 112);
			mGREATER(); 

			}
			break;

		}

	}


	#region DFA

	protected override void InitDFAs()
	{
		base.InitDFAs();
	}

 
	#endregion

}
