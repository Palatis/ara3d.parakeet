// DO NOT EDIT: Autogenerated file created on 2023-04-19 11:03:00 PM. 
using System;
using System.Linq;
using Parakeet;

namespace Parakeet.Demos.Json
{
    public static class CstNodeFactory
    {
        public static CstNode Create(ParserTree node)
        {
            switch (node.Type)
            {
                case "Number": return new CstNumber(node.Contents);
                case "String": return new CstString(node.Contents);
                case "Constant": return new CstConstant(node.Contents);
                case "Array": return new CstArray(node.Contents);
                case "Member": return new CstMember(node.Children.Select(Create).ToArray());
                case "Object": return new CstObject(node.Contents);
                case "Element": return new CstElement(node.Children.Select(Create).ToArray());
                case "Json": return new CstJson(node.Children.Select(Create).ToArray());
                default: throw new Exception($"Unrecognized parse node {node.Type}");
            }
        }
    }
}
