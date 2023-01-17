using System;
using System.Collections.Generic;

namespace DS1
{
  public static class SearchBinaryTree
  {
    /// <summary>
    /// Input: root = [4,2,7,1,3], val = 2
    /// Output: [2,1,3]
    /// Input: root = [4,2,7,1,3], val = 5
    /// Output: []
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public static TreeNode Solution(TreeNode root, int val)
    {
      var tree = new TreeNode(4,
new TreeNode(2, new TreeNode(1), new TreeNode(3)),
new TreeNode(7));
      return SearchForNumIn(tree, val);
    }

    private static TreeNode SearchForNumIn(TreeNode treeNode, int val)
    {
      if (treeNode == null)
      {
        return null;
      }

      if (treeNode.val == val)
      {
        return treeNode;
      }

      var p1 = SearchForNumIn(treeNode.left, val);
      if (p1 is null)
      {
        p1 = SearchForNumIn(treeNode.right, val);
      }

      return p1;

    }
  }
}
