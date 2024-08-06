using System.Collections.Generic;
using Kata._6_kyu.Break_camelCase.src;
using NUnit.Framework;

namespace Kata._6_kyu.Break_camelCase.test
{
    [TestFixture]
    public class BreakCamelCaseTaskTest
    {
        private static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData("camelCasing").Returns("camel Casing");
                yield return new TestCaseData("camelCasingTest").Returns("camel Casing Test");
            }
        }

        [Test, TestCaseSource("TestCases")]
        public string Test(string str) => BreakCamelCaseTask.BreakCamelCase(str);
    }
}