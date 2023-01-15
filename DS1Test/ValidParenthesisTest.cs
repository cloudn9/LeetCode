using NUnit.Framework;

namespace DS1.Test
{
  [TestFixture]
  public class ValidParenthesisTest
  {
    [Test]
    public void Test1()
    {
      Assert.AreEqual(true, ValidParenthesis.Solution("()"), "Error");
    }

    [Test]
    public static void Test2()
    {
      Assert.AreEqual(true, ValidParenthesis.Solution("()[]{}"), "Error");
    }

    [Test]
    public static void Test3()
    {
      Assert.AreEqual(false, ValidParenthesis.Solution("(]"), "Error");
    }
  }
}
