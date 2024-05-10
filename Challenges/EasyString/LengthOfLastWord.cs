using System;
using System.Linq;

namespace Challenges.EasyString
{
    public static class LengthOfLastWord
    {
        public static int Solution(string s)
        {
            return s.Trim().Split(" ").Last().Count();
        }
    }
}
