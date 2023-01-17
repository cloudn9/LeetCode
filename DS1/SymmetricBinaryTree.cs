using System;
using System.Collections.Generic;

namespace DS1
{
  public static class SymmetricBinaryTree
  {
    /// <summary>
    /// Input root = [1,2,2,3,4,4,3]
    /// Output true
    /// Input root = [1,2,2,null,3,null,3]
    /// Output false
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public static bool Solution(TreeNode root)
    {
      var tree = new TreeNode(1,
new TreeNode(2, new TreeNode(3), new TreeNode(4)),
new TreeNode(2, new TreeNode(4), new TreeNode(3)));


      if (tree != null)
      {
        return isMirror(tree.left, tree.right);
      }
      return false;
    }

    private static bool isMirror(TreeNode leftNode, TreeNode rightNode)
    {
      if (leftNode is null && rightNode is null)
        return true;
      if (leftNode != null && rightNode !=null 
        && leftNode.val == rightNode.val)
      {
        var result = isMirror(leftNode.left, rightNode.right)
          && isMirror(leftNode.right, rightNode.left);
        return result;
      }
      return false;
    }
  }
}
