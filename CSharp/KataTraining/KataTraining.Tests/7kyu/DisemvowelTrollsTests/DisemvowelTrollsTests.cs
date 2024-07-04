using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining.Tests._7kyu.DisemvowelTrollsTests
{
    public class DisemvowelTrollsTests
    {
        [Theory]
        [InlineData("This website is for losers LOL!", "Ths wbst s fr lsrs LL!")]
        [InlineData("No offense but,\nYour writing is among the worst I've ever read", "N ffns bt,\nYr wrtng s mng th wrst 'v vr rd")]
        [InlineData("What are you, a communist?", "Wht r y,  cmmnst?")]
        public void DisemvowelTrollsTest(string str, string expected)
        {
            string disemvowel = KataTraining._7kyu.DisemvowelTrolls.DisemvowelTrolls.Disemvowel(str);
            Assert.Equal(expected, disemvowel);
        }
    }
}
