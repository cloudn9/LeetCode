using NUnit.Framework;

using TopInterviewQuestions;

namespace TIQ.Test
{
  [TestFixture]
  public class PlusOneTest
  {
    [Test]
    public void Test1()
    {
      Assert.That(PlusOne.Solution(new int[] { 1, 2, 3 }), Is.EqualTo(new int[] { 1, 2, 4 }), "Error", null);
    }

    [Test]
    public void Test2()
    {
      Assert.That(PlusOne.Solution(new int[] { 4, 3, 2, 1 }), Is.EqualTo(new int[] { 4, 3, 2, 2 }), "Error", null);
    }

    [Test]
    public void Test3()
    {
      Assert.That(PlusOne.Solution(new int[] { 9 }), Is.EqualTo(new int[] { 1, 0 }), "Error", null);
    }

    [Test]
    public void Test4()
    {
      Assert.That(PlusOne.Solution(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }),
        Is.EqualTo(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 }), "Error", null);
    }


    [Test]
    public void Test5()
    {
      Assert.That(PlusOne.Solution(new int[] { 6, 1, 4, 5, 3, 9, 0, 1, 9, 5, 1, 8, 6, 7, 0, 5, 5, 4, 3 }),
        Is.EqualTo(new int[] { 6, 1, 4, 5, 3, 9, 0, 1, 9, 5, 1, 8, 6, 7, 0, 5, 5, 4, 4 }), "Error", null);
    }

    [Test]
    public void Test6()
    {
      Assert.That(PlusOne.Solution(new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 }),
        Is.EqualTo(new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 7 }), "Error", null);
    }
  }
}