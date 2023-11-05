using System.Linq;

namespace DS1
{
    public static class FirstUniqueChar
  {
    public static int Solution(string s)
    {
      if (s.Length > 100000) { return -1; }
      var p = s.GroupBy(k => k).Select(x => new
      {
        x.Key,
        cc = x.Count()
      }).Where(m => m.cc == 1).ToList();

     var letter = p.Count() > 0 ? p[0].Key : default;
      return letter != default ?
        s.IndexOf(letter) : -1;
    }
  }
}
