using Kata._7_kyu.Simple_string_characters.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.Simple_string_characters.test;
[TestFixture]
public class SimpleStringCharactersTest
{
    [Test]
    public void ExampleTests()
    {
        ClassicAssert.AreEqual(new int[] { 1, 18, 3, 2 }, SimpleStringCharacters.Solve("Codewars@codewars123.com"));
        ClassicAssert.AreEqual(new int[] { 7, 6, 3, 2 }, SimpleStringCharacters.Solve("bgA5<1d-tOwUZTS8yQ"));
        ClassicAssert.AreEqual(new int[] { 9, 9, 6, 9 }, SimpleStringCharacters.Solve("P*K4%>mQUDaG$h=cx2?.Czt7!Zn16p@5H"));
        ClassicAssert.AreEqual(new int[] { 15, 8, 6, 9 }, SimpleStringCharacters.Solve("RYT'>s&gO-.CM9AKeH?,5317tWGpS<*x2ukXZD"));
    }
}