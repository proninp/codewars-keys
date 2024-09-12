using Kata._7_kyu.Sum_of_a_sequence.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.Sum_of_a_sequence.test
{
    [TestFixture]
    public class SumOfASequenceTest
    {
        [Test]
        public void BasicTest()
        {
            ClassicAssert.AreEqual(5, SumOfASequence.SequenceSum(1, 5, 3));
            ClassicAssert.AreEqual(15, SumOfASequence.SequenceSum(1, 5, 1));
            ClassicAssert.AreEqual(12, SumOfASequence.SequenceSum(2, 6, 2));
            ClassicAssert.AreEqual(45, SumOfASequence.SequenceSum(0, 15, 3));
            ClassicAssert.AreEqual(0, SumOfASequence.SequenceSum(16, 15, 3));
            ClassicAssert.AreEqual(26, SumOfASequence.SequenceSum(2, 24, 22));
            ClassicAssert.AreEqual(2, SumOfASequence.SequenceSum(2, 2, 2));
            ClassicAssert.AreEqual(2, SumOfASequence.SequenceSum(2, 2, 1));
            ClassicAssert.AreEqual(35, SumOfASequence.SequenceSum(1, 15, 3));
            ClassicAssert.AreEqual(0, SumOfASequence.SequenceSum(15, 1, 3));
        }
    }
}