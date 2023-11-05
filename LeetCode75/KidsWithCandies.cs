using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode75
{
    public static class KidsWithCandies

    {
        /// <summary>
        // There are n kids with candies. You are given an integer array candies,
        // where each candies[i] represents the number of candies the ith kid has, and an integer extraCandies,
        // denoting the number of extra candies that you have.
        /// Return a boolean array result of length n, where result[i] is true if, 
        /// after giving the ith kid all the extraCandies, 
        /// they will have the greatest number of candies among all the kids, or false otherwise.
        /// Note that multiple kids can have the greatest number of candies.
        /// </summary>
        public static IList<bool> Solution(int[] candies, int extraCandies)
        {
            var result = new List<bool>();

            foreach (int k in candies)
            {
                if (candies.All(p => p <= k + extraCandies))
                {
                    result.Add(true);
                }
                else
                {
                    result.Add(false);
                }
            }

            return result;


            //return candies.Select(x => x + extraCandies >= candies.Max()).ToArray();
        }
    }
}

