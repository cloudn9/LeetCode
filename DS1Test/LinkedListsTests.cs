using NUnit.Framework;


namespace DS1.Test
{
  [TestFixture]
  public class LinkedListsTests
  {
    /// <summary>
    /// not a test, just to call the solution
    /// </summary>
    [Test]
    public static void Test1()
    {
      MergeTwoSortedLists.Solution(null, null);
    }

    [Test]
    public static void Test2()
    {
      RemoveLinkedListElements.Solution(null, 6);
    }

    [Test]
    public static void Test3()
    {
      ReverseLinkedList.Solution(null);
    }

    [Test]
    public static void Test4()
    {
      RemoveDuplicatesSortedList.Solution(null);
    }
  }
}
