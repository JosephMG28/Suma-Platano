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
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class LenguajeLexer : Lexer {
	public const int
		COMENTARIO_SIMPLE=1, PROGRAMA=2, VARIABLE=3, IMPRIMIR=4, SI=5, ENTONCES=6, 
		PARA=7, MIENTRAS=8, LLAVE_A=9, LLAVE_C=10, CORCHETE_A=11, CORCHETE_C=12, 
		PARENTESIS_A=13, PARENTESIS_C=14, PUNTO=15, COMA=16, DOSPUNTOS=17, PUNTOyCOMA=18, 
		ASIGNACION=19, SUMA=20, RESTA=21, MULTIPLICACION=22, DIVISION=23, POTENCIA=24, 
		OP_INCREMENTO=25, OP_DECREMENTO=26, OP_Y=27, OP_O=28, OP_NEGACION=29, 
		OP_MAYOR_Q=30, OP_MENOR_Q=31, OP_MAYOR_IG=32, OP_MENOR_IG=33, OP_IGUALDAD=34, 
		OP_DESIGUALDAD=35, OP_SUMAyASIG=36, OP_RESTAyASIG=37, OP_MULTyASIG=38, 
		OP_DIVyASIG=39, BOOLEAN=40, ID=41, NUMERO=42, ESPACIOeB=43;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"COMENTARIO_SIMPLE", "PROGRAMA", "VARIABLE", "IMPRIMIR", "SI", "ENTONCES", 
		"PARA", "MIENTRAS", "LLAVE_A", "LLAVE_C", "CORCHETE_A", "CORCHETE_C", 
		"PARENTESIS_A", "PARENTESIS_C", "PUNTO", "COMA", "DOSPUNTOS", "PUNTOyCOMA", 
		"ASIGNACION", "SUMA", "RESTA", "MULTIPLICACION", "DIVISION", "POTENCIA", 
		"OP_INCREMENTO", "OP_DECREMENTO", "OP_Y", "OP_O", "OP_NEGACION", "OP_MAYOR_Q", 
		"OP_MENOR_Q", "OP_MAYOR_IG", "OP_MENOR_IG", "OP_IGUALDAD", "OP_DESIGUALDAD", 
		"OP_SUMAyASIG", "OP_RESTAyASIG", "OP_MULTyASIG", "OP_DIVyASIG", "BOOLEAN", 
		"ID", "NUMERO", "ESPACIOeB"
	};


	public LenguajeLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

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

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2-\x119\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t"+
		"*\x4+\t+\x4,\t,\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\a\x2_\n\x2\f\x2\xE\x2\x62"+
		"\v\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3"+
		"\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3"+
		"\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3"+
		"\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\r\x3"+
		"\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x3\x11\x3\x12\x3\x12\x3"+
		"\x13\x3\x13\x3\x14\x3\x14\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3"+
		"\x18\x3\x18\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3"+
		"\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3"+
		" \x3 \x3!\x3!\x3!\x3\"\x3\"\x3\"\x3#\x3#\x3#\x3$\x3$\x3$\x3%\x3%\x3%\x3"+
		"&\x3&\x3&\x3\'\x3\'\x3\'\x3(\x3(\x3(\x3)\x3)\x3)\x3)\x3)\x3)\x3)\x3)\x3"+
		")\x3)\x3)\x3)\x3)\x3)\x5)\xF3\n)\x3*\x3*\a*\xF7\n*\f*\xE*\xFA\v*\x3+\x3"+
		"+\x3+\a+\xFF\n+\f+\xE+\x102\v+\x3+\x3+\a+\x106\n+\f+\xE+\x109\v+\x3+\x3"+
		"+\x6+\x10D\n+\r+\xE+\x10E\x5+\x111\n+\x3,\x6,\x114\n,\r,\xE,\x115\x3,"+
		"\x3,\x2\x2\x2-\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t"+
		"\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F"+
		"\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19"+
		"\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?"+
		"\x2!\x41\x2\"\x43\x2#\x45\x2$G\x2%I\x2&K\x2\'M\x2(O\x2)Q\x2*S\x2+U\x2"+
		",W\x2-\x3\x2\b\t\x2\v\f\xF\xF\"\"\x32;\x43\\\x61\x61\x63|\x5\x2\x43\\"+
		"\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\x3\x2\x33;\x3\x2\x32;\x5\x2"+
		"\v\f\xF\xF\"\"\x121\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2"+
		"\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2"+
		"\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3"+
		"\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2"+
		"\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'"+
		"\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2"+
		"\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37"+
		"\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3"+
		"\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2"+
		"G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2"+
		"\x2\x2\x2Q\x3\x2\x2\x2\x2S\x3\x2\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2\x2\x2"+
		"\x3Y\x3\x2\x2\x2\x5\x65\x3\x2\x2\x2\an\x3\x2\x2\x2\tw\x3\x2\x2\x2\v\x80"+
		"\x3\x2\x2\x2\r\x83\x3\x2\x2\x2\xF\x8C\x3\x2\x2\x2\x11\x91\x3\x2\x2\x2"+
		"\x13\x9A\x3\x2\x2\x2\x15\x9C\x3\x2\x2\x2\x17\x9E\x3\x2\x2\x2\x19\xA0\x3"+
		"\x2\x2\x2\x1B\xA2\x3\x2\x2\x2\x1D\xA4\x3\x2\x2\x2\x1F\xA6\x3\x2\x2\x2"+
		"!\xA8\x3\x2\x2\x2#\xAA\x3\x2\x2\x2%\xAC\x3\x2\x2\x2\'\xAE\x3\x2\x2\x2"+
		")\xB0\x3\x2\x2\x2+\xB2\x3\x2\x2\x2-\xB4\x3\x2\x2\x2/\xB6\x3\x2\x2\x2\x31"+
		"\xB8\x3\x2\x2\x2\x33\xBA\x3\x2\x2\x2\x35\xBD\x3\x2\x2\x2\x37\xC0\x3\x2"+
		"\x2\x2\x39\xC3\x3\x2\x2\x2;\xC6\x3\x2\x2\x2=\xC8\x3\x2\x2\x2?\xCA\x3\x2"+
		"\x2\x2\x41\xCC\x3\x2\x2\x2\x43\xCF\x3\x2\x2\x2\x45\xD2\x3\x2\x2\x2G\xD5"+
		"\x3\x2\x2\x2I\xD8\x3\x2\x2\x2K\xDB\x3\x2\x2\x2M\xDE\x3\x2\x2\x2O\xE1\x3"+
		"\x2\x2\x2Q\xF2\x3\x2\x2\x2S\xF4\x3\x2\x2\x2U\x110\x3\x2\x2\x2W\x113\x3"+
		"\x2\x2\x2YZ\a/\x2\x2Z[\a/\x2\x2[\\\a@\x2\x2\\`\x3\x2\x2\x2]_\t\x2\x2\x2"+
		"^]\x3\x2\x2\x2_\x62\x3\x2\x2\x2`^\x3\x2\x2\x2`\x61\x3\x2\x2\x2\x61\x63"+
		"\x3\x2\x2\x2\x62`\x3\x2\x2\x2\x63\x64\b\x2\x2\x2\x64\x4\x3\x2\x2\x2\x65"+
		"\x66\ar\x2\x2\x66g\at\x2\x2gh\aq\x2\x2hi\ai\x2\x2ij\at\x2\x2jk\a\x63\x2"+
		"\x2kl\ao\x2\x2lm\a\x63\x2\x2m\x6\x3\x2\x2\x2no\ax\x2\x2op\a\x63\x2\x2"+
		"pq\at\x2\x2qr\ak\x2\x2rs\a\x63\x2\x2st\a\x64\x2\x2tu\an\x2\x2uv\ag\x2"+
		"\x2v\b\x3\x2\x2\x2wx\ak\x2\x2xy\ao\x2\x2yz\ar\x2\x2z{\at\x2\x2{|\ak\x2"+
		"\x2|}\ao\x2\x2}~\ak\x2\x2~\x7F\at\x2\x2\x7F\n\x3\x2\x2\x2\x80\x81\aU\x2"+
		"\x2\x81\x82\ak\x2\x2\x82\f\x3\x2\x2\x2\x83\x84\aG\x2\x2\x84\x85\ap\x2"+
		"\x2\x85\x86\av\x2\x2\x86\x87\aq\x2\x2\x87\x88\ap\x2\x2\x88\x89\a\x65\x2"+
		"\x2\x89\x8A\ag\x2\x2\x8A\x8B\au\x2\x2\x8B\xE\x3\x2\x2\x2\x8C\x8D\aR\x2"+
		"\x2\x8D\x8E\a\x63\x2\x2\x8E\x8F\at\x2\x2\x8F\x90\a\x63\x2\x2\x90\x10\x3"+
		"\x2\x2\x2\x91\x92\aO\x2\x2\x92\x93\ak\x2\x2\x93\x94\ag\x2\x2\x94\x95\a"+
		"p\x2\x2\x95\x96\av\x2\x2\x96\x97\at\x2\x2\x97\x98\a\x63\x2\x2\x98\x99"+
		"\au\x2\x2\x99\x12\x3\x2\x2\x2\x9A\x9B\a}\x2\x2\x9B\x14\x3\x2\x2\x2\x9C"+
		"\x9D\a\x7F\x2\x2\x9D\x16\x3\x2\x2\x2\x9E\x9F\a]\x2\x2\x9F\x18\x3\x2\x2"+
		"\x2\xA0\xA1\a_\x2\x2\xA1\x1A\x3\x2\x2\x2\xA2\xA3\a*\x2\x2\xA3\x1C\x3\x2"+
		"\x2\x2\xA4\xA5\a+\x2\x2\xA5\x1E\x3\x2\x2\x2\xA6\xA7\a\x30\x2\x2\xA7 \x3"+
		"\x2\x2\x2\xA8\xA9\a.\x2\x2\xA9\"\x3\x2\x2\x2\xAA\xAB\a<\x2\x2\xAB$\x3"+
		"\x2\x2\x2\xAC\xAD\a=\x2\x2\xAD&\x3\x2\x2\x2\xAE\xAF\a?\x2\x2\xAF(\x3\x2"+
		"\x2\x2\xB0\xB1\a-\x2\x2\xB1*\x3\x2\x2\x2\xB2\xB3\a/\x2\x2\xB3,\x3\x2\x2"+
		"\x2\xB4\xB5\a,\x2\x2\xB5.\x3\x2\x2\x2\xB6\xB7\a\x31\x2\x2\xB7\x30\x3\x2"+
		"\x2\x2\xB8\xB9\a`\x2\x2\xB9\x32\x3\x2\x2\x2\xBA\xBB\a-\x2\x2\xBB\xBC\a"+
		"-\x2\x2\xBC\x34\x3\x2\x2\x2\xBD\xBE\a/\x2\x2\xBE\xBF\a/\x2\x2\xBF\x36"+
		"\x3\x2\x2\x2\xC0\xC1\a[\x2\x2\xC1\xC2\a[\x2\x2\xC2\x38\x3\x2\x2\x2\xC3"+
		"\xC4\aQ\x2\x2\xC4\xC5\aQ\x2\x2\xC5:\x3\x2\x2\x2\xC6\xC7\a%\x2\x2\xC7<"+
		"\x3\x2\x2\x2\xC8\xC9\a@\x2\x2\xC9>\x3\x2\x2\x2\xCA\xCB\a>\x2\x2\xCB@\x3"+
		"\x2\x2\x2\xCC\xCD\a@\x2\x2\xCD\xCE\a?\x2\x2\xCE\x42\x3\x2\x2\x2\xCF\xD0"+
		"\a>\x2\x2\xD0\xD1\a?\x2\x2\xD1\x44\x3\x2\x2\x2\xD2\xD3\a>\x2\x2\xD3\xD4"+
		"\a@\x2\x2\xD4\x46\x3\x2\x2\x2\xD5\xD6\a@\x2\x2\xD6\xD7\a>\x2\x2\xD7H\x3"+
		"\x2\x2\x2\xD8\xD9\a-\x2\x2\xD9\xDA\a?\x2\x2\xDAJ\x3\x2\x2\x2\xDB\xDC\a"+
		"/\x2\x2\xDC\xDD\a?\x2\x2\xDDL\x3\x2\x2\x2\xDE\xDF\a,\x2\x2\xDF\xE0\a?"+
		"\x2\x2\xE0N\x3\x2\x2\x2\xE1\xE2\a\x31\x2\x2\xE2\xE3\a?\x2\x2\xE3P\x3\x2"+
		"\x2\x2\xE4\xE5\ax\x2\x2\xE5\xE6\ag\x2\x2\xE6\xE7\at\x2\x2\xE7\xE8\a\x66"+
		"\x2\x2\xE8\xE9\a\x63\x2\x2\xE9\xEA\a\x66\x2\x2\xEA\xEB\ag\x2\x2\xEB\xEC"+
		"\at\x2\x2\xEC\xF3\aq\x2\x2\xED\xEE\ah\x2\x2\xEE\xEF\a\x63\x2\x2\xEF\xF0"+
		"\an\x2\x2\xF0\xF1\au\x2\x2\xF1\xF3\aq\x2\x2\xF2\xE4\x3\x2\x2\x2\xF2\xED"+
		"\x3\x2\x2\x2\xF3R\x3\x2\x2\x2\xF4\xF8\t\x3\x2\x2\xF5\xF7\t\x4\x2\x2\xF6"+
		"\xF5\x3\x2\x2\x2\xF7\xFA\x3\x2\x2\x2\xF8\xF6\x3\x2\x2\x2\xF8\xF9\x3\x2"+
		"\x2\x2\xF9T\x3\x2\x2\x2\xFA\xF8\x3\x2\x2\x2\xFB\x111\a\x32\x2\x2\xFC\x100"+
		"\t\x5\x2\x2\xFD\xFF\t\x6\x2\x2\xFE\xFD\x3\x2\x2\x2\xFF\x102\x3\x2\x2\x2"+
		"\x100\xFE\x3\x2\x2\x2\x100\x101\x3\x2\x2\x2\x101\x111\x3\x2\x2\x2\x102"+
		"\x100\x3\x2\x2\x2\x103\x107\t\x5\x2\x2\x104\x106\t\x6\x2\x2\x105\x104"+
		"\x3\x2\x2\x2\x106\x109\x3\x2\x2\x2\x107\x105\x3\x2\x2\x2\x107\x108\x3"+
		"\x2\x2\x2\x108\x10A\x3\x2\x2\x2\x109\x107\x3\x2\x2\x2\x10A\x10C\a\x30"+
		"\x2\x2\x10B\x10D\t\x6\x2\x2\x10C\x10B\x3\x2\x2\x2\x10D\x10E\x3\x2\x2\x2"+
		"\x10E\x10C\x3\x2\x2\x2\x10E\x10F\x3\x2\x2\x2\x10F\x111\x3\x2\x2\x2\x110"+
		"\xFB\x3\x2\x2\x2\x110\xFC\x3\x2\x2\x2\x110\x103\x3\x2\x2\x2\x111V\x3\x2"+
		"\x2\x2\x112\x114\t\a\x2\x2\x113\x112\x3\x2\x2\x2\x114\x115\x3\x2\x2\x2"+
		"\x115\x113\x3\x2\x2\x2\x115\x116\x3\x2\x2\x2\x116\x117\x3\x2\x2\x2\x117"+
		"\x118\b,\x2\x2\x118X\x3\x2\x2\x2\v\x2`\xF2\xF8\x100\x107\x10E\x110\x115"+
		"\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Suma_Platano.Lenguaje
