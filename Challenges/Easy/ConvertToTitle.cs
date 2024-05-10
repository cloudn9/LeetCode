using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Xml.XPath;

namespace Challenges.Easy
{
    public static class ConvertToTitle
    {
        private static string[] Alphabet = new[] {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R",
            "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public static string Solution(int columnNumber)
        {
            var len = Alphabet.Length;
            var firstLetterIdx = columnNumber == len
                ? len : columnNumber / len;
            var secondLetterIdx = columnNumber % len;
            var currResult = string.Empty;
            if (secondLetterIdx > 0)
            {
                currResult = Alphabet.GetValue(secondLetterIdx - 1)?.ToString();
            }
            if (secondLetterIdx == 0 && firstLetterIdx != len)
            {
                secondLetterIdx = len;
                currResult = Alphabet.GetValue(secondLetterIdx - 1)?.ToString();
                firstLetterIdx--;
            }
            if (firstLetterIdx <= len && secondLetterIdx <= len)
            {
                return firstLetterIdx > 0 ?
                Alphabet.GetValue(firstLetterIdx - 1).ToString() + currResult :
                currResult;
            }
            return Solution(firstLetterIdx) + currResult;
        }
    }
}
