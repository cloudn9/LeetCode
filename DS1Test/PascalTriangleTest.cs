using NUnit.Framework;

using System.Linq;

namespace DS1.Test
{
  [TestFixture]
  public class PascalTriangleTest
  {
    [Test]
    public static void Test1()
    {
      int[][] content = {
           new int[] {1},
          new int[] {1,1},
        new int[]  {1,2,1},
        new int[] {1,3,3,1},
        new int[]{1,4,6,4,1},
      };

      Assert.AreEqual(content, PascalTriangle.Solution(5), "Error");
    }

    [Test]
    public static void Test2()
    {
      int[][] content = {
        new int[] { 1 },
      };

      Assert.AreEqual(content, PascalTriangle.Solution(1), "Error");
    }

    [Test]
    public static void Test3()
    {
      int[][] content = {
        new int[] { 1 },
      };

      Assert.AreEqual(content, PascalTriangle.Solution(1), "Error");
    }

    [Test]
    public static void Test5()
    {
      int[][] content = {
           new int[] {1},
          new int[] {1,1},
        new int[]  {1,2,1},
        new int[] {1,3,3,1},
        new int[]{1,4,6,4,1},
        new int[]{1,5,10,10,5,1},
      };

      Assert.AreEqual(content, PascalTriangle.Solution(6), "Error");
    }
  }
}
