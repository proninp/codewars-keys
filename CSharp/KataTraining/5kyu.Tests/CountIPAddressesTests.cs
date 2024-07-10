namespace _5kyu.Tests
{
    public class CountIPAddressesTests
    {
        [Theory]
        [InlineData("10.0.0.0", "10.0.0.50", 50L)]
        [InlineData("20.0.0.10", "20.0.1.0", 246L)]
        [InlineData("0.0.0.0", "255.255.255.255", (1L << 32) - 1L)]
        public void IpsBetweenTest(string start, string end, long expected)
        {
            // Arrange

            // Act
            long actual = CountIPAddresses.IpsBetween(start, end);

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}