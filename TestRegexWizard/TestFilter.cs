using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace TestRegexWizard
{
    [TestClass]
    public class TestFilter
    {
        [TestMethod]
        public void RegEx_01()
        {
            //remember that the @ symbol is known as making a string verbatim,
            //to avoid common escape characters, exceptions are quotations.
            string pattern = @"\bcat\b";
            Regex rgx = new Regex(pattern);
            string sentence = "kat cat";

            //foreach (Match match in rgx.Matches(sentence))
            //    Console.WriteLine("Found '{0}' at position {1}",
            //                      match.Value, match.Index);

            Match myMatch = rgx.Match(sentence);
            Assert.AreEqual(4, myMatch.Index);
        }
        [TestMethod]
        public void RegEx_02()
        {
            string pattern = @"\bcat\b";
            Regex rgx = new Regex(pattern);
            string sentence = "kat cat";

            //foreach (Match match in rgx.Matches(sentence))
            //    Console.WriteLine("Found '{0}' at position {1}",
            //                      match.Value, match.Index);

            Match myMatch = rgx.Match(sentence);
            Assert.AreEqual("cat", myMatch.Value);
        }
    }
}
