using Kata._6_kyu.Find_the_missing_letter.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.Find_the_missing_letter.test
{
    public class FindTheMissingLetterTest
  {
    [Test]
    public void ExampleTests()
    {
      ClassicAssert.AreEqual('e', FindTheMissingLetter.FindMissingLetter(new [] { 'a','b','c','d','f' }));
      ClassicAssert.AreEqual('P', FindTheMissingLetter.FindMissingLetter(new [] { 'O','Q','R','S' }));
    }
  }
}