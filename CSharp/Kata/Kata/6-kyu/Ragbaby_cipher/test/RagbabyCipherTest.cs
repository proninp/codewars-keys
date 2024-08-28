using Kata._6_kyu.Ragbaby_cipher.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.Ragbaby_cipher.test;
[TestFixture]
public class RagbabyCipherTest
{
    [Test]
    public void SampleTests()
    {
        ClassicAssert.AreEqual("ihrbfj", RagbabyCipher.Encode("cipher", "cipherabdfgjklmnoqstuvwxyz"));
        ClassicAssert.AreEqual("ihrbfj", RagbabyCipher.Encode("cipher", "cccciiiiippphheeeeerrrrr"));
        ClassicAssert.AreEqual("Urew pu bq rzfsbtj.", RagbabyCipher.Encode("This is an example.", "cipher"));
        ClassicAssert.AreEqual("Urew.uRew.urEw.ureW...", RagbabyCipher.Encode("This.tHis.thIs.thiS...", "cipher"));

        ClassicAssert.AreEqual("cipher", RagbabyCipher.Decode("ihrbfj", "cipher"));
        ClassicAssert.AreEqual("This is an example.", RagbabyCipher.Decode("Urew pu bq rzfsbtj.", "cipher"));
        ClassicAssert.AreEqual("This.tHis.thIs.thiS...", RagbabyCipher.Decode("Urew.uRew.urEw.ureW...", "cipher"));

        ClassicAssert.AreEqual("This is an example.", RagbabyCipher.Encode(
          RagbabyCipher.Decode("This is an example.", "cipher"), "cipher"));
        ClassicAssert.AreEqual("This is an example.", RagbabyCipher.Decode(
          RagbabyCipher.Encode("This is an example.", "cipher"), "cipher"));

    }
}