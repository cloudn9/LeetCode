using System.Collections.Generic;

namespace DS1
{
  public static class InorderTraversal
  {
    public static IList<int?> Solution(TreeNode root)
    {
      var result = new List<int?>();
      TraverseTree(root, result);
      return result;
    }

    private static void TraverseTree(TreeNode root, List<int?> result)
    {
      if (root == null) return;
      TraverseTree(root.left, result);
      result.Add(root.val);
      TraverseTree(root.right, result);
    }
  }
}
