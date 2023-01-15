using System;
using System.Collections.Generic;

namespace DS1
{
  public static class BinaryTreeLevelOrderTraversal
  {
    /// <summary>
    /// Input [3,9,20,null,null,15,7]
    /// Output [[3],[9,20],[15,7]]
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public static IList<IList<int>> Solution(TreeNode root)
    {
      var tree = new TreeNode(3,
    new TreeNode(9),
    new TreeNode(20, new TreeNode(15, null, null), new TreeNode(17)));


      var result = new List<IList<int>>();
      var height = GetHeight(tree);
      for (int i = 1; i <= height; i++)
      {
        result.Add(GetLevelData(tree, i));
      }
      return null;
    }

    private static List<int> GetLevelData(TreeNode root, int level)
    {
      var levelData = new List<int>();
      if (root != null)
      {
        if (level == 1)
        {
          levelData.Add(root.val);
        }
        else if (level > 1)
        {
          levelData.AddRange(GetLevelData(root.left, level - 1));
          levelData.AddRange(GetLevelData(root.right, level - 1));
        }
      }
      return levelData;
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
  }
}
