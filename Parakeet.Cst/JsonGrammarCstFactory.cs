// DO NOT EDIT: Autogenerated file created on 2024-03-19 10:22:21 PM. 
using System;
using System.Linq;
using System.Collections.Generic;
using Ara3D.Parakeet.Grammars;

namespace Ara3D.Parakeet.Cst.JsonGrammarNameSpace
{
    public class CstNodeFactory : INodeFactory
    {
        public static JsonGrammar StaticGrammar = JsonGrammar.Instance;
        public IGrammar Grammar { get; } = StaticGrammar;
        public CstNode Create(ParserTreeNode node)
        {
            switch (node.Type)
            {
                case "Array": return new CstArray(node, node.Contents);
                case "Constant": return new CstConstant(node, node.Contents);
                case "Identifier": return new CstIdentifier(node, node.Contents);
                case "Json": return new CstJson(node, node.Contents);
                case "Member": return new CstMember(node, node.Children.Select(Create).ToArray());
                case "Number": return new CstNumber(node, node.Contents);
                case "Object": return new CstObject(node, node.Children.Select(Create).ToArray());
                case "String": return new CstString(node, node.Contents);
                default: throw new Exception($"Unrecognized parse node {node.Type}");
            }
        }
    }
}
