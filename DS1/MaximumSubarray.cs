using System;

namespace DS1
{
  public static class MaximumSubarray
  {
    public static int Solution(int[] nums)
    {
      var maxSum = nums[0];
      var current = 0;
      for (int i = 0; i < nums.Length; i++)
      {
        if (current < 0)
        {
          current = 0;
        }
        current += nums[i];
        maxSum = Math.Max(maxSum, current);
      }
      return maxSum;
    }
  }
}
