using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;

namespace DS1
{
  public static class RansomNote
  {
    public static bool Solution(string ransomNote, string magazine)
    {
      Dictionary<char, int> letters = new Dictionary<char, int>();
      foreach (char letter in magazine)
      {
        if (letters.ContainsKey(letter))
        {
          letters[letter] += 1;
        }
        else
        {
          letters[letter] = 1;
        }
      }
      foreach (char c in ransomNote)
      {
        if (letters.ContainsKey(c) && letters[c] > 0)
        {
          letters[c] -= 1;
        }
        else
        {
          return false;
        }
      }
      return true;
    }
  }

  /// <summary>
  /// Another solution
  /// </summary>
  public class Solution
  {
    public bool CanConstruct(string ransomNote, string magazine)
    {
      var copy = new List<char>(ransomNote);
      foreach (var letter in magazine)
      {
        copy.Remove(letter);
      }
      return copy.Count == 0;
    }
  }

}
