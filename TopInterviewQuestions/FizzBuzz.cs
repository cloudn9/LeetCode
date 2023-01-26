using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterviewQuestions
{
  public static class FizzBuzz
  {
    /// <summary>
    /// answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
    /// answer[i] == "Fizz" if i is divisible by 3.
    /// answer[i] == "Buzz" if i is divisible by 5.
    /// answer[i] == i(as a string) if none of the above conditions are true.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static IList<string> Solution(int n)
    {
      var input = Enumerable.Range(1, n);
      return input.Select(k => CheckNumber(k)).ToList();
    }

    private static string CheckNumber(int k)
    {
      if (k % 3 == 0)
      {
        return k % 5 == 0 ? "FizzBuzz" : "Fizz";
      }
      else if (k % 5 == 0)
      {
        return "Buzz";
      }
      return k.ToString();
    }

    public static IList<string> FizzBuzz1(int n)
    {
      return Enumerable
          .Range(1, n)
          .Select(x =>
              (x % 3, x % 5) switch
              {
                (0, 0) => "FizzBuzz",
                (0, _) => "Fizz",
                (_, 0) => "Buzz",
                _ => x.ToString()
              })
          .ToList();
    }

    public class Solution1
    {
      public IList<string> FizzBuzz(int n) =>
      Enumerable.Range(1, n).Select(i => i % 3 == 0 ? i % 5 == 0 ? "FizzBuzz" : "Fizz" : i % 5 == 0 ? "Buzz" : i.ToString()).ToList();
    }
  }
}
