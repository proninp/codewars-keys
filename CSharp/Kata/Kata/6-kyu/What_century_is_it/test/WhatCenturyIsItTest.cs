using Kata._6_kyu.What_century_is_it.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.What_century_is_it.test
{
    [TestFixture]
    public class WhatCenturyIsItTest
    {
        [Test]
        public void BasicTests()
        {
            ClassicAssert.AreEqual("20th", WhatCenturyIsIt.WhatCentury("1999"), "With input '1999' solution produced wrong output.");
            ClassicAssert.AreEqual("21st", WhatCenturyIsIt.WhatCentury("2011"), "With input '2011' solution produced wrong output.");
            ClassicAssert.AreEqual("22nd", WhatCenturyIsIt.WhatCentury("2154"), "With input '2154' solution produced wrong output.");
            ClassicAssert.AreEqual("23rd", WhatCenturyIsIt.WhatCentury("2259"), "With input '2259' solution produced wrong output.");
        }
    }
}