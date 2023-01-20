using NUnit.Framework;

using TopInterviewQuestions;

namespace TIQ.Test
{
  [TestFixture]
  public class RomanToIntegerTest
  {
    [Test]
    public void Test1()
    {
      Assert.That(RomanToInteger.Solution("III"), Is.EqualTo(3), "Error", null);
    }

    [Test]
    public void Test2()
    {
      Assert.That(RomanToInteger.Solution("LVIII"), Is.EqualTo(58), "Error", null);
    }

    [Test]
    public void Test3()
    {
      Assert.That(RomanToInteger.Solution("MCMXCIV"), Is.EqualTo(1994), "Error", null);
    }
  }
}