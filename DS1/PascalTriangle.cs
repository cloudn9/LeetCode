using System.Collections.Generic;

namespace DS1
{
    public static class PascalTriangle
  {
    public static IList<IList<int>> Solution(int numRows)
    {
      return GenerateTriangle(numRows);
    }

    private static IList<IList<int>> GenerateTriangle(int numRows)
    {
      var result = new List<IList<int>> { new List<int> { 1 } };
      for (int i = 2; i <= numRows; i++)
      {
        var list = new List<int> { 1 };
        for (int j = 1; j < i - 1; j++)
        {
          list.Add(result[^1][j - 1] + result[^1][j]);
        }
        list.Add(1);
        result.Add(list);
      }
      return result;
    }
  }
}
