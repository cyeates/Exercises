using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises
{
  [TestFixture]
  public class FootballWeights
  {

    [Test]
    public void ShouldGetBallWithLighterWeight()
    {
      double[] balls = new[] {1.25, 1.25, 1.15, 1.25, 1.25, 1.25, 1.25};

      int ballIndex = GetLightestBall(balls);
      Assert.AreEqual(2, ballIndex);
    }

    private int GetLightestBall(double[] balls)
    {
      int index = 0;
      for (int i = 1; i <= balls.Length; i++)
      {
        if (balls[i] < balls[index]) return i;
      }

      return index;
    }


    [Test]
    public void ShouldGetLightestBallRecursively()
    {
      double[] balls = new[] { 1.25, 1.25, 1.15, 1.25, 1.25, 1.25, 1.25 };

      int ballIndex = GetLighestBallRecursive(balls);
      Assert.AreEqual(2, ballIndex);
    }

    private  int GetLighestBallRecursive(double[] balls)
    {
      var ball = 0;
      var balls1 = balls.Skip(1).Take(balls.Length - 1).ToArray();
      var balls2 = balls1.Take(balls1.Length/2).ToArray();
      var balls3 = balls1.Skip(balls2.Count()).Take(balls1.Length/2).ToArray();

      if (balls2.Sum(b => b) == balls2.Sum(b => b)) return 0;

      if(balls2.Sum(b => b) < balls2.Sum(b => b))
        return GetLighestBallRecursive(balls2);

      else
      {
        return GetLighestBallRecursive(balls3);
      }
    }
  }
}
