// DO NOT EDIT: Autogenerated file created on 2023-04-19 11:03:00 PM. 
using System;
using System.Linq;
using Parakeet;

namespace Parakeet.Demos.Json
{
    // Original Rule: (Integer+(Fraction)?+(Exponent)?)
    // Only Nodes: 
    // Optimized only nodes: 
    public class CstNumber : CstLeaf
    {
        public CstNumber(string text) : base(text) { }
        public override CstNode Transform(Func<CstNode, CstNode> f) => new CstNumber(Text);
        // No children
    }

    // Original Rule: ('"'+_RECOVER_+(StringChar)*+'"')
    // Only Nodes: 
    // Optimized only nodes: 
    public class CstString : CstLeaf
    {
        public CstString(string text) : base(text) { }
        public override CstNode Transform(Func<CstNode, CstNode> f) => new CstString(Text);
        // No children
    }

    // Original Rule: (("false"|"true"|"null")+!(IdentifierChar))
    // Only Nodes: 
    // Optimized only nodes: 
    public class CstConstant : CstLeaf
    {
        public CstConstant(string text) : base(text) { }
        public override CstNode Transform(Func<CstNode, CstNode> f) => new CstConstant(Text);
        // No children
    }

    // Original Rule: ('['+_RECOVER_+WS+(Elements)?+WS+']')
    // Only Nodes: ((Element+(Element)*))?
    // Optimized only nodes: (Element)*
    public class CstArray : CstLeaf
    {
        public CstArray(string text) : base(text) { }
        public override CstNode Transform(Func<CstNode, CstNode> f) => new CstArray(Text);
        public CstZeroOrMore<CstElement> Element => Children[0] as CstZeroOrMore<CstElement>;
    }

    // Original Rule: (String+_RECOVER_+WS+':'+WS+Element)
    // Only Nodes: (String+Element)
    // Optimized only nodes: (String+Element)
    public class CstMember : CstSequence
    {
        public CstMember(params CstNode[] children) : base(children) { }
        public override CstNode Transform(Func<CstNode, CstNode> f) => new CstMember(Children.Select(f).ToArray());
        public CstString String => Children[0] as CstString;
        public CstElement Element => Children[1] as CstElement;
    }

    // Original Rule: ('{'+_RECOVER_+WS+(Members)?+'}')
    // Only Nodes: ((Member+(Member)*))?
    // Optimized only nodes: (Member)*
    public class CstObject : CstLeaf
    {
        public CstObject(string text) : base(text) { }
        public override CstNode Transform(Func<CstNode, CstNode> f) => new CstObject(Text);
        public CstZeroOrMore<CstMember> Member => Children[0] as CstZeroOrMore<CstMember>;
    }

    // Original Rule: (Object|Array|String|Number|Constant)
    // Only Nodes: (Object|Array|String|Number|Constant)
    // Optimized only nodes: (Object|Array|String|Number|Constant)
    public class CstElement : CstChoice
    {
        public CstElement(params CstNode[] children) : base(children) { }
        public override CstNode Transform(Func<CstNode, CstNode> f) => new CstElement(Children.Select(f).ToArray());
        public CstObject Object => Children[0] as CstObject;
        public CstArray Array => Children[0] as CstArray;
        public CstString String => Children[0] as CstString;
        public CstNumber Number => Children[0] as CstNumber;
        public CstConstant Constant => Children[0] as CstConstant;
    }

    // Original Rule: (WS+Element+WS)
    // Only Nodes: Element
    // Optimized only nodes: Element
    public class CstJson : CstNode
    {
        public CstJson(params CstNode[] children) : base(children) { }
        public override CstNode Transform(Func<CstNode, CstNode> f) => new CstJson(Children.Select(f).ToArray());
        public CstElement Element => Children[0] as CstElement;
    }

}
