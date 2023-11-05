namespace TopInterviewQuestions
{
    public static class RemoveDuplicatesSortedArray
  {
    /// <summary>
    // Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.
    // The relative order of the elements should be kept the same.
    /// </summary>
    /// Input: nums = [1,1,2]
    /// Output: 2, nums = [1,2, _]
    /// Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
    /// It does not matter what you leave beyond the returned k(hence they are underscores).
    public static int Solution(int[] nums)
    {
      var content = new HashSet<int>();
      var num = 0;
      for (int i = 0; i < nums.Length; i++)
      {
        if (content.Add(nums[i]))
        {
          nums[num++] = nums[i];
        }
      }

      return num;
    }
  }
}
