using System.Text;

namespace LeetCode75
{
    public static class ReverseWords

    {
        /// <summary>
        /// Given an input string s, reverse the order of the words.
        /// A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.
        /// Return a string of the words in reverse order concatenated by a single space.
        /// Note that s may contain leading or trailing spaces or multiple spaces between two words. 
        /// The returned string should only have a single space separating the words. Do not include any extra spaces.
        /// </summary>
        public static string Solution(string s)
        {
            var words = s.Split(' ').Where(p => p.Length > 0)
                         .ToArray().AsSpan();
            words.Reverse();
            return string.Join(' ', words.ToArray());
        }
    }
}

