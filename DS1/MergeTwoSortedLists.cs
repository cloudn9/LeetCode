namespace DS1
{
  public static class MergeTwoSortedLists
  {
    /// <summary>
    /// Input: list1 = [1,2,4], list2 = [1,3,4]
    /// Output: [1,1,2,3,4,4]
    /// </summary>
    /// <param name="head"></param>
    /// <returns></returns>
    public static ListNode Solution(ListNode list1, ListNode list2)
    {
      var p1 = new ListNode(1);
      var p2 = new ListNode(2);
      var p3 = new ListNode(4);

      p1.next = p2;
      p2.next = p3;

      var p4 = new ListNode(1);
      var p5 = new ListNode(3);
      var p6 = new ListNode(4);

      p4.next = p5;
      p5.next = p6;

      return p1.Merge(p4);
    }
  }

  static class Extensions
  {
    internal static ListNode Merge(this ListNode first, ListNode second)
    {
      var result = new ListNode(-1);
      ListNode head = result;
      while (first != null || second != null)
      {
        if ((first != null && second == null) ||
            (first != null && second != null && first.val < second.val))
        {
          ListNode curr = new ListNode(first.val);
          head.next = curr;
          first = first.next;
        }
        else
        {
          ListNode curr = new ListNode(second.val);
          head.next = curr;
          second = second.next;
        }
        head = head.next;
      }
      return result.next;
    }
  }

  public class ListNode
  {
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
      val = x;
      next = null;
    }
  }
}
