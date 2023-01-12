using NUnit.Framework;

namespace DS1.Test
{
  [TestFixture]
  public class ValidAnagramTest
  {
    [Test]
    public void Test1()
    {
      Assert.AreEqual(true, ValidAnagram.Solution(
        "anagram", "nagaram"), "Error");
    }

    [Test]
    public static void Test2()
    {
      Assert.AreEqual(false, ValidAnagram.Solution("rat",
        "car"), "Error");
    }
  }
}
