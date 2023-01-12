using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;

namespace DS1
{
  public static class ValidAnagram
  {
    public static bool Solution(string s, string t)
    {
      if (s.Distinct().Count() != t.Distinct().Count())
      {
        return false;
      }

      if (s.Length != t.Length)
      {
        return false;
      }

      var charCount = new Dictionary<char, int>();
      for (int i = 0; i < s.Length; i++)
      {
        charCount.TryAdd(s[i], 0);
        charCount.TryAdd(t[i], 0);

        charCount[s[i]]++;
        charCount[t[i]]--;
      }

      return charCount.Values.All(frequence => frequence == 0);
    }
  }
}
