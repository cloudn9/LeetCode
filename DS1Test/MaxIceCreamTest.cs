using NUnit.Framework;


namespace DS1.Test
{
  [TestFixture]
  public class MaxIceCreamTest
  {
    [Test]
    public static void Test1()
    {
      Assert.AreEqual(4,
          MaxIceCream.Solution(new int[] { 1, 3, 2, 4, 1 }, 7), "Error");
    }

    [Test]
    public static void Test2()
    {
      Assert.AreEqual(0,
      MaxIceCream.Solution(new int[] { 10, 6, 8, 7, 7, 8 }, 5), "Error");
    }

    [Test]
    public static void Test3()
    {
      Assert.AreEqual(6,
          MaxIceCream.Solution(new int[] { 1, 6, 3, 1, 2, 5 }, 20), "Error");
    }


    [Test]
    public static void Test4()
    {
      Assert.AreEqual(24,
          MaxIceCream.Solution(new int[] { 27, 23, 33, 26, 46, 86, 70, 85, 89, 82, 57,
            66, 42, 18, 18, 5, 46, 56, 42, 82, 52, 78, 4, 27, 96, 74, 74, 52, 2, 24, 78,
            18, 42, 10, 12, 10, 80, 30, 60, 38, 32, 7, 98, 26, 18, 62, 50, 42, 15, 14, 32,
            86, 93, 98, 47, 46, 58, 42, 74, 69, 51, 53, 58, 40, 66, 46, 65, 2, 10, 82, 94,
            26, 6, 78, 2, 101, 97, 16, 12, 18, 71, 5, 46, 22, 58, 12, 18, 62, 61, 51, 2, 18,
            34, 12, 36, 58, 20, 12, 17, 70 }, 241), "Error");
    }
  }
}
