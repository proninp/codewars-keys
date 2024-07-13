using _7kyu.Simple_Fun_176._Reverse_Letter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7kyu.Tests
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
