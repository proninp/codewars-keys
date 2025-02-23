using Kata._6_kyu.Does_my_number_look_big_in_this.src;
using NUnit.Framework;
using System.Collections.Generic;

namespace Kata._6_kyu.Does_my_number_look_big_in_this.test;

[TestFixture]
public class DoesMyNumberLookBigInThisTaskTest
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData(1)
                            .Returns(true)
                            .SetDescription("1 is narcissitic");
            yield return new TestCaseData(371)
                            .Returns(true)
                            .SetDescription("371 is narcissitic");

        }
    }

    [Test, TestCaseSource("testCases")]
    public bool Test(int n) => DoesMyNumberLookBigInThisTask.Narcissistic(n);
}