// DO NOT EDIT: Autogenerated file created on 2024-01-27 10:00:21 AM. 
using System;
using System.Linq;

namespace Parakeet.Cst.SimpleLambdaCalculusGrammarNameSpace
{
    /// <summary>
    /// Nodes = (Parameter+Term)
    /// </summary>
    public class CstAbstraction : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.Grammar.Abstraction;
        public CstAbstraction(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstParameter> Parameter => new CstNodeFilter<CstParameter> (Children);
        public CstNodeFilter<CstTerm> Term => new CstNodeFilter<CstTerm> (Children);
    }

    /// <summary>
    /// Nodes = (Term+Term)
    /// </summary>
    public class CstApplication : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.Grammar.Application;
        public CstApplication(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstTerm> Term => new CstNodeFilter<CstTerm> (Children);
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
    /// Nodes = (Variable|Abstraction|Application)
    /// </summary>
    public class CstInnerTerm : CstNodeChoice
    {
        public static Rule Rule = CstNodeFactory.Grammar.InnerTerm;
        public CstInnerTerm(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstVariable> Variable => new CstNodeFilter<CstVariable> (Children);
        public CstNodeFilter<CstAbstraction> Abstraction => new CstNodeFilter<CstAbstraction> (Children);
        public CstNodeFilter<CstApplication> Application => new CstNodeFilter<CstApplication> (Children);
    }

    /// <summary>
    /// Nodes = Variable
    /// </summary>
    public class CstParameter : CstNode
    {
        public static Rule Rule = CstNodeFactory.Grammar.Parameter;
        public CstParameter(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstVariable> Variable => new CstNodeFilter<CstVariable> (Children);
    }

    /// <summary>
    /// Nodes = InnerTerm
    /// </summary>
    public class CstTerm : CstNode
    {
        public static Rule Rule = CstNodeFactory.Grammar.Term;
        public CstTerm(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstInnerTerm> InnerTerm => new CstNodeFilter<CstInnerTerm> (Children);
    }

    /// <summary>
    /// Nodes = Identifier
    /// </summary>
    public class CstVariable : CstNode
    {
        public static Rule Rule = CstNodeFactory.Grammar.Variable;
        public CstVariable(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstIdentifier> Identifier => new CstNodeFilter<CstIdentifier> (Children);
    }

}
