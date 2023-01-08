using System.Linq;

namespace DS1
{
    public static class ContainsDuplicate
    {
        public static bool Solution(int[] nums)
        {
            return nums.Distinct().Count() != nums.Length;
        }
    }
}
