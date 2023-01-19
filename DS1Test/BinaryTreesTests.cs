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

    [Test]
    public static void Test6()
    {
      var tree = new TreeNode(5,
new TreeNode(1), new TreeNode(4, new TreeNode(3), new TreeNode(6)));
      Assert.IsFalse(ValidateBinaryTree.Solution(tree), "Error");
    }

    [Test]
    public static void Test7()
    {
      var tree = new TreeNode(2, new TreeNode(1), new TreeNode(3));
      Assert.IsTrue(ValidateBinaryTree.Solution(tree), "Error");
    }

    [Test]
    public static void Test8()
    {
      var tree = new TreeNode(0, new TreeNode(-1));
      Assert.IsTrue(ValidateBinaryTree.Solution(tree), "Error");
    }

    [Test]
    public static void Test9()
    {
      var tree = new TreeNode(1, new TreeNode(1));
      Assert.IsFalse(ValidateBinaryTree.Solution(tree), "Error");
    }

    [Test]
    public static void Test10()
    {
      var tree = new TreeNode(5,
 new TreeNode(3, new TreeNode(2), new TreeNode(4)),
 new TreeNode(6, null, new TreeNode(7)));
      Assert.IsTrue(TwoSumInBST.Solution(tree, 9), "Error");
    }
  }
}
