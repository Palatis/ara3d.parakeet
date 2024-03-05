// DO NOT EDIT: Autogenerated file created on 2024-03-04 7:41:44 PM. 
using System;
using System.Linq;

namespace Ara3D.Parakeet.Cst.PhoneNumberGrammarNameSpace
{
    /// <summary>
    /// Rule = AreaCode ::= ((('('+(Spaces)?+_UNKNOWN_+AreaCodeDigits+(Spaces)?+')'+(Spaces)?)|AreaCodeDigits)+(Spaces)?)
    /// Nodes = (AreaCodeDigits|AreaCodeDigits)
    /// </summary>
    public class CstAreaCode : CstNodeChoice
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.AreaCode;
        public CstAreaCode(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstAreaCodeDigits> AreaCodeDigits => new CstNodeFilter<CstAreaCodeDigits> (Children);
    }

    /// <summary>
    /// Rule = AreaCodeDigits ::= ((Digit){3,3}+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstAreaCodeDigits : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.AreaCodeDigits;
        public CstAreaCodeDigits(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = CountryCode ::= (((('+'+Spaces))?+(Digit){1,3})+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstCountryCode : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.CountryCode;
        public CstCountryCode(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Exchange ::= ((Digit){3,3}+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstExchange : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Exchange;
        public CstExchange(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Identifier ::= ((IdentifierFirstChar+(IdentifierChar)*)+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstIdentifier : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Identifier;
        public CstIdentifier(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = PhoneNumber ::= ((((CountryCode+Separators))?+AreaCode+Separators+Exchange+Separators+Subscriber)+(Spaces)?)
    /// Nodes = ((CountryCode)?+AreaCode+Exchange+Subscriber)
    /// </summary>
    public class CstPhoneNumber : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.PhoneNumber;
        public CstPhoneNumber(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstCountryCode> CountryCode => new CstNodeFilter<CstCountryCode> (Children);
        public CstNodeFilter<CstAreaCode> AreaCode => new CstNodeFilter<CstAreaCode> (Children);
        public CstNodeFilter<CstExchange> Exchange => new CstNodeFilter<CstExchange> (Children);
        public CstNodeFilter<CstSubscriber> Subscriber => new CstNodeFilter<CstSubscriber> (Children);
    }

    /// <summary>
    /// Rule = Subscriber ::= ((Digit){4,4}+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstSubscriber : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Subscriber;
        public CstSubscriber(string text) : base(text) { }
        // No children
    }

}
