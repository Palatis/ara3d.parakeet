using System;

namespace Ara3D.Parakeet
{
    public partial class RuleOptimizer
    {
        private class OptimizedRecursiveRule : RecursiveRule
        {
            public OptimizedRecursiveRule(Func<Rule> ruleFunc) : base(ruleFunc)
            {
            }
        }
    }
}