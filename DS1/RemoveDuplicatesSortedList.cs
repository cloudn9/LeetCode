namespace DS1
{
    public static class RemoveDuplicatesSortedList
  {
    /// <summary>
    /// Input: head = [1,1,2]
    /// Output: [1,2]
    /// </summary>
    /// <returns></returns>
    public static ListNode1 Solution(ListNode1 head)
    {
      var p1 = new ListNode1(1);
      var p2 = new ListNode1(1);
      var p3 = new ListNode1(2);
      var p4 = new ListNode1(3);

      p1.next = p2;
      p2.next = p3;
      p3.next = p4;

      return p1.Distinct();
    }
  }

  static class Extensions3
  {
    internal static ListNode1 Distinct(this ListNode1 head)
    {
      var empty = new ListNode1(0, head);
      var prev = empty;
      var curr = head;

      while (curr.next != null)
      {
        if (curr.val == curr.next.val)
        {
          prev.next = curr.next;
        }
        else
        {
          prev = curr;
        }

        curr = curr.next;
      }

      return empty.next;
    }
  }
}
