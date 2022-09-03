using DS1;

using NUnit.Framework;


namespace DS1.Test
{
  [TestFixture]
  public class MaximumSubarrayTest
  {
    [Test]
    public static void Test1()
    {
      Assert.AreEqual(6,
          MaximumSubarray.Solution(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
    }

    [Test]
    public static void Test2()
    {
      Assert.AreEqual(1, MaximumSubarray.Solution(new int[] { 1 }));
    }

    [Test]
    public static void Test3()
    {
      Assert.AreEqual(23,
       MaximumSubarray.Solution(new int[] { 5, 4, -1, 7, 8 }));
    }

    [Test]
    public static void Test4()
    {
      Assert.AreEqual(1,
       MaximumSubarray.Solution(new int[] { -2, 1 }));
    }

    [Test]
    public static void Test5()
    {
      Assert.AreEqual(3,
       MaximumSubarray.Solution(new int[] { 1, 2 }));
    }

    [Test]
    public static void Test6()
    {
      Assert.AreEqual(3,
       MaximumSubarray.Solution(new int[] { 3, -2, -1 }));
    }
  }
}
