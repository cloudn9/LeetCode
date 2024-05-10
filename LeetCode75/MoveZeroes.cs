using System.Collections.Immutable;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LeetCode75
{
    public static class MoveZeroes

    {
        /// <summary>
        /// Given an integer array nums, move all 0's to the end of it while maintaining 
        /// the relative order of the non-zero elements.
        /// Note that you must do this in-place without making a copy of the array.
        /// </summary>
        public static int[] Solution(int[] nums)
        {
            int left = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    (nums[left], nums[i]) = (nums[i], nums[left]);
                    left++;
                }
            }
            return nums;
        }
    }
}

