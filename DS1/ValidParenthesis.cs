using System;
using System.Collections.Generic;
using System.Linq;

namespace DS1
{
    public static class ValidParenthesis
  {
    public static bool Solution(string s)
    {
      char[] opening = new char[] { '(', '{', '[' };

      var result = new Stack<char>();

      for (int i = 0; i < s.Length; i++)
      {
        if (opening.Contains(s[i]))
        {
          result.Push(s[i]);
        }
        else
        {
          if (result.TryPeek(out var top) && MatchOpening(s[i]) == top)
          {
            result.Pop();
          }
          else return false;
        }
      }

      return result.Count == 0;
    }

    private static char MatchOpening(char v)
    {
      switch (v)
      {
        case ')':
          return '(';
        case '}':
          return '{';
        case ']':
          return '[';
        default:
          return default;
      }
    }
  }
}
