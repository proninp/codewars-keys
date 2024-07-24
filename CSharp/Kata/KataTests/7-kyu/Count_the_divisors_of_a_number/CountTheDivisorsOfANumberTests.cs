using Kata._7_kyu.Count_the_divisors_of_a_number;

namespace KataTests._7_kyu
{
    public class CountTheDivisorsOfANumberTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(4, 3)]
        [InlineData(10, 4)]
        [InlineData(11, 2)]
        [InlineData(54, 8)]
        public void CountTheDivisorsOfANumberTest(int n, int expected)
        {
            // Arrange

            // Act
            int actual = CountTheDivisorsOfANumber.Divisors(n);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
