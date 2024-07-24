using Kata._7_kyu.Simple_Fun_176._Reverse_Letter;

namespace KataTests._7_kyu.Simple_Fun_176_Reverse_Letter
{
    public class ReverseLetterTaskTests
    {
        [Theory]
        [InlineData("krishan", "nahsirk")]
        [InlineData("ultr53o?n", "nortlu")]
        [InlineData("ab23c", "cba")]
        [InlineData("krish21an", "nahsirk")]
        public static void ReverseLetterTest(string str, string expected)
        {
            // Arrange

            // Act
            string actual = ReverseLetterTask.ReverseLetter(str);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
