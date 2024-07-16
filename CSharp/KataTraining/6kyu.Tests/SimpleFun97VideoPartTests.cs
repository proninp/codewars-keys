using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6kyu.Tests
{
    public class SimpleFun97VideoPartTests
    {
        [Theory]
        [InlineData("02:20:00", "07:00:00", new int[] { 1, 3 })]
        [InlineData("25:26:20", "25:26:20", new int[] { 1, 1 })]
        [InlineData("00:02:20", "00:10:00", new int[] { 7, 30 })]
        public static void VideoPartTest(string part, string total, int[] expected)
        {

        }
    }
}
