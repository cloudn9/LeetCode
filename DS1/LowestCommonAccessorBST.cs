namespace DS1
{
    public static class LowestCommonAccessorBST
  {
    public static TreeNode Solution(TreeNode root, TreeNode p, TreeNode q)
    {
      var current = root;

      while (current != null)
      {
        if (p.val > current.val && q.val > current.val)
          current = current.right;
        else if (p.val < current.val && q.val < current.val)
          current = current.left;
        else
          return current;
      }

      return current;
    }

    public static TreeNode Solution1(TreeNode root, TreeNode p, TreeNode q)
    {
      while (root != null)
      {
        if (root.val > p.val && root.val > q.val)
          root = root.left;
        else if (root.val < p.val && root.val < q.val)
          root = root.right;
        else
          return root;
      }
      return null;
    }
  }
}
