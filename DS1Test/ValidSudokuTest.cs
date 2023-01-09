using NUnit.Framework;

namespace DS1.Test
{
  [TestFixture]
  public class ValidSudokuTest
  {
    [Test]
    public void Test1()
    {
      var board = new string[][]
            {
          new string[] { "5", "3", ".", ".", "7", ".", ".", ".", "." },
          new string[] { "6", ".", ".", "1", "9", "5", ".", ".", "." },
          new string[] { ".", "9", "8", ".", ".", ".", ".", "6", "." },
          new string[] { "8", ".", ".", ".", "6", ".", ".", ".", "3" },
          new string[] { "4", ".", ".", "8", ".", "3", ".", ".", "1" },
          new string[] { "7", ".", ".", ".", "2", ".", ".", ".", "6" },
          new string[] { ".", "6", ".", ".", ".", ".", "2", "8", "." },
          new string[] { ".", ".", ".", "4", "1", "9", ".", ".", "5" },
          new string[] { ".", ".", ".", ".", "8", ".", ".", "7", "9" },
            };

      Assert.AreEqual(true, ValidSudoku.Solution(board), "Error");
    }

    [Test]
    public static void Test2()
    {
      var board = new string[][]
          {
          new string[] { "8","3",".",".","7",".",".",".","."},
          new string[] { "6",".",".","1","9","5",".",".","."},
          new string[] { ".","9","8",".",".",".",".","6","."},
          new string[] { "8",".",".",".","6",".",".",".","3"},
          new string[] { "4",".",".","8",".","3",".",".","1"},
          new string[] { "7",".",".",".","2",".",".",".","6"},
          new string[] { ".","6",".",".",".",".","2","8","."},
          new string[] { ".",".",".","4","1","9",".",".","5"},
          new string[] { ".",".",".",".","8",".",".","7","9"},
          };

      Assert.AreEqual(false, ValidSudoku.Solution(board), "Error");
    }
  }
}
