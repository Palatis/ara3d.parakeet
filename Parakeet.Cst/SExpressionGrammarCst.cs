// DO NOT EDIT: Autogenerated file created on 2024-01-27 10:00:21 AM. 

namespace Ara3D.Parakeet.Cst.SExpressionGrammarNameSpace
{
    /// <summary>
    /// Nodes = (Symbol|SymbolWithSpaces)
    /// </summary>
    public class CstAtom : CstNodeChoice
    {
        public static Rule Rule = CstNodeFactory.Grammar.Atom;
        public CstAtom(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstSymbol> Symbol => new CstNodeFilter<CstSymbol> (Children);
        public CstNodeFilter<CstSymbolWithSpaces> SymbolWithSpaces => new CstNodeFilter<CstSymbolWithSpaces> (Children);
    }

    /// <summary>
    /// Nodes = (Expr)*
    /// </summary>
    public class CstDocument : CstNode
    {
        public static Rule Rule = CstNodeFactory.Grammar.Document;
        public CstDocument(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstExpr> Expr => new CstNodeFilter<CstExpr> (Children);
    }

    /// <summary>
    /// Nodes = (Atom|List)
    /// </summary>
    public class CstExpr : CstNodeChoice
    {
        public static Rule Rule = CstNodeFactory.Grammar.Expr;
        public CstExpr(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstAtom> Atom => new CstNodeFilter<CstAtom> (Children);
        public CstNodeFilter<CstList> List => new CstNodeFilter<CstList> (Children);
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstIdentifier : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.Identifier;
        public CstIdentifier(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Nodes = (Expr)*
    /// </summary>
    public class CstList : CstNode
    {
        public static Rule Rule = CstNodeFactory.Grammar.List;
        public CstList(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstExpr> Expr => new CstNodeFilter<CstExpr> (Children);
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstSymbol : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.Symbol;
        public CstSymbol(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstSymbolWithSpaces : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.SymbolWithSpaces;
        public CstSymbolWithSpaces(string text) : base(text) { }
        // No children
    }

}
