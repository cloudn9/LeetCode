namespace DS1
{
    public static class PathSumBinaryTree
  {
    /// <summary>
    /// Input: root = [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22
    /// Output: true
    /// Input: root = [1,2,3], targetSum = 5
    /// Output: false
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public static bool Solution(TreeNode root, int targetSum)
    {
      var tree = new TreeNode(5,
            new TreeNode(4, new TreeNode(11,
                                          new TreeNode(7),
                                          new TreeNode(2)),
                                     null),
           new TreeNode(8, new TreeNode(13), 
                                    new TreeNode(4, null, new TreeNode(1))));
      // var tree = new TreeNode(2, new TreeNode(1), new TreeNode(3));
      return CheckSum(tree, targetSum);
    }


    private static bool CheckSum(TreeNode root, int sum)
    {
      if (root == null) { return false; }
      else if (root.val == sum && root.left == null && root.right == null)
      {
        return true;
      }
      else
      {
        return CheckSum(root.left, sum - root.val)
          || CheckSum(root.right, sum - root.val);
      }
    }
  }
}
