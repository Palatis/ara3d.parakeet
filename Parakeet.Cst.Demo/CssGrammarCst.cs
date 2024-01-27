// DO NOT EDIT: Autogenerated file created on 2024-01-27 10:00:20 AM. 
using System;
using System.Linq;

namespace Parakeet.Cst.CssGrammarNameSpace
{
    /// <summary>
    /// Nodes = (AttribOperator+(AttribValue)?)
    /// </summary>
    public class CstAttrib : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.Grammar.Attrib;
        public CstAttrib(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstAttribOperator> AttribOperator => new CstNodeFilter<CstAttribOperator> (Children);
        public CstNodeFilter<CstAttribValue> AttribValue => new CstNodeFilter<CstAttribValue> (Children);
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstAttribOperator : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.AttribOperator;
        public CstAttribOperator(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstAttribValue : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.AttribValue;
        public CstAttribValue(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstCharSet : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.CharSet;
        public CstCharSet(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstClass : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.Class;
        public CstClass(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstCombinator : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.Combinator;
        public CstCombinator(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Nodes = ((Combinator)?+Selector)
    /// </summary>
    public class CstCombinedSelector : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.Grammar.CombinedSelector;
        public CstCombinedSelector(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstCombinator> Combinator => new CstNodeFilter<CstCombinator> (Children);
        public CstNodeFilter<CstSelector> Selector => new CstNodeFilter<CstSelector> (Children);
    }

    /// <summary>
    /// Nodes = (RuleSet|MediaList|Page)
    /// </summary>
    public class CstContent : CstNodeChoice
    {
        public static Rule Rule = CstNodeFactory.Grammar.Content;
        public CstContent(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstRuleSet> RuleSet => new CstNodeFilter<CstRuleSet> (Children);
        public CstNodeFilter<CstMediaList> MediaList => new CstNodeFilter<CstMediaList> (Children);
        public CstNodeFilter<CstPage> Page => new CstNodeFilter<CstPage> (Children);
    }

    /// <summary>
    /// Nodes = (Content)*
    /// </summary>
    public class CstContents : CstNode
    {
        public static Rule Rule = CstNodeFactory.Grammar.Contents;
        public CstContents(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstContent> Content => new CstNodeFilter<CstContent> (Children);
    }

    /// <summary>
    /// Nodes = (Property+Expr+(Prio)?)
    /// </summary>
    public class CstDeclaration : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.Grammar.Declaration;
        public CstDeclaration(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstProperty> Property => new CstNodeFilter<CstProperty> (Children);
        public CstNodeFilter<CstExpr> Expr => new CstNodeFilter<CstExpr> (Children);
        public CstNodeFilter<CstPrio> Prio => new CstNodeFilter<CstPrio> (Children);
    }

    /// <summary>
    /// Nodes = (Selector)*
    /// </summary>
    public class CstDeclarations : CstNode
    {
        public static Rule Rule = CstNodeFactory.Grammar.Declarations;
        public CstDeclarations(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstSelector> Selector => new CstNodeFilter<CstSelector> (Children);
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstElementName : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.ElementName;
        public CstElementName(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Nodes = (Term+(((Operator)?+Term))*+Operator)
    /// </summary>
    public class CstExpr : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.Grammar.Expr;
        public CstExpr(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstTerm> Term => new CstNodeFilter<CstTerm> (Children);
        public CstNodeFilter<CstOperator> Operator => new CstNodeFilter<CstOperator> (Children);
    }

    /// <summary>
    /// Nodes = (Expr)?
    /// </summary>
    public class CstFunction : CstNode
    {
        public static Rule Rule = CstNodeFactory.Grammar.Function;
        public CstFunction(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstExpr> Expr => new CstNodeFilter<CstExpr> (Children);
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstHexColor : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.HexColor;
        public CstHexColor(string text) : base(text) { }
        // No children
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
    /// Nodes = (MediaList)?
    /// </summary>
    public class CstImport : CstNode
    {
        public static Rule Rule = CstNodeFactory.Grammar.Import;
        public CstImport(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstMediaList> MediaList => new CstNodeFilter<CstMediaList> (Children);
    }

    /// <summary>
    /// Nodes = (Import)*
    /// </summary>
    public class CstImports : CstNode
    {
        public static Rule Rule = CstNodeFactory.Grammar.Imports;
        public CstImports(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstImport> Import => new CstNodeFilter<CstImport> (Children);
    }

    /// <summary>
    /// Nodes = (Medium)*
    /// </summary>
    public class CstMediaList : CstNode
    {
        public static Rule Rule = CstNodeFactory.Grammar.MediaList;
        public CstMediaList(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstMedium> Medium => new CstNodeFilter<CstMedium> (Children);
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstMedium : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.Medium;
        public CstMedium(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstOperator : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.Operator;
        public CstOperator(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Nodes = ((PseudoPage)?+PageDeclarations)
    /// </summary>
    public class CstPage : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.Grammar.Page;
        public CstPage(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstPseudoPage> PseudoPage => new CstNodeFilter<CstPseudoPage> (Children);
        public CstNodeFilter<CstPageDeclarations> PageDeclarations => new CstNodeFilter<CstPageDeclarations> (Children);
    }

    /// <summary>
    /// Nodes = (Declaration)*
    /// </summary>
    public class CstPageDeclarations : CstNode
    {
        public static Rule Rule = CstNodeFactory.Grammar.PageDeclarations;
        public CstPageDeclarations(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstDeclaration> Declaration => new CstNodeFilter<CstDeclaration> (Children);
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstPrio : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.Prio;
        public CstPrio(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstProperty : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.Property;
        public CstProperty(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Nodes = Function
    /// </summary>
    public class CstPseudo : CstNode
    {
        public static Rule Rule = CstNodeFactory.Grammar.Pseudo;
        public CstPseudo(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstFunction> Function => new CstNodeFilter<CstFunction> (Children);
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstPseudoPage : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.PseudoPage;
        public CstPseudoPage(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Nodes = (Selectors+Declarations)
    /// </summary>
    public class CstRuleSet : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.Grammar.RuleSet;
        public CstRuleSet(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstSelectors> Selectors => new CstNodeFilter<CstSelectors> (Children);
        public CstNodeFilter<CstDeclarations> Declarations => new CstNodeFilter<CstDeclarations> (Children);
    }

    /// <summary>
    /// Nodes = (SimpleSelector+(CombinedSelector)?)
    /// </summary>
    public class CstSelector : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.Grammar.Selector;
        public CstSelector(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstSimpleSelector> SimpleSelector => new CstNodeFilter<CstSimpleSelector> (Children);
        public CstNodeFilter<CstCombinedSelector> CombinedSelector => new CstNodeFilter<CstCombinedSelector> (Children);
    }

    /// <summary>
    /// Nodes = (Class|Attrib|Pseudo)
    /// </summary>
    public class CstSelectorPart : CstNodeChoice
    {
        public static Rule Rule = CstNodeFactory.Grammar.SelectorPart;
        public CstSelectorPart(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstClass> Class => new CstNodeFilter<CstClass> (Children);
        public CstNodeFilter<CstAttrib> Attrib => new CstNodeFilter<CstAttrib> (Children);
        public CstNodeFilter<CstPseudo> Pseudo => new CstNodeFilter<CstPseudo> (Children);
    }

    /// <summary>
    /// Nodes = (Selector)*
    /// </summary>
    public class CstSelectors : CstNode
    {
        public static Rule Rule = CstNodeFactory.Grammar.Selectors;
        public CstSelectors(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstSelector> Selector => new CstNodeFilter<CstSelector> (Children);
    }

    /// <summary>
    /// Nodes = ((ElementName+(SelectorPart)*)|(SelectorPart)+)
    /// </summary>
    public class CstSimpleSelector : CstNodeChoice
    {
        public static Rule Rule = CstNodeFactory.Grammar.SimpleSelector;
        public CstSimpleSelector(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstElementName> ElementName => new CstNodeFilter<CstElementName> (Children);
        public CstNodeFilter<CstSelectorPart> SelectorPart => new CstNodeFilter<CstSelectorPart> (Children);
    }

    /// <summary>
    /// Nodes = ((CharSet)?+Imports+Contents)
    /// </summary>
    public class CstStyleSheet : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.Grammar.StyleSheet;
        public CstStyleSheet(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstCharSet> CharSet => new CstNodeFilter<CstCharSet> (Children);
        public CstNodeFilter<CstImports> Imports => new CstNodeFilter<CstImports> (Children);
        public CstNodeFilter<CstContents> Contents => new CstNodeFilter<CstContents> (Children);
    }

    /// <summary>
    /// Nodes = ((UnaryOperator)?+(HexColor|Function))
    /// </summary>
    public class CstTerm : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.Grammar.Term;
        public CstTerm(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstUnaryOperator> UnaryOperator => new CstNodeFilter<CstUnaryOperator> (Children);
        public CstNodeFilter<CstHexColor> HexColor => new CstNodeFilter<CstHexColor> (Children);
        public CstNodeFilter<CstFunction> Function => new CstNodeFilter<CstFunction> (Children);
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstUnaryOperator : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.UnaryOperator;
        public CstUnaryOperator(string text) : base(text) { }
        // No children
    }

}
