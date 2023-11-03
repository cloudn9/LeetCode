using System;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

namespace TopInterviewQuestions
{
  public static class PlusOne
  {
    /// <summary>
    // You are given a large integer represented as an integer array digits,
    // where each digits[i] is the ith digit of the integer.
    // The digits are ordered from most significant to least significant in left-to-right order.
    // The large integer does not contain any leading 0's.
    /// Increment the large integer by one and return the resulting array of digits.
    /// </summary>
    public static int[] Solution(int[] digits)
    {
      for (int i = digits.Length - 1; i >= 0; i--)
      {
        if (digits[i] == 9)
        {
          digits[i] = 0;
        }
        else
        {
          digits[i]++;
          return digits;
        }
      }

      int[] newDigit = new int[] { 1 };
      return newDigit.Concat(digits).ToArray();
    }
  }
}
