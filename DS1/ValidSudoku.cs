using System.Collections.Generic;

namespace DS1
{
    public static class ValidSudoku
  {
    public static bool Solution(string[][] board)
    {
      for (int i = 0; i < board.Length; i++)
      {
        var rowValues = new HashSet<string>();
        var colValues = new HashSet<string>();
        var areaValues = new HashSet<string>();
        for (int j = 0; j < 9; j++)
        {
          if (board[i][j] != ".")
          {
            if (rowValues.Contains(board[i][j]))
            {
              return false;
            }
            rowValues.Add(board[i][j]);
          }

          if (board[j][i] != ".")
          {
            if (colValues.Contains(board[j][i]))
            {
              return false;
            }
            colValues.Add(board[j][i]);
          }

          var areaRow = i / 3;
          var areaCol = i % 3;
          var areaX = j / 3;
          var areaY = j % 3;
          var microI = 3 * areaRow + areaX;
          var microJ = 3 * areaCol + areaY;
          if (board[microI][microJ] != ".")
          {
            if (areaValues.Contains(board[microI][microJ]))
              return false;
            areaValues.Add(board[microI][microJ]);
          }
        }
      }

      return true;
    }

  }
}
