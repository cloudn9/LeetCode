using System.Text;

namespace LeetCode75
{
    public static class MergeStringsAlternately

    {
        /// <summary>
        // You are given two strings word1 and word2.
        // Merge the strings by adding letters in alternating order, starting with word1.
        // If a string is longer than the other, append the additional letters onto the end of the merged string.
        /// Return the merged string.
        /// </summary>
        public static string Solution(string word1, string word2)
        {
            var result = new StringBuilder();
            var longestWord = word1.Length > word2.Length ? word1 : word2;
            for (int i = 0; i < longestWord.Length; i++)
            {
                result.Append(GetLetter(word1, i));
                result.Append(GetLetter(word2, i));
            }

            return result.ToString();
        }

        private static string GetLetter(string word2, int i)
        {
            return word2.Length <= i ? string.Empty : word2[i].ToString();
        }
    }
}
