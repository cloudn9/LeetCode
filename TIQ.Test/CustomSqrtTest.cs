using NUnit.Framework;

using TopInterviewQuestions;

namespace TIQ.Test
{
  [TestFixture]
  public class CustomSqrtTest
  {
    [Test]
    public void Test1()
    {
      Assert.That(CustomSqrt.Solution(4), Is.EqualTo(2), "Error", null);
    }

    [Test]
    public void Test2()
    {
      /// The square root of 8 is 2.82842..., 
      /// and since we round it down to the nearest integer, 2 is returned.
      Assert.That(CustomSqrt.Solution(8), Is.EqualTo(2), "Error", null);
    }
  }
}