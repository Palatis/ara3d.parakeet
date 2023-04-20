﻿using Parakeet.Demos.PAIL;

namespace Parakeet.Tests
{
    public class PailTests
    {
        public static PailGrammar Grammar = new PailGrammar();

        public static string[] Literals =
        {
            "42",
            "\"Hello world\"",
            "'q'",
            "true",
            "false",
            "3.14e-10",
            "-3.14E+10",
            "0.001",
        };

        public static string[] Identifiers =
        {
            "a",
            "abc",
            "ab_cd",
        };

        public static string[] Expressions =
        {
            "f()",
            "abc(123)",
            "f(g(), h())",
        };

        public static string[] Statements =
        {
            "a = x",
            "let x = 12",
            "break",
            "continue",
            "return x",
            "if x then a else b",
            "_",
            "x",
            "f()",
            "f(g(h(123)))",
            "{}",
            "{ }",
            "{ {}; {}; }",
            "{ break; }",
            "{ break; continue; let x = _; { }; return x; f(); }",
            "if true then { } else { }",
            "while true do { }",
            "while false do f()",
            "if if x then y else z then a else b",
            "while x do { a; b(); x = 12; }",
        };

        [Test]
        [TestCaseSource(nameof(Identifiers))]
        [TestCaseSource(nameof(Literals))]
        [TestCaseSource(nameof(Expressions))]
        [TestCaseSource(nameof(Statements))]
        public static void TestPailExpressions(string input) 
            => ParserTests.SingleParseTest(input, Grammar.Expr);

    }
}