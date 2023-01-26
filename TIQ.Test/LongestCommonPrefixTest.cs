using NUnit.Framework;

using TopInterviewQuestions;

namespace TIQ.Test
{
  [TestFixture]
  public class LongestCommonPrefixTest
  {
    [Test]
    public void Test1()
    {
      Assert.That(LongestCommonPrefix.Solution(new string[] { "flower", "flow", "flight" }), Is.EqualTo("fl"), "Error", null);
    }

    [Test]
    public void Test2()
    {
      Assert.That(LongestCommonPrefix.Solution(new string[] { "dog", "racecar", "car" }), Is.EqualTo(string.Empty), "Error", null);
    }

    [Test]
    public void Test3()
    {
      Assert.That(LongestCommonPrefix.Solution(new string[] { "a" }), Is.EqualTo("a"), "Error", null);
    }

    [Test]
    public void Test4()
    {
      Assert.That(LongestCommonPrefix.Solution(new string[] { "" }), Is.EqualTo(""), "Error", null);
    }

    [Test]
    public void Test5()
    {
      Assert.That(LongestCommonPrefix.Solution(new string[] { "", "b" }), Is.EqualTo(""), "Error", null);
    }

    [Test]
    public void Test6()
    {
      Assert.That(LongestCommonPrefix.Solution(new string[] { "cir", "car" }), Is.EqualTo("c"), "Error", null);
    }

    [Test]
    public void Test7()
    {
      Assert.That(LongestCommonPrefix.Solution(new string[] { "reflower", "flow", "flight" }), Is.EqualTo(""), "Error", null);
    }
  }
}