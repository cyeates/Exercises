using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises
{
  [TestFixture]
  public class DoesStringHaveUniqueCharacters
  {

    [TestCase("abcdefghijklmnopqrstuvwxyz", true)]
    [TestCase("does not have unique characters", false)]
    public void ShouldCheckIfStringHasUniqueCharacters(string input, bool expected)
    {
      Assert.AreEqual(expected, HasUniqueCharacters(input));
    }

    private bool HasUniqueCharacters(string input)
    {
      var chars = new Dictionary<char, bool>();
      foreach (char c in input)
      {
        if (chars.ContainsKey(c))
          return false;

        chars.Add(c, true);

      }

      return true;
    }
  }
}
