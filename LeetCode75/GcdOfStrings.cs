using Microsoft.VisualBasic;

using System.Text;

namespace LeetCode75
{
    public static class GcdOfStrings

    {
        /// <summary>
        // For two strings s and t, we say "t divides s"
        // if and only if s = t + ... + t
        // (i.e., t is concatenated with itself one or more times).
        /// Given two strings str1 and str2, 
        /// return the largest string x such that x divides both str1 and str2.
        /// </summary>      

        public static string Solution(string str1, string str2)
        {
            if (str1.Equals(str2))
                return str1;

            if (str1.StartsWith(str2))
                return Solution(str1.Substring(str2.Length), str2);

            if (str2.StartsWith(str1))
                return Solution(str1, str2.Substring(str1.Length));

            return "";
        }

        public static string Solution1(string str1, string str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;

            // Calculate the GCD of the lengths of str1 and str2
            int divisorLength = Gcd(len1, len2);

            // Extract the substring from str1 using the calculated GCD as length
            string divisor = str1.Substring(0, divisorLength);

            // Check if the divisor can divide both str1 and str2
            if (str1.Equals(RepeatString(divisor, len1 / divisorLength)) &&
                str2.Equals(RepeatString(divisor, len2 / divisorLength)))
            {
                return divisor;
            }
            else
            {
                return "";
            }
        }

        // Helper function to calculate GCD of two numbers
        private static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Helper function to repeat a string n times
        private static string RepeatString(string str, int times)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                sb.Append(str);
            }
            return sb.ToString();
        }
    }
}
