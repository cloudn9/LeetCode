using System;
using System.Linq;

namespace Challenges.Easy
{
    public static class IsPalindrom
    {
        public static bool Solution(string x)
        {
            var lower = x.ToLower().Where(p => char.IsLetter(p)).Select(p => p.ToString()).ToArray();
            return string.Equals(string.Join(' ', lower),
                                string.Join(' ', lower.Reverse()), StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
