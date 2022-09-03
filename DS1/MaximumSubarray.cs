using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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

    private static int FirstTry(int[] nums)
    {
      if (nums.Length == 1)
      {
        return nums[0];
      }

      var sums = new int[nums.Length];
      (int maxSum, int index) result = (0, 0);
      for (int i = 0; i < nums.Length; i++)
      {
        if (nums[i] < 0)
        {
          continue;
        }
        sums[i] = nums[i];
        for (int j = i + 1; j < nums.Length; j++)
        {
          sums[i] += nums[j];
          if (result.maxSum < sums[i])
          {
            result.maxSum = sums[i];
            result.index = j - 2;
          }
        }
      }

      return result.maxSum <= 0 ? nums.Max() : result.maxSum;
    }
  }
}
