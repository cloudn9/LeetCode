using System;
using System.Collections.Generic;

namespace DS1
{
  public static class InsertIntoBinaryTree
  {
    /// <summary>
    /// Input: root = [4,2,7,1,3], val = 5
    /// Output: [4,2,7,1,3,5]
    /// Input: root = [40,20,60,10,30,50,70], val = 25
    /// Output: [40,20,60,10,30,50,70,null,null,25]
    /// Input: root = [4,2,7,1,3,null,null,null,null,null,null], val = 5
    /// Output: [4,2,7,1,3,5]
    /// Notice that there may exist multiple valid ways for the insertion, 
    /// as long as the tree remains a BST after insertion. You can return any of them
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public static TreeNode Solution(TreeNode root, int val)
    {
      root = new TreeNode(4,
                new TreeNode(2, new TreeNode(1), new TreeNode(3)),
                new TreeNode(7));

      return InsertIn(root, val);
    }

    private static TreeNode InsertIn(TreeNode root, int val)
    {
      if (root == null)
      {
        return new TreeNode(val);
      }

      if (val < root.val)
      {
        if (root.left == null)
        {
          root.left = new TreeNode(val);
        }
        else
        {
          InsertIn(root.left, val);
        }
        return root;
      }
      else
      {
        if (root.right == null)
        {
          root.right = new TreeNode(val);
        }
        else
        {
          InsertIn(root.right, val);
        }
        return root;
      }
    }
  }
}
