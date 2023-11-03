namespace TopInterviewQuestions
{
  public static class SingleNonDuplicate
  {
    public static int Solution(int[] nums)
    {
      var p = nums.FirstOrDefault(p => nums.Count(i => i == p) == 1);
      return p;
    }
  }
}
