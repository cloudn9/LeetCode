using System.Linq;

namespace DS1
{
    public static class TwoSum
    {
        public static int[] Solution(int[] nums, int target)
        {
            if (nums.Length < 2) return null;

            var data = nums.Select((p, i) => new { Value = p, Index = i }).ToList();

            for (int i = 0; i < data.Count() - 1; i++)
            {
                var first = data[i].Value;
                var number = data.Skip(i + 1).FirstOrDefault(p => p.Value + first == target);

                if (number != null && first + number.Value == target)
                {
                    return new int[] { i, number.Index };
                }
            }

            return null;
        }
    }
}
