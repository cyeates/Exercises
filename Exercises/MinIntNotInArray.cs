using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises
{
//  Write a function:

//int solution(int A[], int N);

//that, given a non-empty zero-indexed array A of N integers, returns the minimal positive integer that does not occur in A.

//For example, given:

//  A[0] = 1
//  A[1] = 3
//  A[2] = 6
//  A[3] = 4
//  A[4] = 1
//  A[5] = 2
//the function should return 5.

//Assume that:

//N is an integer within the range [1..100,000];
//each element of array A is an integer within the range [−2,147,483,648..2,147,483,647].
//Complexity:

//expected worst-case time complexity is O(N);
//expected worst-case space complexity is O(N), beyond input storage (not counting the storage required for input arguments).
//Elements of input arrays can be modified.
  public class MinIntNotInArray
  {

    [Test]
    public void TestSolution()
    {
      var A = new int[] {1, 3, 6, 4, 1, 2};
      int N = 6;

      Assert.AreEqual(5, Solution(A, N));
    }

    private int Solution(int[] A, int N)
    {
      int[] occurences = new int[N+1];
      for (int i = 1; i <= N; i++)
      {
        occurences[A[i-1]]++;
      }

      for (int i = 1; i <= N; i++)
      {
        if (occurences[i] == 0) return i;
      }

      return -1;
    }
  }
}
