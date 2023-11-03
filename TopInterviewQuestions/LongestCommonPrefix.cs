using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

namespace TopInterviewQuestions
{
  public static class LongestCommonPrefix
  {
    /// <summary>
    // Write a function to find the longest common prefix string amongst an array of strings.
    // If there is no common prefix, return an empty string "".
    /// </summary>
    /// <param name="strs">["flower","flow","flight"]</param>
    /// <returns>fl</returns>
    /// Input: strs = ["dog","racecar","car"]
    // Output: ""
    // Explanation: There is no common prefix among the input strings.
    public static string Solution(string[] strs)
    {
      var shortestWord = strs.Where(o => o.Length == strs.Select(s => s.Length).Min()).FirstOrDefault();
      var letters = new List<string>();
      int i = 0;
      while (i < shortestWord?.Length)
      {
        var leters = strs.Select(m => m.Substring(i, 1));
        var result1 = shortestWord.Substring(i, 1);
        if (leters.Distinct().Count() == result1.Length)
        {
          letters.Add(result1);
        }
        else { break; }
        i++;
      }
      return string.Concat(letters);
    }
  }
}
