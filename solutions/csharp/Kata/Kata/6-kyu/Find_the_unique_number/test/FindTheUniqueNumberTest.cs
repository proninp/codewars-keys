using System.Collections.Generic;
using Kata._6_kyu.Find_the_unique_number.src;
using NUnit.Framework;

namespace Kata._6_kyu.Find_the_unique_number.test
{
    [TestFixture]
    public class FindTheUniqueNumberTest
    {
        [TestCase(new[] { 1, 2, 2, 2 }, ExpectedResult = 1)]
        [TestCase(new[] { -2, 2, 2, 2 }, ExpectedResult = -2)]
        [TestCase(new[] { 11, 11, 14, 11, 11 }, ExpectedResult = 14)]
        public int BaseTest(IEnumerable<int> numbers)
        {
            return FindTheUniqueNumber.GetUnique(numbers);
        }
    }
}