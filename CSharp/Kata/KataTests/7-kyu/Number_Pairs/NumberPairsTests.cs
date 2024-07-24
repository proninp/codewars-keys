using Kata._7_kyu.Number_Pairs;

namespace KataTests._7_kyu.Number_Pairs
{
    public class NumberPairsTests
    {
        [Fact]
        public static void GetLargerNumbersTest()
        {
            // Arrange
            int[] arr1 = new int[] { 13, 64, 5, 7, 88 };
            int[] arr2 = new int[] { 23, 4, 53, 17, 80 };

            // Act
            var actual = NumberPairs.GetLargerNumbers(arr1, arr2);
            var expected = new int[] { 23, 64, 53, 17, 88 };

            // Assert
            Assert.True(Enumerable.SequenceEqual(expected, actual));
        }
    }
}
