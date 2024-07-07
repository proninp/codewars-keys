using _6kyu.Array.diff;

namespace _6kyu.Tests
{
    public class Array_diffTests
    {
        [Theory]
        [InlineData(new int[] {1, 2, 3, 4}, new int[] { 2 }, new int[] { 1, 3, 4 } )]
        [InlineData(new int[] {1, 2, 3, 1 ,2, 3, 3, 4, 3}, new int[] { 1, 2 }, new int[] { 3, 3, 3, 4, 3 } )]
        [InlineData(new int[] {1, 1, 1, 1}, new int[] { 2 }, new int[] { 1, 1, 1, 1 } )]
        [InlineData(new int[] {1, 1, 1, 1}, new int[] { 1 }, new int[] { } )]
        public void ArrayDiffTest(int[] a, int[] b, int[] expected)
        {
            // Arrange

            // Act
            int[] actual = Array_diff.ArrayDiff(a, b);

            // Assert
            Assert.True(actual.SequenceEqual(expected));
        }
    }
}