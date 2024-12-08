using System;
using System.Collections.Generic;

namespace Ara3D.Parakeet
{
    public partial class RuleOptimizer
    {
        private class NoneOptimizedRule : Rule
        {
            public readonly Rule Rule;
            public override IReadOnlyList<Rule> Children => new[] { Rule };

            public NoneOptimizedRule(Rule rule)
                => Rule = rule;

            protected override ParserState MatchImplementation(ParserState state)
                => throw new NotImplementedException();

            public override bool Equals(object obj)
                => obj is NoneOptimizedRule opt && Rule == opt.Rule;

            protected override int GetHashCodeInternal() => Hash(Rule);
        }
    }
}