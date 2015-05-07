using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises
{
  [TestFixture]
  class IsAnagram
  {

    [TestCase("listen", "silent", true)]
    [TestCase("test1", "test2", false)]
    public void Should_Check_If_Two_Strings_Are_Anagrams(string s1, string s2, bool result)
    {
      Assert.AreEqual(s1.IsAnangram(s2), result);
    }
    
  }

  public static class StringExtensions
  {
    public static bool IsAnangram(this string s1, string s2)
    {
      string o1 = new string(s1.OrderBy(c => c).ToArray());
      string o2 = new string(s2.OrderBy(c => c).ToArray());
      return o1 == o2;
    }

    //public static bool IsAnagram2(this string s1, string s2)
    //{
    //  var counts = new Dictionary<char, int>();
     
    //  foreach (var c in s1)
    //  {
    //    if (counts.ContainsKey(c))
    //    {
    //      counts[c]++;
    //    }
    //    else
    //    {
    //      counts.Add(c, 1);
    //    }
    //  }
      
     

    //}
  }
}
