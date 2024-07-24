using Kata._6_kyu.Create_Phone_Number;

namespace KataTests._6_kyu.Create_Phone_Number
{
    public class CreatePhoneNumberTaskTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, "(123) 456-7890")]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, "(111) 111-1111")]
        public static void CreatePhoneNumberTest(int[] numbers, string expected)
        {
            // Arrange

            // Act
            string actual = CreatePhoneNumberTask.CreatePhoneNumber(numbers);

            // Assert
            Assert.True(actual.SequenceEqual(expected));
        }
    }
}