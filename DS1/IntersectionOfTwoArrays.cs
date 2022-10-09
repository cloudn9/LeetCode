using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace DS1
{
    public static class IntersectionOfTwoArrays
    {
        public static int[] Solution(int[] nums1, int[] nums2)
        {
            // var p = nums1.Intersect(nums2).ToArray();

            var nums22 = nums2.ToList();
            var result = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                var found = nums22.Where(k => k == nums1[i]);
                if (found.Count() > 0)
                {
                    var num = found.First();
                    result.Add(num);
                    nums22.Remove(num);
                }
            }

            return result.ToArray();
        }
    }
}
