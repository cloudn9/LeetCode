using NUnit.Framework;

namespace DS1.Test
{
    [TestFixture]
  public class MatrixReshapeTest
  {
    [Test]
    public static void Test1()
    {
      var rows = 1;
      var cols = 4;
      int[][] content = {
        new int[] { 1, 2 },
        new int[] { 3, 4 }
      };

      Assert.AreEqual(new int[][]
      {
        new int[] { 1, 2, 3, 4 }
      }, MatrixReshape.Solution(content, rows, cols), "Error");
    }

    [Test]
    public static void Test2()
    {
      var rows = 2;
      var cols = 4;
      int[][] content = {
        new int[] { 1, 2 },
        new int[] { 3, 4 }
      };

      Assert.AreEqual(content, MatrixReshape.Solution(content, rows, cols), "Error");
    }

    [Test]
    public static void Test3()
    {
      var rows = 4;
      var cols = 1;
      int[][] content = {
        new int[] { 1 }, new int[] { 2 }, new int[] { 3 }, new int[] { 4 }
      };

      Assert.AreEqual(content, MatrixReshape.Solution(content, rows, cols), "Error");
    }
  }
}
