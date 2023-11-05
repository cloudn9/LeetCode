using System.Collections.Generic;
using System.Linq;

namespace DS1
{
    public static class ValidateBinaryTree
  {
    /// <summary>
    /// It is valid if
    /// The left subtree of a node contains only nodes with keys less than the node's key.
    /// The right subtree of a node contains only nodes with keys greater than the node's key.
    /// Both the left and right subtrees must also be binary search trees.
    /// Input: root = [2,1,3]
    /// Output: true
    /// Input: root = [5,1,4,null,null,3,6]
    /// Output: false
    /// Explanation: The root node's value is 5 but its right child's value is 4.
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public static bool Solution(TreeNode root)
    {
      var result = new List<int?>();
      TraverseTree(root, result);
      for (int i = 0; i < result.Count - 1; i++)
      {
        if (result[i] >= result[i + 1])
        {
          return false;
        }
      }
      return true;
    }

    private static void TraverseTree(TreeNode root, List<int?> result)
    {
      if (root == null) return;
      TraverseTree(root.left, result);
      result.Add(root.val);
      TraverseTree(root.right, result);
    }

    public static bool Solution2(TreeNode root)
    {
      var sortedlist = BuildSortedList(root);

      //Once the inorder traversal is complete, if it;s a valid BST, 
      //then we will have sortedList(nodes are stored in ascending order), 
      //if not, that means it's not a valid BST. 
      for (int i = 0; i < sortedlist.Count - 1; i++)
      {
        if (sortedlist[i] >= sortedlist[i + 1])
        {
          return false;
        }
      }
      return true;
    }

    public static List<int> BuildSortedList(TreeNode node)
    {
      List<int> sortedlist = new List<int>();

      //Performing Inorder traversal
      if (node == null) return sortedlist;
      BuildSortedList(node.left);
      sortedlist.Add(node.val);
      BuildSortedList(node.right);

      return sortedlist;
    }

    public static bool Solution1(TreeNode root)
    {
      int? l = null;
      Stack<TreeNode> s = new Stack<TreeNode>();
      TreeNode cur = root;
      while (cur != null || s.Count() > 0)
      {
        while (cur != null)
        {
          s.Push(cur);
          cur = cur.left;
        }
        cur = s.Pop();
        if (l != null && l >= cur.val) return false;
        l = cur.val;
        cur = cur.right;
      }

      return true;
    }
  }
}
