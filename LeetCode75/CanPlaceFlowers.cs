using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode75
{
    public static class CanPlaceFlowers

    {
        /// <summary>
        /// You have a long flowerbed in which some of the plots are planted, and some are not. 
        /// However, flowers cannot be planted in adjacent plots.
        /// Given an integer array flowerbed containing 0's and 1's, 
        /// where 0 means empty and 1 means not empty, and an integer n, 
        /// return true if n new flowers can be planted in the flowerbed without 
        /// violating the no-adjacent-flowers rule and false otherwise.
        /// </summary>
        public static bool Solution(int[] flowerbed, int n)
        {
            //Example 1:

            //Input: flowerbed = [1, 0, 0, 0, 1], n = 1
            //Output: true

            //Example 2:

            //Input: flowerbed = [1, 0, 0, 0, 1], n = 2
            //Output: false

            // 1, 0, 0, 0, 0, 0, 1  n = 2, true
            // 1, 0, 1, 0, 1, 0, 1, n = 1, false

            int i = 0;
            int count = 0;
            while (i < flowerbed.Length)
            {
                if (flowerbed[i] == 0 &&
                    (i == 0 || flowerbed[i-1] == 0) &&
                    (i == flowerbed.Length-1 || flowerbed[i+1] == 0))
                {
                    flowerbed[i] = 1;
                    count++;
                }
                i++;
            }
           return count >= n;
        }
    }
}

