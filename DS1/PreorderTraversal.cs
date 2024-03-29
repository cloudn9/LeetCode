﻿using System.Collections.Generic;

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
}
