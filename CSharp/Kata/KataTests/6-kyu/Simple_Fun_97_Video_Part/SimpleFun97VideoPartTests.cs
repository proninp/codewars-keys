using Kata._6_kyu.Simple_Fun_97_Video_Part;

namespace KataTests._6_kyu.Simple_Fun_97_Video_Part
{
    public class SimpleFun97VideoPartTests
    {
        [Theory]
        [InlineData("02:20:00", "07:00:00", new int[] { 1, 3 })]
        [InlineData("25:26:20", "25:26:20", new int[] { 1, 1 })]
        [InlineData("00:02:20", "00:10:00", new int[] { 7, 30 })]
        public static void VideoPartTest(string part, string total, int[] expected)
        {
            // Arrange

            // Act
            var actual = SimpleFun97VideoPart.VideoPart(part, total);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
