using Kata._6_kyu.IP_Validation.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.IP_Validation.test;

[TestFixture]
public class IPValidationTest
{
    [Test]
    public void TestCases()
    {
        ClassicAssert.AreEqual(true, IPValidation.IsValidIp("0.0.0.0"));
        ClassicAssert.AreEqual(true, IPValidation.IsValidIp("12.255.56.1"));
        ClassicAssert.AreEqual(true, IPValidation.IsValidIp("137.255.156.100"));

        ClassicAssert.AreEqual(false, IPValidation.IsValidIp(""));
        ClassicAssert.AreEqual(false, IPValidation.IsValidIp("abc.def.ghi.jkl"));
        ClassicAssert.AreEqual(false, IPValidation.IsValidIp("123.456.789.0"));
        ClassicAssert.AreEqual(false, IPValidation.IsValidIp("12.34.56"));
        ClassicAssert.AreEqual(false, IPValidation.IsValidIp("12.34.56.00"));
        ClassicAssert.AreEqual(false, IPValidation.IsValidIp("12.34.56.7.8"));
        ClassicAssert.AreEqual(false, IPValidation.IsValidIp("12.34.256.78"));
        ClassicAssert.AreEqual(false, IPValidation.IsValidIp("1234.34.56"));
        ClassicAssert.AreEqual(false, IPValidation.IsValidIp("pr12.34.56.78"));
        ClassicAssert.AreEqual(false, IPValidation.IsValidIp("12.34.56.78sf"));
        ClassicAssert.AreEqual(false, IPValidation.IsValidIp("12.34.56 .1"));
        ClassicAssert.AreEqual(false, IPValidation.IsValidIp("12.34.56.-1"));
        ClassicAssert.AreEqual(false, IPValidation.IsValidIp("123.045.067.089"));
    }
}