using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Challenges.Easy
{
    public static class AddBinary
    {
        static readonly Func<IEnumerable<int>, string> AddStringsAsBinary =
            (values) => Convert.ToString(values.Sum(), 2);
        public static string Solution(string a, string b)
        {
            // return AddStringsAsBinary(new List<string> { a, b }.Select(p => Convert.ToInt32(p, 2)));
            var sum = new List<int>();
            for (int i = a.Length - 1, j = b.Length - 1, carry = 0; i >= 0 || j >= 0 || carry > 0;)
            {
                var firstDigit = i >= 0 ? a[i--] - '0' : 0;
                var secondDigit = j >= 0 ? b[j--] - '0' : 0;
                var sumDigit = firstDigit + secondDigit + carry;
                carry = sumDigit / 2;
                sum.Add(sumDigit % 2);
            }
            sum.Reverse();
            return String.Concat(sum);
        }
    }
}
