﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Parakeet.Grammars
{
    public static class AllGrammars
    {
        public static Grammar[] Grammars =
        {
            CombinatorCalculusGrammar.Instance,
            CSharpGrammar.Instance,
            CssGrammar.Instance,
            CsvGrammar.Instance,
            EmailGrammar.Instance,
            JoyGrammar.Instance,
            JsonGrammar.Instance,
            PhoneNumberGrammar.Instance,
            PlatoGrammar.Instance,
            PlatoTokenGrammar.Instance,
            SchemeGrammar.Instance,
            SExpressionGrammar.Instance,
            SimpleLambdaCalculusGrammar.Instance,
            XmlGrammar.Instance,
        };

    }
}