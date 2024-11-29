using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Ara3D.Parakeet
{
    /// <summary>
    /// A class inheriting from grammar contains a set of parsing rules. Each parse rule is defined as 
    /// property getters returning a rule created by "Token" (generating no node) or "Phrase" (generating a node).  
    /// This class will store the rules as they are created, and assign them names 
    /// so that they can have recursive relations in them, have fixed names based on the properties, 
    /// and minimizes creating superfluous objects. 
    /// </summary>
    public abstract class Grammar : IGrammar
    {
        public abstract Rule StartRule { get; }
        public virtual Rule WS => BooleanRule.True;
        public readonly Dictionary<string, Rule> Lookup = new Dictionary<string, Rule>();

        public Rule GetRuleFromName(string name)
        {
            var t = GetType();
            var pi = t.GetProperties().FirstOrDefault(p => p.Name == name);
            if (pi == null) return null;
            return pi.GetValue(this) as Rule;
        }

        public IEnumerable<KeyValuePair<string, Rule>> GetRulesByProperty()
            => GetType()
                .GetProperties()
                .Where(pi => typeof(Rule).IsAssignableFrom(pi.PropertyType))
                .Where(p => p.Name != "StartRule")
                .Select(pi => new KeyValuePair<string, Rule>(pi.Name,  pi.GetValue(this) as Rule))
                .Where(kvp => kvp.Value != null);

        private IEnumerable<KeyValuePair<string, Rule>> GetRuelsByMethod()
            => GetType()
                .GetMethods()
                .Where(m => typeof(Rule).IsAssignableFrom(m.ReturnType))
                .Where(m => !m.GetParameters().Any())
                .Select(m => new KeyValuePair<string, Rule>(m.Name, m.Invoke(this, Array.Empty<object>()) as Rule))
                .Where(kvp => kvp.Value != null);

        public IEnumerable<Rule> GetRules()
            => GetRulesByProperty()
                .Concat(GetRuelsByMethod())
                .OrderBy(kvp => kvp.Key)
                .Select(kvp => kvp.Value);

        public static Rule Choice(IEnumerable<Rule> rules)
            => new ChoiceRule(rules.ToArray());

        public static Rule Sequence(IEnumerable<Rule> rules)
            => new SequenceRule(rules.ToArray());

        public static Rule Recursive(string inner)
            => new RecursiveRule(() => GetRuleFromName(inner));
        public static Rule Recursive(Func<Rule> func)
            => new RecursiveRule(func);

        public Rule Named(Rule r, [CallerMemberName] string name = "")
        {
            if (string.IsNullOrEmpty(name)) 
                throw new ArgumentException("Name must not be null");
            if (Lookup.ContainsKey(name)) 
                return Lookup[name];
            r = new NamedRule(r, name);
            Lookup.Add(name, r);
            return r;
        }

        public static Rule Strings(params string[] values)
            => new ChoiceRule(values.OrderByDescending(v => v.Length).Select(v => (Rule)v).ToArray());

        public Rule Node(Rule r, [CallerMemberName] string name = "")
        {
            if (string.IsNullOrEmpty(name)) 
                throw new ArgumentException("Name must not be null");
            if (Lookup.ContainsKey(name)) 
                return Lookup[name];
            if (WS != null)
                r = r.Then(WS);
            r = new NodeRule(r, name);
            Lookup.Add(name, r);
            return r;
        }

        public static OnFail OnFail(Rule r)
            => new OnFail(r);       

        public static Rule CharSet(params char[] chars)
            => chars.Length == 1 ? (Rule)chars[0] : new CharSetRule(chars);

        public static Rule CharSet(string chars)
            => CharSet(chars.ToCharArray());

        public static Rule ZeroOrMore(Rule r)
            => new ZeroOrMoreRule(r);

        public static Rule OneOrMore(Rule r) 
            => new OneOrMoreRule(r);
        
        public static Rule Optional(Rule r) 
            => r.Optional();
        
        public static Rule Not(Rule r) 
            => r.NotAt();

        public static Rule CaseInvariant(string s)
            => new CaseInvariantStringRule(s);

        public static Rule CharRange(int from, int to)
            => new CharRangeRule((char)from, (char)to);
    }

}