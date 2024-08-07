using System;
using System.Collections.Generic;
using Kata._7_kyu.Friend_or_Foe.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._7_kyu.Friend_or_Foe.test
{
    [TestFixture]
    public class FriendOrFoeTest
    {
        [Test]
        [TestCase(
            new[] { "Mark", "Jimmy", "Abel", "Amanda" },
            new[] { "Mark", "Abel" }
        )]
        [TestCase(
            new[] { "Peter", "Anna", "Michael" },
            new[] { "Anna" }
        )]
        [TestCase(
            new[] { "Linus", "Beau", "Azul" },
            new[] { "Beau", "Azul" }
        )]
        [TestCase(
            new[] { "Joe", "Stephen", "Peter" },
            new String[] { }
        )]
        [TestCase(
            new String[] { },
            new String[] { }
        )]
        public void SampleTests(string[] names, IEnumerable<string> expected)
        {
            CollectionAssert.AreEqual(expected, FriendOrFoeTask.FriendOrFoe(names));
        }
    }
}