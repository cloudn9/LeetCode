using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode75
{
    public static class ReverseVowels

    {
        /// <summary>
        /// Given a string s, reverse only all the vowels in the string and return it.
        /// The vowels are 'a', 'e', 'i', 'o', and 'u', 
        /// and they can appear in both lower and upper cases, more than once.
        /// </summary>
        public static string Solution(string s)
        {
            var vowels = "aeiouAEIOU";
            var wordVowels = new Stack<char>();
            var strResult = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                    wordVowels.Push(s[i]);
            }

            for (int i = 0; i < s.Count(); i++)
            {
                if (vowels.Contains(s[i]))
                {
                    strResult.Append(wordVowels.Pop());
                }
                else
                {
                    strResult.Append(s[i]);
                }
            }
            return strResult.ToString();
        }

        public static string Solution1(string s)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] charArray = s.ToCharArray();
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                while (left < right && !Array.Exists(vowels, v => v == charArray[left]))
                {
                    left++;
                }
                while (left < right && !Array.Exists(vowels, v => v == charArray[right]))
                {
                    right--;
                }

                if (left < right)
                {
                    // Swap vowels at left and right pointers
                    char temp = charArray[left];
                    charArray[left] = charArray[right];
                    charArray[right] = temp;
                    left++;
                    right--;
                }
            }

            return new string(charArray);
        }
    }
}

