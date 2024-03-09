// DO NOT EDIT: Autogenerated file created on 2024-03-09 10:52:18 AM. 
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
                case "Array": return new CstArray(node.Contents);
                case "Constant": return new CstConstant(node.Contents);
                case "Identifier": return new CstIdentifier(node.Contents);
                case "Json": return new CstJson(node.Contents);
                case "Member": return new CstMember(node.Children.Select(Create).ToArray());
                case "Number": return new CstNumber(node.Contents);
                case "Object": return new CstObject(node.Contents);
                case "String": return new CstString(node.Contents);
                default: throw new Exception($"Unrecognized parse node {node.Type}");
            }
        }
    }
}
