using System;
using System.Collections.Generic;

namespace DS1
{
  public static class MaxDepthBinaryTree
  {
    /// <summary>
    /// Input [3,9,20,null,null,15,7]
    /// Output 3
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public static int Solution(TreeNode root)
    {
      return GetHeight(root);
    }

    private static int GetHeight(TreeNode treeNode)
    {
      if (treeNode == null)
      {
        return 0;
      }

      var lh = GetHeight(treeNode.left);
      var rh = GetHeight(treeNode.right);

      return Math.Max(lh, rh) + 1;
    }

    private static int MaxDepth(TreeNode root)
    {
      var rs = 0;
      if (root == null) return rs;
      var level = new List<TreeNode> { root };
      while (level.Count > 0)
      {
        var level2 = new List<TreeNode>();
        for (int i = 0; i < level.Count; i++)
        {
          if (level[i].left != null) level2.Add(level[i].left);
          if (level[i].right != null) level2.Add(level[i].right);
        }
        rs++;
        level = level2;
      }
      return rs;
    }
  }
}
