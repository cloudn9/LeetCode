using NUnit.Framework;

namespace DS1.Test
{
  [TestFixture]
  public class Search2DMatrixTest
  {
    [Test]
    public void Test1()
    {
      var matrix = new int[][]
            {
          new int[] { 1,3,5,7 },
          new int[] { 10,11,16,20 },
          new int[] { 23,30,34,60 },
            };

      Assert.AreEqual(true, Search2DMatrix.Solution(matrix, 3), "Error");
    }

    [Test]
    public static void Test2()
    {
      var matrix = new int[][]
             {
          new int[] { 1,3,5,7 },
          new int[] { 10,11,16,20 },
          new int[] { 23,30,34,60 },
             };

      Assert.AreEqual(false, Search2DMatrix.Solution(matrix, 13), "Error");
    }

    [Test]
    public static void Test3()
    {
      var matrix = new int[][]
             {
              new int[] {1},
             };

      Assert.AreEqual(true, Search2DMatrix.Solution(matrix, 1), "Error");
    }
  }
}
