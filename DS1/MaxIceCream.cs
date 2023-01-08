using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace DS1
{
  public static class MaxIceCream
  {
    public static int Solution(int[] costs, int coins)
    {
      var total = 0;
      var p = costs.OrderBy(k => k).Where(x =>
      {
        if (x + total <= coins)
        {
          total += x;
          return true;
        }
        return false;
      });

      return p.Count();
    }

    public static int Solution1(int[] costs, int coins)
    {
      if (costs.Length < 1) return 0;

      Array.Sort(costs);
      var total = 0;
      var idx = new List<int>();
      for (int i = 0; i < costs.Length; i++)
      {
        if (total + costs[i] <= coins)
        {
          total += costs[i];
          idx.Add(i);
        }
      }

      return idx.Count;
    }
  }
}
