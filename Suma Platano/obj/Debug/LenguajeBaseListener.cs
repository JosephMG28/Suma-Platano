//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Joseph Gonzalez\Mis archivos\INTEC\11vo trimestre\Construccion de software\Suma Platano\Suma Platano\LenguajeDirectory\Lenguaje.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Suma_Platano.Lenguaje {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ILenguajeListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class LenguajeBaseListener : ILenguajeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>parentExpresion</c>
	/// labeled alternative in <see cref="LenguajeParser.expresion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParentExpresion([NotNull] LenguajeParser.ParentExpresionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parentExpresion</c>
	/// labeled alternative in <see cref="LenguajeParser.expresion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParentExpresion([NotNull] LenguajeParser.ParentExpresionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>numeroExpresion</c>
	/// labeled alternative in <see cref="LenguajeParser.expresion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumeroExpresion([NotNull] LenguajeParser.NumeroExpresionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>numeroExpresion</c>
	/// labeled alternative in <see cref="LenguajeParser.expresion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumeroExpresion([NotNull] LenguajeParser.NumeroExpresionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>mulDivExpresion</c>
	/// labeled alternative in <see cref="LenguajeParser.expresion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMulDivExpresion([NotNull] LenguajeParser.MulDivExpresionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>mulDivExpresion</c>
	/// labeled alternative in <see cref="LenguajeParser.expresion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMulDivExpresion([NotNull] LenguajeParser.MulDivExpresionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>valorExpresion</c>
	/// labeled alternative in <see cref="LenguajeParser.expresion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValorExpresion([NotNull] LenguajeParser.ValorExpresionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>valorExpresion</c>
	/// labeled alternative in <see cref="LenguajeParser.expresion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValorExpresion([NotNull] LenguajeParser.ValorExpresionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>sumResExpresion</c>
	/// labeled alternative in <see cref="LenguajeParser.expresion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSumResExpresion([NotNull] LenguajeParser.SumResExpresionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>sumResExpresion</c>
	/// labeled alternative in <see cref="LenguajeParser.expresion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSumResExpresion([NotNull] LenguajeParser.SumResExpresionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="LenguajeParser.compileUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompileUnit([NotNull] LenguajeParser.CompileUnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="LenguajeParser.compileUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompileUnit([NotNull] LenguajeParser.CompileUnitContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="LenguajeParser.programa"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrograma([NotNull] LenguajeParser.ProgramaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="LenguajeParser.programa"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrograma([NotNull] LenguajeParser.ProgramaContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="LenguajeParser.sentencia"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSentencia([NotNull] LenguajeParser.SentenciaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="LenguajeParser.sentencia"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSentencia([NotNull] LenguajeParser.SentenciaContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="LenguajeParser.declaracion_var"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclaracion_var([NotNull] LenguajeParser.Declaracion_varContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="LenguajeParser.declaracion_var"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclaracion_var([NotNull] LenguajeParser.Declaracion_varContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="LenguajeParser.asignacion_var"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsignacion_var([NotNull] LenguajeParser.Asignacion_varContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="LenguajeParser.asignacion_var"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsignacion_var([NotNull] LenguajeParser.Asignacion_varContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="LenguajeParser.imprimir"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImprimir([NotNull] LenguajeParser.ImprimirContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="LenguajeParser.imprimir"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImprimir([NotNull] LenguajeParser.ImprimirContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="LenguajeParser.expresion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpresion([NotNull] LenguajeParser.ExpresionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="LenguajeParser.expresion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpresion([NotNull] LenguajeParser.ExpresionContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Suma_Platano.Lenguaje
