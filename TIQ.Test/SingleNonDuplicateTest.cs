using NUnit.Framework;

using TopInterviewQuestions;

namespace TIQ.Test
{
  [TestFixture]
  public class SingleNonDuplicateTest
  {
    [Test]
    public void Test1()
    {
      Assert.That(SingleNonDuplicate.Solution(new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 }), Is.EqualTo(2), "Error", null);
    }

    [Test]
    public void Test2()
    {
      Assert.That(SingleNonDuplicate.Solution(new int[] { 3, 3, 7, 7, 10, 11, 11 }), Is.EqualTo(10), "Error", null);
    }
  }
}