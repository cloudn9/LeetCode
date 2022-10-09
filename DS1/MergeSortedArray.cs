using System;

namespace DS1
{
    public static class MergeSortedArray
    {
        public static int[] Solution(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < nums2.Length; i++)
            {
                nums1[m + i] = nums2[i];
            }

            // not accepted even if the tests pass here
            // nums1 = nums1.OrderBy(m => m).ToArray();

            Array.Sort(nums1);
            return nums1;
        }
    }
}
