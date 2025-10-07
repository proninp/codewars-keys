using Kata._7_kyu.By_3_or_not_by_3_That_is_the_question.src;
using NUnit.Framework;

namespace Kata._7_kyu.By_3_or_not_by_3_That_is_the_question.test;
[TestFixture]
public class By3OrNotBy3ThatIsTheQuestionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(By3OrNotBy3ThatIsTheQuestion.DivisibleByThree("1891009"), Is.EqualTo(false));
        Assert.That(By3OrNotBy3ThatIsTheQuestion.DivisibleByThree("00009"), Is.EqualTo(true));
        Assert.That(By3OrNotBy3ThatIsTheQuestion.DivisibleByThree("57"), Is.EqualTo(true));
    }
}