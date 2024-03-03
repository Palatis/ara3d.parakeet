// DO NOT EDIT: Autogenerated file created on 2024-03-02 9:43:36 PM. 
using System;
using System.Linq;
using System.Collections.Generic;
using Ara3D.Parakeet.Grammars;

namespace Ara3D.Parakeet.Cst.MustacheGrammarNameSpace
{
    public class CstNodeFactory
    {
        public static readonly MustacheGrammar Grammar = new MustacheGrammar();
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
                case "Block": return new CstBlock(node.Children.Select(Create).ToArray());
                case "Comment": return new CstComment(node.Children.Select(Create).ToArray());
                case "Content": return new CstContent(node.Children.Select(Create).ToArray());
                case "Document": return new CstDocument(node.Children.Select(Create).ToArray());
                case "EndSection": return new CstEndSection(node.Children.Select(Create).ToArray());
                case "Identifier": return new CstIdentifier(node.Contents);
                case "InvertedSection": return new CstInvertedSection(node.Children.Select(Create).ToArray());
                case "Key": return new CstKey(node.Contents);
                case "Partial": return new CstPartial(node.Children.Select(Create).ToArray());
                case "PlainText": return new CstPlainText(node.Contents);
                case "RestOfLine": return new CstRestOfLine(node.Contents);
                case "Section": return new CstSection(node.Children.Select(Create).ToArray());
                case "StartInvertedSection": return new CstStartInvertedSection(node.Children.Select(Create).ToArray());
                case "StartSection": return new CstStartSection(node.Children.Select(Create).ToArray());
                case "UnescapedVariable": return new CstUnescapedVariable(node.Children.Select(Create).ToArray());
                case "Variable": return new CstVariable(node.Children.Select(Create).ToArray());
                default: throw new Exception($"Unrecognized parse node {node.Type}");
            }
        }
    }
}