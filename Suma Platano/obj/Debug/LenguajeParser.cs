//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Emanuel Pujols\Documents\Visual Studio 2015\Projects\Suma-Platano\Suma Platano\LenguajeDirectory\Lenguaje.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Suma_Platano.Lenguaje {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class LenguajeParser : Parser {
	public const int
		COMENTARIO_SIMPLE=1, PROGRAMA=2, VARIABLE=3, IMPRIMIR=4, SI=5, ENTONCES=6, 
		PARA=7, MIENTRAS=8, LLAVE_A=9, LLAVE_C=10, CORCHETE_A=11, CORCHETE_C=12, 
		PARENTESIS_A=13, PARENTESIS_C=14, PUNTO=15, COMA=16, DOSPUNTOS=17, PUNTOyCOMA=18, 
		ASIGNACION=19, SUMA=20, RESTA=21, MULTIPLICACION=22, DIVISION=23, POTENCIA=24, 
		OP_INCREMENTO=25, OP_DECREMENTO=26, OP_Y=27, OP_O=28, OP_NEGACION=29, 
		OP_MAYOR_Q=30, OP_MENOR_Q=31, OP_MAYOR_IG=32, OP_MENOR_IG=33, OP_IGUALDAD=34, 
		OP_DESIGUALDAD=35, OP_SUMAyASIG=36, OP_RESTAyASIG=37, OP_MULTyASIG=38, 
		OP_DIVyASIG=39, BOOLEAN=40, ID=41, NUMERO=42, ESPACIOeB=43;
	public const int
		RULE_compileUnit = 0, RULE_programa = 1, RULE_sentencia = 2, RULE_declaracion_var = 3, 
		RULE_asignacion_var = 4, RULE_imprimir = 5, RULE_expresion = 6;
	public static readonly string[] ruleNames = {
		"compileUnit", "programa", "sentencia", "declaracion_var", "asignacion_var", 
		"imprimir", "expresion"
	};

	private static readonly string[] _LiteralNames = {
		null, null, "'programa'", "'variable'", "'imprimir'", "'Si'", "'Entonces'", 
		"'Para'", "'Mientras'", "'{'", "'}'", "'['", "']'", "'('", "')'", "'.'", 
		"','", "':'", "';'", "'='", "'+'", "'-'", "'*'", "'/'", "'^'", "'++'", 
		"'--'", "'YY'", "'OO'", "'#'", "'>'", "'<'", "'>='", "'<='", "'<>'", "'><'", 
		"'+='", "'-='", "'*='", "'/='"
	};
	private static readonly string[] _SymbolicNames = {
		null, "COMENTARIO_SIMPLE", "PROGRAMA", "VARIABLE", "IMPRIMIR", "SI", "ENTONCES", 
		"PARA", "MIENTRAS", "LLAVE_A", "LLAVE_C", "CORCHETE_A", "CORCHETE_C", 
		"PARENTESIS_A", "PARENTESIS_C", "PUNTO", "COMA", "DOSPUNTOS", "PUNTOyCOMA", 
		"ASIGNACION", "SUMA", "RESTA", "MULTIPLICACION", "DIVISION", "POTENCIA", 
		"OP_INCREMENTO", "OP_DECREMENTO", "OP_Y", "OP_O", "OP_NEGACION", "OP_MAYOR_Q", 
		"OP_MENOR_Q", "OP_MAYOR_IG", "OP_MENOR_IG", "OP_IGUALDAD", "OP_DESIGUALDAD", 
		"OP_SUMAyASIG", "OP_RESTAyASIG", "OP_MULTyASIG", "OP_DIVyASIG", "BOOLEAN", 
		"ID", "NUMERO", "ESPACIOeB"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Lenguaje.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public LenguajeParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class CompileUnitContext : ParserRuleContext {
		public ProgramaContext programa() {
			return GetRuleContext<ProgramaContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(LenguajeParser.Eof, 0); }
		public CompileUnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compileUnit; } }
		public override void EnterRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.EnterCompileUnit(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.ExitCompileUnit(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILenguajeVisitor<TResult> typedVisitor = visitor as ILenguajeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCompileUnit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CompileUnitContext compileUnit() {
		CompileUnitContext _localctx = new CompileUnitContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_compileUnit);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 14; programa();
			State = 15; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ProgramaContext : ParserRuleContext {
		public ITerminalNode PROGRAMA() { return GetToken(LenguajeParser.PROGRAMA, 0); }
		public ITerminalNode ID() { return GetToken(LenguajeParser.ID, 0); }
		public ITerminalNode LLAVE_A() { return GetToken(LenguajeParser.LLAVE_A, 0); }
		public ITerminalNode LLAVE_C() { return GetToken(LenguajeParser.LLAVE_C, 0); }
		public SentenciaContext[] sentencia() {
			return GetRuleContexts<SentenciaContext>();
		}
		public SentenciaContext sentencia(int i) {
			return GetRuleContext<SentenciaContext>(i);
		}
		public ProgramaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_programa; } }
		public override void EnterRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.EnterPrograma(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.ExitPrograma(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILenguajeVisitor<TResult> typedVisitor = visitor as ILenguajeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPrograma(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgramaContext programa() {
		ProgramaContext _localctx = new ProgramaContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_programa);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 17; Match(PROGRAMA);
			State = 18; Match(ID);
			State = 19; Match(LLAVE_A);
			State = 23;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << VARIABLE) | (1L << IMPRIMIR) | (1L << ID))) != 0)) {
				{
				{
				State = 20; sentencia();
				}
				}
				State = 25;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 26; Match(LLAVE_C);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SentenciaContext : ParserRuleContext {
		public Declaracion_varContext declaracion_var() {
			return GetRuleContext<Declaracion_varContext>(0);
		}
		public Asignacion_varContext asignacion_var() {
			return GetRuleContext<Asignacion_varContext>(0);
		}
		public ImprimirContext imprimir() {
			return GetRuleContext<ImprimirContext>(0);
		}
		public SentenciaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_sentencia; } }
		public override void EnterRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.EnterSentencia(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.ExitSentencia(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILenguajeVisitor<TResult> typedVisitor = visitor as ILenguajeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSentencia(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SentenciaContext sentencia() {
		SentenciaContext _localctx = new SentenciaContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_sentencia);
		try {
			State = 31;
			switch (_input.La(1)) {
			case VARIABLE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 28; declaracion_var();
				}
				break;
			case ID:
				EnterOuterAlt(_localctx, 2);
				{
				State = 29; asignacion_var();
				}
				break;
			case IMPRIMIR:
				EnterOuterAlt(_localctx, 3);
				{
				State = 30; imprimir();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Declaracion_varContext : ParserRuleContext {
		public ITerminalNode VARIABLE() { return GetToken(LenguajeParser.VARIABLE, 0); }
		public ITerminalNode ID() { return GetToken(LenguajeParser.ID, 0); }
		public ITerminalNode PUNTOyCOMA() { return GetToken(LenguajeParser.PUNTOyCOMA, 0); }
		public Declaracion_varContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declaracion_var; } }
		public override void EnterRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.EnterDeclaracion_var(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.ExitDeclaracion_var(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILenguajeVisitor<TResult> typedVisitor = visitor as ILenguajeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDeclaracion_var(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Declaracion_varContext declaracion_var() {
		Declaracion_varContext _localctx = new Declaracion_varContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_declaracion_var);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 33; Match(VARIABLE);
			State = 34; Match(ID);
			State = 35; Match(PUNTOyCOMA);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Asignacion_varContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(LenguajeParser.ID, 0); }
		public ITerminalNode ASIGNACION() { return GetToken(LenguajeParser.ASIGNACION, 0); }
		public ExpresionContext expresion() {
			return GetRuleContext<ExpresionContext>(0);
		}
		public ITerminalNode PUNTOyCOMA() { return GetToken(LenguajeParser.PUNTOyCOMA, 0); }
		public Asignacion_varContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_asignacion_var; } }
		public override void EnterRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.EnterAsignacion_var(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.ExitAsignacion_var(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILenguajeVisitor<TResult> typedVisitor = visitor as ILenguajeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAsignacion_var(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Asignacion_varContext asignacion_var() {
		Asignacion_varContext _localctx = new Asignacion_varContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_asignacion_var);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 37; Match(ID);
			State = 38; Match(ASIGNACION);
			State = 39; expresion(0);
			State = 40; Match(PUNTOyCOMA);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ImprimirContext : ParserRuleContext {
		public ITerminalNode IMPRIMIR() { return GetToken(LenguajeParser.IMPRIMIR, 0); }
		public ITerminalNode PARENTESIS_A() { return GetToken(LenguajeParser.PARENTESIS_A, 0); }
		public ExpresionContext expresion() {
			return GetRuleContext<ExpresionContext>(0);
		}
		public ITerminalNode PARENTESIS_C() { return GetToken(LenguajeParser.PARENTESIS_C, 0); }
		public ITerminalNode PUNTOyCOMA() { return GetToken(LenguajeParser.PUNTOyCOMA, 0); }
		public ImprimirContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_imprimir; } }
		public override void EnterRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.EnterImprimir(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.ExitImprimir(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILenguajeVisitor<TResult> typedVisitor = visitor as ILenguajeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitImprimir(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ImprimirContext imprimir() {
		ImprimirContext _localctx = new ImprimirContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_imprimir);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 42; Match(IMPRIMIR);
			State = 43; Match(PARENTESIS_A);
			State = 44; expresion(0);
			State = 45; Match(PARENTESIS_C);
			State = 46; Match(PUNTOyCOMA);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpresionContext : ParserRuleContext {
		public object value;
		public ExpresionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expresion; } }
	 
		public ExpresionContext() { }
		public virtual void CopyFrom(ExpresionContext context) {
			base.CopyFrom(context);
			this.value = context.value;
		}
	}
	public partial class ParentExpresionContext : ExpresionContext {
		public ITerminalNode PARENTESIS_A() { return GetToken(LenguajeParser.PARENTESIS_A, 0); }
		public ExpresionContext expresion() {
			return GetRuleContext<ExpresionContext>(0);
		}
		public ITerminalNode PARENTESIS_C() { return GetToken(LenguajeParser.PARENTESIS_C, 0); }
		public ParentExpresionContext(ExpresionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.EnterParentExpresion(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.ExitParentExpresion(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILenguajeVisitor<TResult> typedVisitor = visitor as ILenguajeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParentExpresion(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NumeroExpresionContext : ExpresionContext {
		public ITerminalNode NUMERO() { return GetToken(LenguajeParser.NUMERO, 0); }
		public NumeroExpresionContext(ExpresionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.EnterNumeroExpresion(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.ExitNumeroExpresion(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILenguajeVisitor<TResult> typedVisitor = visitor as ILenguajeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumeroExpresion(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MulDivExpresionContext : ExpresionContext {
		public IToken op;
		public ExpresionContext[] expresion() {
			return GetRuleContexts<ExpresionContext>();
		}
		public ExpresionContext expresion(int i) {
			return GetRuleContext<ExpresionContext>(i);
		}
		public ITerminalNode MULTIPLICACION() { return GetToken(LenguajeParser.MULTIPLICACION, 0); }
		public ITerminalNode DIVISION() { return GetToken(LenguajeParser.DIVISION, 0); }
		public MulDivExpresionContext(ExpresionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.EnterMulDivExpresion(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.ExitMulDivExpresion(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILenguajeVisitor<TResult> typedVisitor = visitor as ILenguajeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMulDivExpresion(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ValorExpresionContext : ExpresionContext {
		public ITerminalNode ID() { return GetToken(LenguajeParser.ID, 0); }
		public ValorExpresionContext(ExpresionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.EnterValorExpresion(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.ExitValorExpresion(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILenguajeVisitor<TResult> typedVisitor = visitor as ILenguajeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitValorExpresion(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class SumResExpresionContext : ExpresionContext {
		public IToken op;
		public ExpresionContext[] expresion() {
			return GetRuleContexts<ExpresionContext>();
		}
		public ExpresionContext expresion(int i) {
			return GetRuleContext<ExpresionContext>(i);
		}
		public ITerminalNode SUMA() { return GetToken(LenguajeParser.SUMA, 0); }
		public ITerminalNode RESTA() { return GetToken(LenguajeParser.RESTA, 0); }
		public SumResExpresionContext(ExpresionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.EnterSumResExpresion(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILenguajeListener typedListener = listener as ILenguajeListener;
			if (typedListener != null) typedListener.ExitSumResExpresion(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILenguajeVisitor<TResult> typedVisitor = visitor as ILenguajeVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSumResExpresion(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpresionContext expresion() {
		return expresion(0);
	}

	private ExpresionContext expresion(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		ExpresionContext _localctx = new ExpresionContext(_ctx, _parentState);
		ExpresionContext _prevctx = _localctx;
		int _startState = 12;
		EnterRecursionRule(_localctx, 12, RULE_expresion, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 55;
			switch (_input.La(1)) {
			case NUMERO:
				{
				_localctx = new NumeroExpresionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				State = 49; Match(NUMERO);
				}
				break;
			case ID:
				{
				_localctx = new ValorExpresionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 50; Match(ID);
				}
				break;
			case PARENTESIS_A:
				{
				_localctx = new ParentExpresionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 51; Match(PARENTESIS_A);
				State = 52; expresion(0);
				State = 53; Match(PARENTESIS_C);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			_ctx.stop = _input.Lt(-1);
			State = 65;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,4,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 63;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,3,_ctx) ) {
					case 1:
						{
						_localctx = new MulDivExpresionContext(new ExpresionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expresion);
						State = 57;
						if (!(Precpred(_ctx, 5))) throw new FailedPredicateException(this, "Precpred(_ctx, 5)");
						State = 58;
						((MulDivExpresionContext)_localctx).op = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==MULTIPLICACION || _la==DIVISION) ) {
							((MulDivExpresionContext)_localctx).op = _errHandler.RecoverInline(this);
						} else {
							Consume();
						}
						State = 59; expresion(6);
						}
						break;

					case 2:
						{
						_localctx = new SumResExpresionContext(new ExpresionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expresion);
						State = 60;
						if (!(Precpred(_ctx, 4))) throw new FailedPredicateException(this, "Precpred(_ctx, 4)");
						State = 61;
						((SumResExpresionContext)_localctx).op = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==SUMA || _la==RESTA) ) {
							((SumResExpresionContext)_localctx).op = _errHandler.RecoverInline(this);
						} else {
							Consume();
						}
						State = 62; expresion(5);
						}
						break;
					}
					} 
				}
				State = 67;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,4,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 6: return expresion_sempred((ExpresionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expresion_sempred(ExpresionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(_ctx, 5);

		case 1: return Precpred(_ctx, 4);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3-G\x4\x2\t\x2\x4"+
		"\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x3\x2\x3\x2"+
		"\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\a\x3\x18\n\x3\f\x3\xE\x3\x1B\v\x3\x3\x3"+
		"\x3\x3\x3\x4\x3\x4\x3\x4\x5\x4\"\n\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3"+
		"\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3"+
		"\b\x3\b\x3\b\x3\b\x5\b:\n\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\a\b\x42\n\b"+
		"\f\b\xE\b\x45\v\b\x3\b\x2\x2\x3\xE\t\x2\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2"+
		"\xE\x2\x2\x4\x3\x2\x18\x19\x3\x2\x16\x17\x46\x2\x10\x3\x2\x2\x2\x4\x13"+
		"\x3\x2\x2\x2\x6!\x3\x2\x2\x2\b#\x3\x2\x2\x2\n\'\x3\x2\x2\x2\f,\x3\x2\x2"+
		"\x2\xE\x39\x3\x2\x2\x2\x10\x11\x5\x4\x3\x2\x11\x12\a\x2\x2\x3\x12\x3\x3"+
		"\x2\x2\x2\x13\x14\a\x4\x2\x2\x14\x15\a+\x2\x2\x15\x19\a\v\x2\x2\x16\x18"+
		"\x5\x6\x4\x2\x17\x16\x3\x2\x2\x2\x18\x1B\x3\x2\x2\x2\x19\x17\x3\x2\x2"+
		"\x2\x19\x1A\x3\x2\x2\x2\x1A\x1C\x3\x2\x2\x2\x1B\x19\x3\x2\x2\x2\x1C\x1D"+
		"\a\f\x2\x2\x1D\x5\x3\x2\x2\x2\x1E\"\x5\b\x5\x2\x1F\"\x5\n\x6\x2 \"\x5"+
		"\f\a\x2!\x1E\x3\x2\x2\x2!\x1F\x3\x2\x2\x2! \x3\x2\x2\x2\"\a\x3\x2\x2\x2"+
		"#$\a\x5\x2\x2$%\a+\x2\x2%&\a\x14\x2\x2&\t\x3\x2\x2\x2\'(\a+\x2\x2()\a"+
		"\x15\x2\x2)*\x5\xE\b\x2*+\a\x14\x2\x2+\v\x3\x2\x2\x2,-\a\x6\x2\x2-.\a"+
		"\xF\x2\x2./\x5\xE\b\x2/\x30\a\x10\x2\x2\x30\x31\a\x14\x2\x2\x31\r\x3\x2"+
		"\x2\x2\x32\x33\b\b\x1\x2\x33:\a,\x2\x2\x34:\a+\x2\x2\x35\x36\a\xF\x2\x2"+
		"\x36\x37\x5\xE\b\x2\x37\x38\a\x10\x2\x2\x38:\x3\x2\x2\x2\x39\x32\x3\x2"+
		"\x2\x2\x39\x34\x3\x2\x2\x2\x39\x35\x3\x2\x2\x2:\x43\x3\x2\x2\x2;<\f\a"+
		"\x2\x2<=\t\x2\x2\x2=\x42\x5\xE\b\b>?\f\x6\x2\x2?@\t\x3\x2\x2@\x42\x5\xE"+
		"\b\a\x41;\x3\x2\x2\x2\x41>\x3\x2\x2\x2\x42\x45\x3\x2\x2\x2\x43\x41\x3"+
		"\x2\x2\x2\x43\x44\x3\x2\x2\x2\x44\xF\x3\x2\x2\x2\x45\x43\x3\x2\x2\x2\a"+
		"\x19!\x39\x41\x43";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Suma_Platano.Lenguaje
