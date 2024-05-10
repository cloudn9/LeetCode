using System.Collections.Immutable;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LeetCode75
{
    public static class ProductExceptSelf

    {
        /// <summary>
        /// Given an integer array nums, return an array answer such that answer[i] 
        /// is equal to the product of all the elements of nums except nums[i].
        /// The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
        /// You must write an algorithm that runs in O(n) time and without using the division operation.
        /// </summary>
        public static int[] Solution(int[] nums)
        {
            // This solution goes in Time Limit Exceeded 
            var answer = new int[nums.Length];
            Func<int, int, int> multiply = (a, b) => a * b;
            var data = nums.Select((p, i) => new { Value = p, Index = i });

            var temp = new Dictionary<int, IEnumerable<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                // var temp = nums.Except([nums[i]]).Aggregate((a, b) => multiply(a, b));
                // var temp = data.Where(p => p.Index != i).Select(p => p.Value)
                // .Aggregate((a, b) => multiply(a, b));
                // answer[i] = temp;

                temp.Add(i, data.Where(p => p.Index != i).Select(p => p.Value).ToList());
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var item = temp.TryGetValue(i, out var p);
                var result = p.Aggregate((a, b) => multiply(a, b));
                answer[i] = result;
            }

            // return [.. answer];
            return answer.ToArray();
        }

        public static int[] Solution2(int[] nums)
        {
            int[] answer = new int[nums.Length];
            answer[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                answer[i] = answer[i - 1] * nums[i - 1];
            }
            int k = nums[nums.Length - 1];
            for (int i = nums.Length - 2; i > -1; i--)
            {
                answer[i] *= k;
                k *= nums[i];
            }
            return answer;
        }
    }
}

