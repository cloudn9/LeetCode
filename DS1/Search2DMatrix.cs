using System;
using System.Collections.Generic;
using System.Linq;

namespace DS1
{
  public static class Search2DMatrix
  {
    public static bool Solution(int[][] matrix, int target)
    {
      for (int i = 0; i < matrix.Length; i++)
      {
        if (Array.BinarySearch(matrix[i], target) >= 0)
        {
          return true;
        }
      }
      return false;
    }

  }
}
