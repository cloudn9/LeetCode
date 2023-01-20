using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace TopInterviewQuestions
{
  public static class RomanToInteger
  {
    /// <summary>
    /// Symbol       Value
    //    I             1
    //    V             5
    //    X             10
    //    L             50
    //    C             100
    //    D             500
    //    M             1000
    /// </summary>
    /// <param name="roman">MCMXCIV</param>
    /// <returns>1994</returns>
    /// Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
    public static int Solution(string roman)
    {
      var romanDic = new Dictionary<string, int>()
      {
        { "I",1 },
        { "V",5 },
        { "X",10 },
        { "L",50 },
        { "C",100 },
        { "D",500 },
        { "M",1000 },
      };

      var rules = new Dictionary<string, int>()
      {
        { "IV",4 },
        { "IX",9 },
        { "XL",40 },
        { "XC",90 },
        { "CD",400 },
        { "CM",900 },
      };

      var specialChars = rules.Keys.Where(x => roman.Contains(x)).ToList();
      specialChars.ForEach((r) =>
      {
        roman = roman.Replace(r, string.Empty);
      });

      var result = specialChars.Sum(p => rules[p]);
      foreach (var c in roman)
      {
        if (romanDic.ContainsKey(c.ToString()))
        {
          result += romanDic[c.ToString()];
        }
      }
      return result;
    }

  }
}
