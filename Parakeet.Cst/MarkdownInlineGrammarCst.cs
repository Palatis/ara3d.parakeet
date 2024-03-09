// DO NOT EDIT: Autogenerated file created on 2024-03-09 10:52:18 AM. 
using System;
using System.Linq;

namespace Ara3D.Parakeet.Cst.MarkdownInlineGrammarNameSpace
{
    /// <summary>This interface exists to make it easy to auto-generate type switches</summary>
    public interface IMarkdownInlineCstNode { }

    /// <summary>
    /// Rule = AltText ::= (('['+WS+_UNKNOWN_+((!(']')+AnyChar))*+WS+']'+WS)+WS)
    /// Nodes = 
    /// </summary>
    public class CstAltText : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.AltText;
        public CstAltText(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Bold ::= ((("\x2A\x2A"+((!("\x2A\x2A")+InnerText))*+"\x2A\x2A")|("\x5F\x5F"+((!("\x5F\x5F")+InnerText))*+"\x5F\x5F"))+WS)
    /// Nodes = (InnerText)*
    /// </summary>
    public class CstBold : CstNode, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Bold;
        public CstBold(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstInnerText> InnerText => new CstNodeFilter<CstInnerText> (Children);
    }

    /// <summary>
    /// Rule = BoldAndItalic ::= ((("\x2A\x2A\x2A"+((!("\x2A\x2A\x2A")+InnerText))*+"\x2A\x2A\x2A")|("\x5F\x5F\x5F"+((!("\x5F\x5F\x5F")+InnerText))*+"\x5F\x5F\x5F"))+WS)
    /// Nodes = (InnerText)*
    /// </summary>
    public class CstBoldAndItalic : CstNode, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.BoldAndItalic;
        public CstBoldAndItalic(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstInnerText> InnerText => new CstNodeFilter<CstInnerText> (Children);
    }

    /// <summary>
    /// Rule = Code ::= (('`'+((!('`')+InnerText))*+'`')+WS)
    /// Nodes = (InnerText)*
    /// </summary>
    public class CstCode : CstNode, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Code;
        public CstCode(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstInnerText> InnerText => new CstNodeFilter<CstInnerText> (Children);
    }

    /// <summary>
    /// Rule = Content ::= ((InnerText)*+WS)
    /// Nodes = (InnerText)*
    /// </summary>
    public class CstContent : CstNode, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Content;
        public CstContent(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstInnerText> InnerText => new CstNodeFilter<CstInnerText> (Children);
    }

    /// <summary>
    /// Rule = Email ::= (((EmailChar)*+'@'+(EmailChar)*)+WS)
    /// Nodes = 
    /// </summary>
    public class CstEmail : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Email;
        public CstEmail(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = EmailLink ::= (('<'+Email+'>')+WS)
    /// Nodes = Email
    /// </summary>
    public class CstEmailLink : CstNode, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.EmailLink;
        public CstEmailLink(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstEmail> Email => new CstNodeFilter<CstEmail> (Children);
    }

    /// <summary>
    /// Rule = EscapedChar ::= (('\'+[\x21\x23\x28-+\x2D\x2E<>\x5B-\x5D`\x7B-\x7D])+WS)
    /// Nodes = 
    /// </summary>
    public class CstEscapedChar : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.EscapedChar;
        public CstEscapedChar(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = HtmlTag ::= (('<'+_RECOVER_+((!('>')+AnyChar))*+'>')+WS)
    /// Nodes = 
    /// </summary>
    public class CstHtmlTag : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.HtmlTag;
        public CstHtmlTag(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Identifier ::= ((IdentifierFirstChar+(IdentifierChar)*)+WS)
    /// Nodes = 
    /// </summary>
    public class CstIdentifier : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Identifier;
        public CstIdentifier(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Img ::= (('!'+AltText+'('+WS+_UNKNOWN_+Url+WS+(UrlTitle)?+WS+')'+WS)+WS)
    /// Nodes = (AltText+Url+(UrlTitle)?)
    /// </summary>
    public class CstImg : CstNodeSequence, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Img;
        public CstImg(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstAltText> AltText => new CstNodeFilter<CstAltText> (Children);
        public CstNodeFilter<CstUrl> Url => new CstNodeFilter<CstUrl> (Children);
        public CstNodeFilter<CstUrlTitle> UrlTitle => new CstNodeFilter<CstUrlTitle> (Children);
    }

    /// <summary>
    /// Rule = InnerText ::= ((BoldAndItalic|Strikethrough|Bold|Italic|Code|Link|Img|EmailLink|UrlLink|HtmlTag|EscapedChar|PlainText|AnyChar)+WS)
    /// Nodes = (BoldAndItalic|Strikethrough|Bold|Italic|Code|Link|Img|EmailLink|UrlLink|HtmlTag|EscapedChar|PlainText)
    /// </summary>
    public class CstInnerText : CstNodeChoice, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.InnerText;
        public CstInnerText(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstBoldAndItalic> BoldAndItalic => new CstNodeFilter<CstBoldAndItalic> (Children);
        public CstNodeFilter<CstStrikethrough> Strikethrough => new CstNodeFilter<CstStrikethrough> (Children);
        public CstNodeFilter<CstBold> Bold => new CstNodeFilter<CstBold> (Children);
        public CstNodeFilter<CstItalic> Italic => new CstNodeFilter<CstItalic> (Children);
        public CstNodeFilter<CstCode> Code => new CstNodeFilter<CstCode> (Children);
        public CstNodeFilter<CstLink> Link => new CstNodeFilter<CstLink> (Children);
        public CstNodeFilter<CstImg> Img => new CstNodeFilter<CstImg> (Children);
        public CstNodeFilter<CstEmailLink> EmailLink => new CstNodeFilter<CstEmailLink> (Children);
        public CstNodeFilter<CstUrlLink> UrlLink => new CstNodeFilter<CstUrlLink> (Children);
        public CstNodeFilter<CstHtmlTag> HtmlTag => new CstNodeFilter<CstHtmlTag> (Children);
        public CstNodeFilter<CstEscapedChar> EscapedChar => new CstNodeFilter<CstEscapedChar> (Children);
        public CstNodeFilter<CstPlainText> PlainText => new CstNodeFilter<CstPlainText> (Children);
    }

    /// <summary>
    /// Rule = Italic ::= ((('*'+((!('*')+InnerText))*+'*')|('_'+((!('_')+InnerText))*+'_'))+WS)
    /// Nodes = (InnerText)*
    /// </summary>
    public class CstItalic : CstNode, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Italic;
        public CstItalic(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstInnerText> InnerText => new CstNodeFilter<CstInnerText> (Children);
    }

    /// <summary>
    /// Rule = Link ::= (('['+InnerText+']'+WS+'('+Url+WS+UrlTitle+')')+WS)
    /// Nodes = (InnerText+Url+UrlTitle)
    /// </summary>
    public class CstLink : CstNodeSequence, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Link;
        public CstLink(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstInnerText> InnerText => new CstNodeFilter<CstInnerText> (Children);
        public CstNodeFilter<CstUrl> Url => new CstNodeFilter<CstUrl> (Children);
        public CstNodeFilter<CstUrlTitle> UrlTitle => new CstNodeFilter<CstUrlTitle> (Children);
    }

    /// <summary>
    /// Rule = PlainText ::= (((!([\x21\x2A<\x5B\x5C\x5F`~])+AnyChar))++WS)
    /// Nodes = 
    /// </summary>
    public class CstPlainText : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.PlainText;
        public CstPlainText(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = PlainTextUrl ::= (("http\x3A\x2F\x2F"+(UrlChar)*)+WS)
    /// Nodes = 
    /// </summary>
    public class CstPlainTextUrl : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.PlainTextUrl;
        public CstPlainTextUrl(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Strikethrough ::= (("~~"+((!("~~")+InnerText))*+"~~")+WS)
    /// Nodes = (InnerText)*
    /// </summary>
    public class CstStrikethrough : CstNode, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Strikethrough;
        public CstStrikethrough(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstInnerText> InnerText => new CstNodeFilter<CstInnerText> (Children);
    }

    /// <summary>
    /// Rule = Url ::= ((UrlChar)*+WS)
    /// Nodes = 
    /// </summary>
    public class CstUrl : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Url;
        public CstUrl(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = UrlLink ::= ((('<'+Url+'>')|PlainTextUrl)+WS)
    /// Nodes = (Url|PlainTextUrl)
    /// </summary>
    public class CstUrlLink : CstNodeChoice, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.UrlLink;
        public CstUrlLink(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstUrl> Url => new CstNodeFilter<CstUrl> (Children);
        public CstNodeFilter<CstPlainTextUrl> PlainTextUrl => new CstNodeFilter<CstPlainTextUrl> (Children);
    }

    /// <summary>
    /// Rule = UrlTitle ::= (DoubleQuoteBasicString+WS)
    /// Nodes = 
    /// </summary>
    public class CstUrlTitle : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.UrlTitle;
        public CstUrlTitle(string text) : base(text) { }
        // No children
    }

}
