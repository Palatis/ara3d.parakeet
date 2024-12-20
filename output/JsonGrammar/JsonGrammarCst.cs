// DO NOT EDIT: Autogenerated file created on 2024-01-26 1:43:40 AM. 
using System;
using System.Linq;
using Ara3D.Parsing;

namespace Parakeet.Cst.JsonGrammar
{
    /// <summary>
    /// Nodes = (Element)*
    /// </summary>
    public class CstArray : CstLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.Array;
        public CstArray(string text) : base(text) { }
        public CstFilter<CstElement> Element => new CstFilter<CstElement> (Children);
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstConstant : CstLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.Constant;
        public CstConstant(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Nodes = (Object|Array|String|Number|Constant)
    /// </summary>
    public class CstElement : CstChoice
    {
        public static Rule Rule = CstNodeFactory.Grammar.Element;
        public CstElement(params CstNode[] children) : base(children) { }
        public CstFilter<CstObject> Object => new CstFilter<CstObject> (Children);
        public CstFilter<CstArray> Array => new CstFilter<CstArray> (Children);
        public CstFilter<CstString> String => new CstFilter<CstString> (Children);
        public CstFilter<CstNumber> Number => new CstFilter<CstNumber> (Children);
        public CstFilter<CstConstant> Constant => new CstFilter<CstConstant> (Children);
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstIdentifier : CstLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.Identifier;
        public CstIdentifier(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Nodes = Element
    /// </summary>
    public class CstJson : CstNode
    {
        public static Rule Rule = CstNodeFactory.Grammar.Json;
        public CstJson(params CstNode[] children) : base(children) { }
        public CstFilter<CstElement> Element => new CstFilter<CstElement> (Children);
    }

    /// <summary>
    /// Nodes = (String+Element)
    /// </summary>
    public class CstMember : CstSequence
    {
        public static Rule Rule = CstNodeFactory.Grammar.Member;
        public CstMember(params CstNode[] children) : base(children) { }
        public CstFilter<CstString> String => new CstFilter<CstString> (Children);
        public CstFilter<CstElement> Element => new CstFilter<CstElement> (Children);
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstNumber : CstLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.Number;
        public CstNumber(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Nodes = (Member)*
    /// </summary>
    public class CstObject : CstLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.Object;
        public CstObject(string text) : base(text) { }
        public CstFilter<CstMember> Member => new CstFilter<CstMember> (Children);
    }

    /// <summary>
    /// Nodes = Element
    /// </summary>
    public class CstJson : CstNode
    {
        public static Rule Rule = CstNodeFactory.Grammar.Json;
        public CstJson(params CstNode[] children) : base(children) { }
        public CstFilter<CstElement> Element => new CstFilter<CstElement> (Children);
    }

    /// <summary>
    /// Nodes = 
    /// </summary>
    public class CstString : CstLeaf
    {
        public static Rule Rule = CstNodeFactory.Grammar.String;
        public CstString(string text) : base(text) { }
        // No children
    }

}
