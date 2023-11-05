namespace DS1
{
    public static class MatrixReshape
  {
    public static int[][] Solution(int[][] mat, int r, int c)
    {
      if (mat.Length * mat[0].Length != r * c)
      { return mat; }

      var result = new int[r][];
      for (int i = 0; i < r; i++)
      {
        result[i] = new int[c];
      }

      var mi = 0;
      var mj = 0;
      for (int i = 0; i < r; i++)
      {
        result[i] = new int[c];
        for (int j = 0; j < c; j++)
        {
          result[i][j] = mat[mi][mj];
          mj++;
          if (mj == mat[0].Length)
          {
            mj = 0;
            if (mi != mat.Length)
              mi++;
          }
        }
      }

      return result;
    }
  }
}
