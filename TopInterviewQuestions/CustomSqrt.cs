namespace TopInterviewQuestions
{
  public static class CustomSqrt
  {
    /// <summary>
    /// Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.
    /// You must not use any built-in exponent function or operator.
    /// </summary>
    public static int Solution(int x)
    {
      long res = x;
      while (res * res > x)
        res = (res + x / res) / 2;
      return (int)res;
    }
  }
}
