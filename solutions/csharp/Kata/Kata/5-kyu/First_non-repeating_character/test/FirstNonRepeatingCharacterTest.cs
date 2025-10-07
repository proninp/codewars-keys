using Kata._5_kyu.First_non_repeating_character.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._5_kyu.First_non_repeating_character.test
{
    public class FirstNonRepeatingCharacterTest
    {
        [TestFixture]
        public class KataTest
        {
            [Test]
            public void BasicTests()
            {
                ClassicAssert.AreEqual("a", FirstNonRepeatingCharacter.FirstNonRepeatingLetter("a"));
                ClassicAssert.AreEqual("t", FirstNonRepeatingCharacter.FirstNonRepeatingLetter("stress"));
                ClassicAssert.AreEqual("e", FirstNonRepeatingCharacter.FirstNonRepeatingLetter("moonmen"));
            }
        }
    }
}