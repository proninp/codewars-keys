using _5kyu.RGB_To_Hex_Conversion;

namespace _5kyu.Tests
{
    public class RGBToHexConversionTests
    {
        [Theory]
        [InlineData(255, 255, 255, "FFFFFF")]
        [InlineData(255, 255, 300, "FFFFFF")]
        [InlineData(0, 0, 0, "000000")]
        [InlineData(148, 0, 211, "9400D3")]
        [InlineData(148, -20, 211, "9400D3")]
        [InlineData(144, 195, 212, "90C3D4")]
        [InlineData(212, 53, 12, "D4350C")]
        public static void RgbTest(int r, int g, int b, string expected)
        {
            // Arrange


            // Act
            string actual = RGBToHexConversion.Rgb(r, g, b);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
