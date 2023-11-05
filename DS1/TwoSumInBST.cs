using System.Collections.Generic;

namespace DS1
{
    public static class TwoSumInBST
  {
    static HashSet<int> seen = new HashSet<int>();
    /// <summary>
    /// Input: root = [5,3,6,2,4,null,7], k = 9
    /// Output: true
    /// Input: root = [5,3,6,2,4,null,7], k = 28
    /// Output: false
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static bool Solution(TreeNode root, int k)
    {
      return CheckSum(root, k);
    }

    private static bool CheckSum(TreeNode root, int k)
    {
      if (root is null) return false;
      if (seen.Contains(k - root.val)) return true;
      seen.Add(root.val);
      return CheckSum(root.left, k) || CheckSum(root.right, k);
    }
  }
}
