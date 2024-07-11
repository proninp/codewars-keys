using _6kyu.Multiples_of_3_or_5;

namespace _6kyu.Tests
{
    public class MultiplesOf3Or5Tests
    {
        [Theory]
        [InlineData(10, 23)]
        [InlineData(20, 78)]
        [InlineData(200, 9168)]
        [InlineData(0, 0)]
        public static void SolutionTest(int value, int expected)
        {
            // Arrange

            // Act
            int actual = MultiplesOf3Or5.Solution(value);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
