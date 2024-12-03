using System.Text;
using Ara3D.Parakeet.Grammars;
using Ara3D.Utils;

namespace Ara3D.Parakeet.Tests;

public static class GrammarTests
{
    public static IEnumerable<Grammar> Grammars
        => AllGrammars.Grammars;

    [Test, TestCaseSource(nameof(Grammars))]
    public static void OptimizerOnGrammarTest(Grammar g)
    {
        var ro = new RuleOptimizer(g);

        Console.WriteLine($"Optimized Rules (Count = {ro.OptimizedRules.Count}):");
        foreach (var kv in ro.OptimizedRules)
        {
            Console.Write($"  From ({kv.Key.GetType().Name}): ");
            Console.WriteLine(kv.Key.ToString().Replace("\r", "\\r").Replace("\n", "\\n"));

            Console.Write($"  Into ({kv.Value.GetType().Name}): ");
            Console.WriteLine(kv.Value.ToString().Replace("\r", "\\r").Replace("\n", "\\n"));
        }
    }

    [Test, TestCaseSource(nameof(Grammars))]
    public static void OptimizerOnRuleTest(Grammar g)
    {
        var ro = new RuleOptimizer();
        _ = ro.Optimize(g.StartRule);

        Console.WriteLine($"Optimized Rules (Count = {ro.OptimizedRules.Count}):");
        foreach (var kv in ro.OptimizedRules)
        {
            Console.Write($"  From ({kv.Key.GetType().Name}): ");
            Console.WriteLine(kv.Key.ToString().Replace("\r", "\\r").Replace("\n", "\\n"));

            Console.Write($"  Into ({kv.Value.GetType().Name}): ");
            Console.WriteLine(kv.Value.ToString().Replace("\r", "\\r").Replace("\n", "\\n"));
        }
    }

    public static string GetGrammarDef(Grammar g)
    {
        var sb = new StringBuilder();
        foreach (var r in g.GetRules())
        {
            sb.AppendLine(r.GetName() + " := " + r.Body().ToDefinition());
        }

        return sb.ToString();
    }

    [Test, TestCaseSource(nameof(Grammars))]
    public static void OutputDefinitions(Grammar g)
    {
        var name = g.GetType().Name;
        var folder = Folders.BaseOutputFolder.RelativeFolder(name).Create();
        {
            var s = GetGrammarDef(g);
            Console.WriteLine(s);
            folder.RelativeFile("grammar.txt").WriteAllText(s);
        }
    }
}