using System;

namespace DS1
{
  public static class BestTimeToBuyAndSellStock
  {
    public static int Solution1(int[] prices)
    {
      if (prices.Length <= 1)
      {
        return 0;
      }

      var positiveTrend = prices[1] > prices[0];
      int minPrice;
      int maxPrice;
      if (positiveTrend)
      {
        minPrice = prices[0];
        maxPrice = prices[1];
      }
      else
      {
        minPrice = prices[1];
        maxPrice = 0;
      }

      var currentProfit = 0;
      for (int i = 1; i < prices.Length; i++)
      {
        positiveTrend = minPrice < prices[i];
        if (positiveTrend)
        {
          maxPrice = Math.Max(maxPrice, prices[i]);
          currentProfit = Math.Max(currentProfit, maxPrice - minPrice);
        }
        else
        {
          minPrice = i == prices.Length - 1 ? minPrice : Math.Min(minPrice, prices[i]);
          maxPrice = i == prices.Length - 1 ? maxPrice : 0;
          currentProfit = Math.Max(currentProfit, maxPrice - minPrice);
        }
      }

      return Math.Max(currentProfit, maxPrice - minPrice < 0 ? 0 : maxPrice - minPrice);
    }

    public static int Solution(int[] prices)
    {
      var min = prices[0];
      var profit = 0;
      foreach (var today in prices)
      {
        profit = Math.Max(profit, today - min);
        min = Math.Min(min, today);
      }
      return profit;
    }
  }
}
