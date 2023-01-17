using NUnit.Framework;


namespace DS1.Test
{
  [TestFixture]
  public class BinaryTreesTests
  {
    /// <summary>
    /// not a test, just to call the solution
    /// </summary>
    [Test]
    public static void Test1()
    {
      BinaryTreeLevelOrderTraversal.Solution(null);
    }

    [Test]
    public static void Test2()
    {
      SymmetricBinaryTree.Solution(null);
    }

    [Test]
    public static void Test3()
    {
      InvertBinaryTree.Solution(null);
    }

    [Test]
    public static void Test4()
    {
      SearchBinaryTree.Solution(null, 2);
    }

    [Test]
    public static void Test5()
    {
      InsertIntoBinaryTree.Solution(null, 5);
    }


  }
}
