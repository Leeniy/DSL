//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from d:\OneDrive\Desktop\DSL\DSL\Aufgabe_2\Speak.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SpeakParser"/>.
/// </summary>
/// [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
/// [System.CLSCompliant(false)]

namespace Aufgabe_2
{
	public interface ISpeakListener : IParseTreeListener {
		/// <summary>
		/// Enter a parse tree produced by <see cref="SpeakParser.chat"/>.
		/// </summary>
		/// <param name="context">The parse tree.</param>
		void EnterChat([NotNull] SpeakParser.ChatContext context);
		/// <summary>
		/// Exit a parse tree produced by <see cref="SpeakParser.chat"/>.
		/// </summary>
		/// <param name="context">The parse tree.</param>
		void ExitChat([NotNull] SpeakParser.ChatContext context);
		/// <summary>
		/// Enter a parse tree produced by <see cref="SpeakParser.line"/>.
		/// </summary>
		/// <param name="context">The parse tree.</param>
		void EnterLine([NotNull] SpeakParser.LineContext context);
		/// <summary>
		/// Exit a parse tree produced by <see cref="SpeakParser.line"/>.
		/// </summary>
		/// <param name="context">The parse tree.</param>
		void ExitLine([NotNull] SpeakParser.LineContext context);
		/// <summary>
		/// Enter a parse tree produced by <see cref="SpeakParser.name"/>.
		/// </summary>
		/// <param name="context">The parse tree.</param>
		void EnterName([NotNull] SpeakParser.NameContext context);
		/// <summary>
		/// Exit a parse tree produced by <see cref="SpeakParser.name"/>.
		/// </summary>
		/// <param name="context">The parse tree.</param>
		void ExitName([NotNull] SpeakParser.NameContext context);
		/// <summary>
		/// Enter a parse tree produced by <see cref="SpeakParser.opinion"/>.
		/// </summary>
		/// <param name="context">The parse tree.</param>
		void EnterOpinion([NotNull] SpeakParser.OpinionContext context);
		/// <summary>
		/// Exit a parse tree produced by <see cref="SpeakParser.opinion"/>.
		/// </summary>
		/// <param name="context">The parse tree.</param>
		void ExitOpinion([NotNull] SpeakParser.OpinionContext context);
	}
}