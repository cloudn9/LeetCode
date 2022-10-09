using Microsoft.VisualBasic;

using System;
using System.Linq;

namespace Challenges.Easy
{
    public static class Palindrom
    {
        public static bool Solution(int x)
        {
            return string.Equals(x.ToString(), new String(x.ToString().Reverse().ToArray()), StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
