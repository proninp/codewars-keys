using Kata._6_kyu.String_subpattern_recognition_I.src;
using NUnit.Framework;

namespace Kata._6_kyu.String_subpattern_recognition_I.test;

public sealed class StringSubpatternRecognitionITest
{
    [Test]
    public void FixedTest()
    {
        Assert.That(StringSubpatternRecognitionI.HasSubpattern("a"), Is.EqualTo(false));
        Assert.That(StringSubpatternRecognitionI.HasSubpattern("aaaa"), Is.EqualTo(true));
        Assert.That(StringSubpatternRecognitionI.HasSubpattern("abcd"), Is.EqualTo(false));
        Assert.That(StringSubpatternRecognitionI.HasSubpattern("abababab"), Is.EqualTo(true));
    }
}