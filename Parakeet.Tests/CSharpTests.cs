﻿namespace Parakeet.Tests
{
    public static class CSharpTests
    {

        public static string[] Spaces = new[]
{
            "",
            " ",
            "\t",
            "\n \t",
            "// abc",
            "/* abc */",
            @"/*
abc
*/",
            @"// abc
",
            "/* */ /* */",
        };

        public static string[] Literals = new[]
        {
            "1",
            "123",
            "0xFF",
            "0xff",
            "12.34",
            "1.23e41",
            "'a'",
            "'\\n'",
            "\"\"",
            "\"abc\"",
            "true",
            "false",
            "null",
        };


        public static string[] Members = new[]
        {
            "public static int x;",
            "int x;",
            "public int x;",
            "private int y;",
            "int x = 12;",
            "public int x = 12;",
            "int x, y;",
            "void f() { }",
            "public static void f(int x) { return x; }",
            "int x {get;}",
            "int y {get;set;}",
            "int x { get; set; }",
            "int x => 42;",
            "public static int x => { return 42; }"
        };

        public static string[] Identifiers = new[]
        {
            "a",
            "_",
            "A_B",
            "A123",
            "A1_22_0x",
            "_0x",
            "___",
            "a.b",
            "a . b",
            "abc._123.DEF"
        };

        public static string[] Types = new[]
        {
            "int",
            "System.Object",
            "int[]",
            "x",
            "List<int>",
            "List<int,int>",
            "System.List<int>",
            "List<float>[]",
            "float[][]",
            "List<float[]>",
            "List<a,b,c>",
            "list<a, b<int, float>, c[]>",
            "list<system.int>",
        };

        public static string[] Expressions = new[]
        {
            "x",
            "++x",
            "3 + 1",
            "(x)",
            "(3 - 3)",
            "+x",
            "x++",
            "x()",
            "(x, y)",
            "x(1)",
            "x()()",
            "xs[1]",
            "xs[1](2)",
            "(x) => 42",
            "(int x) => 42",
            "x => 42",
            "x => { return 42; }",
            "(int x, float y) => x + y",
            "(x,y) => x + y",
            "x + y + z",
            "x(1) + y(2)",
            "x = z++",
            "++x++",
            "++++x",
            "x.ToString()",
            "x.abc",
            "f()",
            "f(1, 2)",
            "f()()",
            "f(f())",
            "f(f(f(),1),f())",
            "throw x",
            "typeof(int)",
            "typeof(T<a,b>)",
            "typeof(T[])",
            "default",
            "default(T)",
            "default (T<a,b>)",
            "default (T[])",
            "new T()",
            "new()",
            "new T[] { 1,2,3}",
            "new T<int,int>()",
            "new T(1, a)",
            "new() { 1, 2, 3 }",
            "new T() { a=1, b = 3 }",
            "nameof(x)",
            "nameof(abc.def)",
            "x?.a",
            "x ?. a",
            "x += x = 2",
            "x += x + 2",
            "x = x += 3",
            "x=y=z",
        };

        public static string[] Statements = new[]
        {
            "var x;",
            ";",
            "var x = 12;",
            "int x;",
            "T<A> x;",
            "T<A,B> x;",
            "f();",
            "f()()();",
            "((a()));",
            "f(1, 2, 3);",
            "if(b);",
            "return;",
            "break;",
            "return 12;",
            "continue;",
            "if(b);else;",
            "if(b)break;else continue;",
            "for(;;);",
            "for(var x; b < 12; ++i);",
            "{}",
            "{;}",
            "{continue;}",
            "{{}}",
            "{;{};}",
            "++x;",
            "do{}while(b);",
            "foreach(var x in xs);",
            "try{}catch(var e){}",
            "try{}finally{}",
            "try{}catch(Exception e){}finally{}",
        };

        public static string[] FailingStatements = new[]
        {
            "return x x;",
            "if ;",
            "for ( ) }",
            "for { }",
            "continue 12;",
            "f() g();",
            "var var var var;",
        };

        public static string[] Classes = new[]
        {
            "class C { }",
            "class C : B { }",
            "class C<T> { }",
            "class C<T> where T: class { }",
            "class C { int x = 12; }",
            "class C { public int x = 12; }",
            "class C { public int x = 12; public int y = 13; }",
            "class C { private int x = 12; }",
            "class C { public static int x = 12; }",
            "class C { public int x => 12; }",
            "class C { public int x { get; set; }",
            "class C { public int x { get { return 12; } set { _x = value; } }",
            "class C { public int x() { return 12; } }",
            "class C { public int x() { return 12; } private float x() { return 99; } }",
        };

        public static string TestDigits = "0123456789";
        public static string TestNumbersThenUpperCaseLetters = "0123ABC";
        public static string HelloWorld = "Hello world!";
        public static string MathEquation = "(1.23 + (4.56 / 7.9) - 0.8)";
        public static string SomeCode = "var x = 123; x += 23; f(1, a);";

        public static CSharpGrammar Rules = new CSharpGrammar();

        [Test]
        public static void GrammarDefinition()
        {
            Grammar.OutputDefinitions();
        }

        public static CSharpGrammar Grammar = new CSharpGrammar();

        [Test, TestCaseSource(nameof(Spaces))] 
        public static void TestSpaces(string input) => SingleParseTest(input, Grammar.WS);
        
        [Test, TestCaseSource(nameof(Literals))] public static void TestLiterals(string input) => SingleParseTest(input, Grammar.Literal);
        
        [Test, TestCaseSource(nameof(Literals))] public static void TestLiteralExpressions(string input) => SingleParseTest(input, Grammar.Expression);
        
        [Test, TestCaseSource(nameof(Types))] 
        public static void TestTypes(string input) => SingleParseTest(input, Grammar.TypeExpr);
        
        [Test, TestCaseSource(nameof(Statements))] 
        public static void TestStatements(string input) => SingleParseTest(input, Grammar.Statement);
        
        [Test, TestCaseSource(nameof(Expressions))] 
        public static void TestExpressions(string input) => SingleParseTest(input, Grammar.Expression);
        
        [Test, TestCaseSource(nameof(Identifiers))] 
        public static void TestIdentifiers(string input) => SingleParseTest(input, Grammar.QualifiedIdentifier);

        [Test, TestCaseSource(nameof(Members))]
        public static void TestMemberDeclarations(string input) => SingleParseTest(input, Grammar.MemberDeclaration);

        [Test, TestCaseSource(nameof(FailingStatements))]
        public static void TestFailingStatements(string input)
        {
            var pc = new ParserCache(input.Length);
            Assert.AreEqual(0, ParserTests.ParseTest(input, Grammar.Statement   , pc));
            Assert.IsTrue(pc.Errors.Count > 0);
        }

        [Test, TestCaseSource(nameof(Classes))] 
        public static void TestClasses(string input) => SingleParseTest(input, Grammar.TypeDeclaration);

        public static void SingleParseTest(string input, Rule r)
            => Assert.AreEqual(1, ParserTests.ParseTest(input, r));
        
        public static void TestInputsAndRule(string[] inputs, Rule r)
        {
            var pass = 0;
            var total = 0;
            foreach (var input in inputs)
            {
                pass += ParserTests.ParseTest(input, r);
                total++;
            }
            Assert.AreEqual(total, pass);
        }

        [Test]
        [TestCase("<T,T>", nameof(CSharpGrammar.TypeArgList))]
        [TestCase("<T1, T2>", nameof(CSharpGrammar.TypeArgList))]
        [TestCase("?", nameof(CSharpGrammar.Nullable))]
        [TestCase("[]", nameof(CSharpGrammar.ArrayRankSpecifier))]
        [TestCase("[,,]", nameof(CSharpGrammar.ArrayRankSpecifier))]
        [TestCase("[ , , ] ", nameof(CSharpGrammar.ArrayRankSpecifier))]
        [TestCase("= 12", nameof(CSharpGrammar.Initialization))]
        [TestCase("", nameof(CSharpGrammar.InitializationClause))]
        [TestCase("", nameof(CSharpGrammar.VariantClause))]
        [TestCase("", nameof(CSharpGrammar.InvariantClause))]
        [TestCase("var x=12", nameof(CSharpGrammar.InitializationClause))]
        [TestCase("b < 12", nameof(CSharpGrammar.InvariantClause))]
        [TestCase("++i", nameof(CSharpGrammar.InvariantClause))]
        [TestCase("(a)", nameof(CSharpGrammar.LambdaParameters))]
        [TestCase("a", nameof(CSharpGrammar.LambdaParameters))]
        [TestCase("()", nameof(CSharpGrammar.LambdaParameters))]
        [TestCase("(a,b)", nameof(CSharpGrammar.LambdaParameters))]
        [TestCase("(int a,int b)", nameof(CSharpGrammar.LambdaParameters))]
        [TestCase("(list<int, int> a,int[] b)", nameof(CSharpGrammar.LambdaParameters))]
        [TestCase("a", nameof(CSharpGrammar.LambdaParameter))]
        [TestCase("int a", nameof(CSharpGrammar.LambdaParameter))]
        [TestCase("List<int> a", nameof(CSharpGrammar.LambdaParameter))]
        [TestCase("List<int, int> a", nameof(CSharpGrammar.LambdaParameter))]
        [TestCase("int[] a", nameof(CSharpGrammar.LambdaParameter))]
        [TestCase("{}", nameof(CSharpGrammar.BracedStructure))]
        [TestCase("{ }", nameof(CSharpGrammar.BracedStructure))]
        [TestCase("{a}", nameof(CSharpGrammar.BracedStructure))]
        [TestCase("{ /* */ }", nameof(CSharpGrammar.BracedStructure))]
        [TestCase("{a b c;}", nameof(CSharpGrammar.BracedStructure))]
        [TestCase("a", nameof(CSharpGrammar.Token))]
        [TestCase("/* */", nameof(CSharpGrammar.Token))]
        [TestCase(" \n ", nameof(CSharpGrammar.Token))]
        [TestCase("/* */", nameof(CSharpGrammar.CppStyleComment))]
        [TestCase(" \n ", nameof(CSharpGrammar.Spaces))]
        [TestCase("a", nameof(CSharpGrammar.TokenGroup))]
        [TestCase("/* */", nameof(CSharpGrammar.TokenGroup))]
        [TestCase("a b c", nameof(CSharpGrammar.TokenGroup))]
        [TestCase("a b c;", nameof(CSharpGrammar.TokenGroup))]
        [TestCase("a b c;", nameof(CSharpGrammar.TokenGroup))]
        [TestCase("a b c;", nameof(CSharpGrammar.Element))]
        [TestCase("a", nameof(CSharpGrammar.Element))]
        [TestCase("{ a }", nameof(CSharpGrammar.Element))]
        public static void TargetedTest(string input, string name)
        {
            var rule = Grammar.GetRuleFromName(name);
            var result = ParserTests.ParseTest(input, rule);
            Assert.IsTrue(result == 1);
        }

        public static IEnumerable<TestCaseData> SourceFiles()
        {
            return Directory.GetFiles(ParserTests.TestsProjectFolder, "*.cs").Select(f => new TestCaseData(f));
        }

        [Test]
        [TestCaseSource(nameof(SourceFiles))]
        public static void TestFileTokenizer(string file)
        {
            Assert.AreEqual(1, ParserTests.ParseTest(ParserInput.FromFile(file), Grammar.Tokenizer, null, false));
        }

        [Test]
        [TestCaseSource(nameof(SourceFiles))]
        public static void TestFileParser(string file)
        {
            Assert.AreEqual(1, ParserTests.ParseTest(ParserInput.FromFile(file), Grammar.File, null, false));
        }

        [Test, TestCaseSource(nameof(SourceFiles))]
        public static void TestIdentifierMatches(string file)
            => OutputMatches(file, Grammar.Identifier);

        [Test, TestCaseSource(nameof(SourceFiles))]
        public static void TestStatementMatches(string file)
            => OutputMatches(file, Grammar.Statement);

        [Test, TestCaseSource(nameof(SourceFiles))]
        public static void TestTypeDeclarationMatches(string file)
            => OutputMatches(file, Grammar.TypeDeclaration);

        [Test, TestCaseSource(nameof(SourceFiles))]
        public static void TestExpressionMatches(string file)
            => OutputMatches(file, Grammar.Expression);

        public static void OutputMatches(string file, Rule rule)
        {
            var text = ParserInput.FromFile(file);
            var prs = text.GetMatches(rule | Grammar.Token | Grammar.Delimiter);
            var between = prs.BetweenMatches();
            foreach (var range in between)
            {
                Console.WriteLine($"Failed to match at {range.Begin.Position} = {range.Text}");
            }
            Assert.IsFalse(between.Any());
            foreach (var range in prs)
            {
                if (range.Node?.Name == rule.GetName())
                {
                    Assert.IsTrue(range.Text.Length > 0);
                    Console.WriteLine($"[{range.Node.EllidedContents}]");
                }
            }
        }

        [Test]
        public static void OutputAstCode()
        {
            var cb = new CodeBuilder();
            AstClassBuilder.OutputAstFile(cb, "Parakeet.Demos.CSharp", Grammar.GetRules());
            var path = Path.Combine(ParserTests.DemosProjectFolder, "CSharpAst.cs");
            var text = cb.ToString();
            Console.WriteLine(text);
            File.WriteAllText(path, text);
        }
    }
}