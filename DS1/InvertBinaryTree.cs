using System;
using System.Collections.Generic;

namespace DS1
{
  public static class InvertBinaryTree
  {
    /// <summary>
    /// Input: root = [4,2,7,1,3,6,9]
    /// Output: [4,7,2,9,6,3,1]
    /// Input: root = [2,1,3]
    /// Output: [2,3,1]
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public static TreeNode Solution(TreeNode root)
    {
      var tree = new TreeNode(4,
new TreeNode(2, new TreeNode(1), new TreeNode(3)),
new TreeNode(7, new TreeNode(6), new TreeNode(9)));
      // var tree = new TreeNode(2, new TreeNode(1), new TreeNode(3));
      return GetInverted(tree);
    }

    private static TreeNode GetInverted(TreeNode treeNode)
    {
      if (treeNode == null)
      {
        return null;
      }

      _ = GetInverted(treeNode.left);
      _ = GetInverted(treeNode.right);

      var temp = treeNode.left;
      treeNode.left = treeNode.right;
      treeNode.right = temp;

      return treeNode;

      //if (treeNode == null)
      //{
      //  return treeNode;
      //}
      //GetInverted(treeNode.left);
      //GetInverted(treeNode.right);
      //(treeNode.left, treeNode.right) = (treeNode.right, treeNode.left);
      //return treeNode;
    }
  }
}
