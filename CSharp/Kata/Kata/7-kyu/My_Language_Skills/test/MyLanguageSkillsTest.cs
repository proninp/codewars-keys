using System.Collections.Generic;
using Kata._7_kyu.My_Language_Skills.src;
using NUnit.Framework;

namespace Kata._7_kyu.My_Language_Skills.test
{
    [TestFixture, Description("MyLanguages")]
    public class MyLanguageSkillsTest
    {
        [Test, Description("Fixed tests")]
        public void FixedTests()
        {
            Assert.That(MyLanguageSkills.MyLanguages(new Dictionary<string, int> { { "Java", 10 }, { "Ruby", 80 }, { "Python", 65 } }),
              Is.EqualTo(new string[] { "Ruby", "Python" }));
            Assert.That(MyLanguageSkills.MyLanguages(new Dictionary<string, int> { { "Hindi", 60 }, { "Greek", 71 }, { "Dutch", 93 } }),
              Is.EqualTo(new string[] { "Dutch", "Greek", "Hindi" }));
            Assert.That(MyLanguageSkills.MyLanguages(new Dictionary<string, int> { { "C++", 50 }, { "ASM", 10 }, { "Haskell", 20 } }),
              Is.EqualTo(new string[] { }));
        }
    }
}