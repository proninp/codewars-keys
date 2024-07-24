using Kata._6_kyu.IndexOf_Array_in_Array;

namespace KataTests._6_kyu.Create_Phone_Number
{
    public class IndexOfArrayInArrayTests
    {
        [Fact]
        public void SearchArrayTest()
        {
            // Arrange
            var bigArray = new object[][] {
                new object[] { 2, 3 },
                new object[] { 7, 2 },
                new object[] { 9, 20 },
                new object[] { 1, 2 },
                new object[] { 7, 2 },
                new object[] { 45, 4 },
                new object[] { 7, 87 },
                new object[] { 4, 5 },
                new object[] { 2, 7 },
                new object[] { 6, 32 }
            };

            var test1 = new object[] { 9, 20 };
            var test2 = new object[] { 1, 12 };
            var test3 = new object[] { 7, 2 };

            // Act

            // Assert
            Assert.Equal(2, IndexOfArrayInArray.SearchArray(bigArray, test1));
            Assert.Equal(-1, IndexOfArrayInArray.SearchArray(bigArray, test2));
            Assert.Equal(1, IndexOfArrayInArray.SearchArray(bigArray, test3));
        }
    }
}
