using System.Collections.Generic;
using Kata._6_kyu.Find_the_missing_term_in_an_Arithmetic_Progression.src;
using NUnit.Framework;

namespace Kata._6_kyu.Find_the_missing_term_in_an_Arithmetic_Progression.test
{
    [TestFixture]
    public class FindMissingTaskTest
    {
        private static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData([new List<int> { 1, 3, 5, 9, 11 }]).Returns(7);
                yield return new TestCaseData([new List<int> { 0, 5, 10, 20, 25 }]).Returns(15);
                yield return new TestCaseData([new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 }]).Returns(10);
                yield return new TestCaseData([new List<int> { 1040, 1220, 1580 }]).Returns(1400);
            }
        }

        [Test, TestCaseSource(nameof(TestCases))]
        public int Test(List<int> list) => FindMissingTask.FindMissing(list);
        
        [Test, TestCaseSource(nameof(TestCases))]
        public int Test2(List<int> list) => FindMissingTask.FindMissing2(list);
    }
}