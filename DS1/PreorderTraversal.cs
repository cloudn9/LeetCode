using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Xml.Linq;

namespace DS1
{
  public static class PreorderTraversal
  {
    public static IList<int> Solution(TreeNode root)
    {
      var result = new List<int>();
      TraverseTree(root, result);
      return result;
    }

    private static void TraverseTree(TreeNode root, List<int> result)
    {
      if (root == null) return;
      result.Add(root.val);
      TraverseTree(root.left, result);
      TraverseTree(root.right, result);
    }
  }

  public class TreeNode
  {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
      this.val = val;
      this.left = left;
      this.right = right;
    }
  }
}
