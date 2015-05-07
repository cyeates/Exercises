using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises
{
  // Problem: You are given an integer m (1 ¬ m ¬ 1 000 000) and two non-empty, zero-indexed
  //arrays A and B of n integers, a0, a1, . . . , an−1 and b0, b1, . . . , bn−1 respectively (0 ¬ ai
  //, bi ¬ m).
  //The goal is to check whether there is a swap operation which can be performed on these
  //arrays in such a way that the sum of elements in array A equals the sum of elements in
  //array B after the swap. By swap operation we mean picking one element from array A and
  //one element from array B and exchanging them
  public class Codility2_1Tests
  {
    [Test]
    public void ShouldCheckifArrayElementCanBeSwapedSoSumsAreEqual()
    {
      var a = new int[] {3, 2, 3, 4, 5};
      var b = new int[] {4, 1, 2, 2, 3, 1};

      Assert.IsTrue(CanElementBeSwappedSoSumsAreEqual(a, b));
    }

    public bool CanElementBeSwappedSoSumsAreEqual(int[] a, int[] b)
    {
      a.Max(x => x);
      for (int i = 0; i <= a.Length; i++)
      {
        for(int j = 0; j <= b.Length; j++)
        {
          int temp = a[i];
          a[i] = b[j];
          b[j] = temp;

          int sumA = a.Sum();
          int sumB = b.Sum();

          if (sumA == sumB) return true;

        }
      }

      return false;
    }




  }
}
