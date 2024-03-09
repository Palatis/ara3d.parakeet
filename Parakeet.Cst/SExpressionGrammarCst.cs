// DO NOT EDIT: Autogenerated file created on 2024-03-09 10:52:19 AM. 
using System;
using System.Linq;

namespace Ara3D.Parakeet.Cst.SExpressionGrammarNameSpace
{
    /// <summary>This interface exists to make it easy to auto-generate type switches</summary>
    public interface ISExpressionCstNode { }

    /// <summary>
    /// Rule = Atom ::= ((Symbol|SymbolWithSpaces|Integer|Float)+((Spaces)?|Comment))
    /// Nodes = (Symbol|SymbolWithSpaces)
    /// </summary>
    public class CstAtom : CstNodeChoice, ISExpressionCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Atom;
        public CstAtom(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstSymbol> Symbol => new CstNodeFilter<CstSymbol> (Children);
        public CstNodeFilter<CstSymbolWithSpaces> SymbolWithSpaces => new CstNodeFilter<CstSymbolWithSpaces> (Children);
    }

    /// <summary>
    /// Rule = Document ::= ((((Spaces)?|Comment)+(Expr)*+EndOfInput)+((Spaces)?|Comment))
    /// Nodes = (Expr)*
    /// </summary>
    public class CstDocument : CstNode, ISExpressionCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Document;
        public CstDocument(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstExpr> Expr => new CstNodeFilter<CstExpr> (Children);
    }

    /// <summary>
    /// Rule = Expr ::= ((Atom|List)+((Spaces)?|Comment))
    /// Nodes = (Atom|List)
    /// </summary>
    public class CstExpr : CstNodeChoice, ISExpressionCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Expr;
        public CstExpr(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstAtom> Atom => new CstNodeFilter<CstAtom> (Children);
        public CstNodeFilter<CstList> List => new CstNodeFilter<CstList> (Children);
    }

    /// <summary>
    /// Rule = Identifier ::= ((IdentifierFirstChar+(IdentifierChar)*)+((Spaces)?|Comment))
    /// Nodes = 
    /// </summary>
    public class CstIdentifier : CstNodeLeaf, ISExpressionCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Identifier;
        public CstIdentifier(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = List ::= (('('+(Expr)*+')')+((Spaces)?|Comment))
    /// Nodes = (Expr)*
    /// </summary>
    public class CstList : CstNode, ISExpressionCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.List;
        public CstList(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstExpr> Expr => new CstNodeFilter<CstExpr> (Children);
    }

    /// <summary>
    /// Rule = Symbol ::= (((SymbolChar|Digit))*+((Spaces)?|Comment))
    /// Nodes = 
    /// </summary>
    public class CstSymbol : CstNodeLeaf, ISExpressionCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Symbol;
        public CstSymbol(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = SymbolWithSpaces ::= (('|'+(SymbolCharWithSpace)*+'|')+((Spaces)?|Comment))
    /// Nodes = 
    /// </summary>
    public class CstSymbolWithSpaces : CstNodeLeaf, ISExpressionCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.SymbolWithSpaces;
        public CstSymbolWithSpaces(string text) : base(text) { }
        // No children
    }

}
