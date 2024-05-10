using System.Collections.Immutable;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LeetCode75
{
    public static class IsSubsequence

    {
        /// <summary>
        /// Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
        /// A subsequence of a string is a new string that is formed from the original string 
        /// by deleting some(can be none) of the characters without disturbing the relative positions 
        /// of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
        /// </summary>
        public static bool Solution(string s, string t)
        {
            int i = 0, j = 0;
            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                {
                    i++;
                }
                j++;
            }
            return i == s.Length;
        }
    }
}

