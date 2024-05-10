using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Challenges.Easy
{
    public static class SearchInsert
    {
        public static int Solution(int[] nums, int target)
        {
            var result = Array.BinarySearch(nums, target);
            return result >= 0 ? result : ~result;
        }
    }
}
