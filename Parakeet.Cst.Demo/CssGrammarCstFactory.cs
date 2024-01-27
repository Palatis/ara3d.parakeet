// DO NOT EDIT: Autogenerated file created on 2024-01-27 2:01:53 AM. 
using System;
using System.Linq;
using System.Collections.Generic;
using Parakeet.Grammars;

namespace Parakeet.Cst.CssGrammarNameSpace
{
    public class CstNodeFactory
    {
        public static readonly CssGrammar Grammar = new CssGrammar();
        public Dictionary<CstNode, ParserTreeNode> Lookup { get;} = new Dictionary<CstNode, ParserTreeNode>();
        public CstNode Create(ParserTreeNode node)
        {
            var r = InternalCreate(node);
            Lookup.Add(r, node);
            return r;
        }
        public CstNode InternalCreate(ParserTreeNode node)
        {
            switch (node.Type)
            {
                case "Attrib": return new CstAttrib(node.Children.Select(Create).ToArray());
                case "AttribOperator": return new CstAttribOperator(node.Contents);
                case "AttribValue": return new CstAttribValue(node.Contents);
                case "CharSet": return new CstCharSet(node.Contents);
                case "Class": return new CstClass(node.Contents);
                case "Combinator": return new CstCombinator(node.Contents);
                case "CombinedSelector": return new CstCombinedSelector(node.Children.Select(Create).ToArray());
                case "Content": return new CstContent(node.Children.Select(Create).ToArray());
                case "Contents": return new CstContents(node.Children.Select(Create).ToArray());
                case "Declaration": return new CstDeclaration(node.Children.Select(Create).ToArray());
                case "Declarations": return new CstDeclarations(node.Children.Select(Create).ToArray());
                case "ElementName": return new CstElementName(node.Contents);
                case "Expr": return new CstExpr(node.Children.Select(Create).ToArray());
                case "Function": return new CstFunction(node.Children.Select(Create).ToArray());
                case "HexColor": return new CstHexColor(node.Contents);
                case "Identifier": return new CstIdentifier(node.Contents);
                case "Import": return new CstImport(node.Children.Select(Create).ToArray());
                case "Imports": return new CstImports(node.Children.Select(Create).ToArray());
                case "MediaList": return new CstMediaList(node.Children.Select(Create).ToArray());
                case "Medium": return new CstMedium(node.Contents);
                case "Operator": return new CstOperator(node.Contents);
                case "Page": return new CstPage(node.Children.Select(Create).ToArray());
                case "PageDeclarations": return new CstPageDeclarations(node.Children.Select(Create).ToArray());
                case "Prio": return new CstPrio(node.Contents);
                case "Property": return new CstProperty(node.Contents);
                case "Pseudo": return new CstPseudo(node.Children.Select(Create).ToArray());
                case "PseudoPage": return new CstPseudoPage(node.Contents);
                case "RuleSet": return new CstRuleSet(node.Children.Select(Create).ToArray());
                case "Selector": return new CstSelector(node.Children.Select(Create).ToArray());
                case "SelectorPart": return new CstSelectorPart(node.Children.Select(Create).ToArray());
                case "Selectors": return new CstSelectors(node.Children.Select(Create).ToArray());
                case "SimpleSelector": return new CstSimpleSelector(node.Children.Select(Create).ToArray());
                case "StyleSheet": return new CstStyleSheet(node.Children.Select(Create).ToArray());
                case "Term": return new CstTerm(node.Children.Select(Create).ToArray());
                case "UnaryOperator": return new CstUnaryOperator(node.Contents);
                default: throw new Exception($"Unrecognized parse node {node.Type}");
            }
        }
    }
}