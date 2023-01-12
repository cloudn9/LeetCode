using NUnit.Framework;

namespace DS1.Test
{
  [TestFixture]
  public class RansomNoteTest
  {
    [Test]
    public void Test1()
    {
      Assert.AreEqual(false, RansomNote.Solution("a", "b"), "Error");
    }

    [Test]
    public static void Test2()
    {
      Assert.AreEqual(false, RansomNote.Solution("aa", "ab"), "Error");
    }

    [Test]
    public static void Test3()
    {
      Assert.AreEqual(true, RansomNote.Solution("aa", "aab"), "Error");
    }

    [Test]
    public static void Test4()
    {
      Assert.AreEqual(true, RansomNote.Solution("aab", "baa"), "Error");
    }
  }
}
