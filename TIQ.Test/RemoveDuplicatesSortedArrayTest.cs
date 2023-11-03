using NUnit.Framework;

using TopInterviewQuestions;

namespace TIQ.Test
{
  [TestFixture]
  public class RemoveDuplicatesSortedArrayTest
  {
    [Test]
    public void Test1()
    {
      Assert.That(RemoveDuplicatesSortedArray.Solution(new int[] { 1, 1, 2 }), Is.EqualTo(2), "Error", null);
    }

    [Test]
    public void Test2()
    {
      Assert.That(RemoveDuplicatesSortedArray.Solution(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }),
        Is.EqualTo(5), "Error", null);
    }
  }
}