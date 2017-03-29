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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ILenguajeVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class LenguajeBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, ILenguajeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>parentExpresion</c>
	/// labeled alternative in <see cref="LenguajeParser.expresion"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitParentExpresion([NotNull] LenguajeParser.ParentExpresionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>numeroExpresion</c>
	/// labeled alternative in <see cref="LenguajeParser.expresion"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNumeroExpresion([NotNull] LenguajeParser.NumeroExpresionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>mulDivExpresion</c>
	/// labeled alternative in <see cref="LenguajeParser.expresion"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMulDivExpresion([NotNull] LenguajeParser.MulDivExpresionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>valorExpresion</c>
	/// labeled alternative in <see cref="LenguajeParser.expresion"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValorExpresion([NotNull] LenguajeParser.ValorExpresionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>sumResExpresion</c>
	/// labeled alternative in <see cref="LenguajeParser.expresion"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSumResExpresion([NotNull] LenguajeParser.SumResExpresionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="LenguajeParser.compileUnit"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCompileUnit([NotNull] LenguajeParser.CompileUnitContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="LenguajeParser.programa"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPrograma([NotNull] LenguajeParser.ProgramaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="LenguajeParser.sentencia"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSentencia([NotNull] LenguajeParser.SentenciaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="LenguajeParser.declaracion_var"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDeclaracion_var([NotNull] LenguajeParser.Declaracion_varContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="LenguajeParser.asignacion_var"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAsignacion_var([NotNull] LenguajeParser.Asignacion_varContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="LenguajeParser.imprimir"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitImprimir([NotNull] LenguajeParser.ImprimirContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="LenguajeParser.expresion"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpresion([NotNull] LenguajeParser.ExpresionContext context) { return VisitChildren(context); }
}
} // namespace Suma_Platano.Lenguaje