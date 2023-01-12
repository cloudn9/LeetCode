using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;

namespace DS1
{
  public static class LinkedListCycle
  {
    /// <summary>
    /// Input: head = [3,2,0,-4], pos = 1
    /// Explanation: There is a cycle in the linked list, where the tail connects to the 1st node(0-indexed).
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public static bool Solution(ListNode head)
    {
      HashSet<ListNode> found = new HashSet<ListNode>();
      ListNode temp = head;
      while (temp != null)
      {
        if (found.Contains(temp))
          return true;
        found.Add(temp);
        temp = temp.next;
      }
      return false;
    }
  }
}
