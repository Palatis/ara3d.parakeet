using Ara3D.Parakeet.Grammars;
using Ara3D.Utils;

namespace Ara3D.Parakeet.Tests;

public static class CstCodeGeneratorTestTool
{
    public static IEnumerable<Grammar> Grammars => AllGrammars.Grammars;

    /// <summary>
    /// Generates the source files for the CST project.
    /// This includes CstNode factories: which convert from AST nodes to CST nodes
    /// and the definitions for the various CstNode classes. 
    /// </summary>
    [Test, TestCaseSource(nameof(Grammars))]
    public static void GenerateCstCode(Grammar g)
    {
        var name = g.GetType().Name;
        var nameSpace = $"Ara3D.Parakeet.Cst.{name}NameSpace";
        {
            var cb = new CodeBuilder();
            CstCodeBuilder.OutputCstClassesFile(cb, g, nameSpace);
            var text = cb.ToString();
            Console.WriteLine();
            Console.WriteLine(text);
        }
        {
            var cb = new CodeBuilder();
            CstCodeBuilder.OutputCstFactoryFile(cb, g, nameSpace);
            var text = cb.ToString();
            Console.WriteLine();
            Console.WriteLine(text);
        }
    }
}