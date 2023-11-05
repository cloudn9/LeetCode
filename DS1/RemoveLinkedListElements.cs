namespace DS1
{
    public static class RemoveLinkedListElements
  {
    /// <summary>
    /// Input: head = [1,2,6,3,4,5,6], val = 6
    /// Output: [1,2,3,4,5]
    /// </summary>
    /// <returns></returns>
    public static ListNode1 Solution(ListNode1 head, int value)
    {
      var p1 = new ListNode1(1);
      var p2 = new ListNode1(2);
      var p3 = new ListNode1(6);
      var p4 = new ListNode1(6);

      p1.next = p2;
      p2.next = p3;
      p3.next = p4;

      return p1.Distinct(value);
    }
  }

  static class Extensions1
  {
    internal static ListNode1 Distinct(this ListNode1 head, int value)
    {
      var empty = new ListNode1(0, head);
      var prev = empty;
      var curr = head;

      while (curr != null)
      {
        if (curr.val == value)
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
