using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;

namespace DS1
{
  public static class ImplementQueueWithStacks
  {
    public static bool Solution()
    {
      // Your MyQueue object will be instantiated and called as such:
      MyQueue obj = new MyQueue();
      obj.Push(1); // queue is: [1]
      obj.Push(2); // queue is: [1, 2]  (leftmost is front of the queue)
      int param_3 = obj.Peek(); // return 1
      int param_2 = obj.Pop(); // return 1, queue is [2]
      bool param_4 = obj.Empty(); // return false

      return true;
    }
  }

  public class MyQueue
  {
    private Stack<int> content = new Stack<int>();
    private Stack<int> reverseStack = new Stack<int>();

    public MyQueue()
    {

    }

    public void Push(int x)
    {
      content.Push(x);
    }

    private void ReverseStack()
    {
      while (content.Count > 0)
      {
        reverseStack.Push(content.Pop());
      }
    }

    private void RefillStack()
    {
      while (reverseStack.Count > 0)
      {
        content.Push(reverseStack.Pop());
      }
    }

    public int Pop()
    {
      ReverseStack();
      var result = reverseStack.Pop();
      RefillStack();
      return result;
    }

    public int Peek()
    {
      ReverseStack();
      var result = reverseStack.Peek();
      RefillStack();
      return result;
    }

    public bool Empty()
    {
      return content.Count == 0;
    }
  }
}
