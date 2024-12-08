using Ara3D.Parakeet.Grammars;

namespace Ara3D.Parakeet.Tests
{
    internal static class Profiling
    {
        public static void Main(params string[] args)
        {
            CSharpTests.TargetedTest("namespace A { class B {} class C {} }", nameof(CSharpGrammar.NamespaceDeclaration));
        }
    }
}
