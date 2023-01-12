using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Transactions;

namespace DS1
{
  public static class ReverseLinkedList
  {
    /// <summary>
    /// Input: head = [1,2,3,4,5]
    /// Output: [5,4,3,2,1]
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public static ListNode1 Solution(ListNode1 head)
    {
      var p1 = new ListNode1(1);
      var p2 = new ListNode1(2);
      var p3 = new ListNode1(3);
      var p4 = new ListNode1(4);

      p1.next = p2;
      p2.next = p3;
      p3.next = p4;

      return p1.Reverse();
    }
  }

  static class Extensions2
  {
    internal static ListNode1 Reverse(this ListNode1 head)
    {
      if (head == null)
      {
        return head;
      }

      var reversed = new ListNode1(head.val);
      head = head.next;
      while (head != null)
      {
        reversed = new ListNode1(head.val, reversed);
        head = head.next;
      }

      return reversed;
    }
  }
}
