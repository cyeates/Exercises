using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.GreatestProductInGrid
{
  [TestFixture]
  public class GreatestProductInGridTests
  {

    [Test]
    public void Should_Calculate_Greatest_Product_In_Grid()
    {
      var calculator = new GreatestProductInGridCalculator();
      int product = calculator.Calculate();
      Assert.AreEqual(70600674, product);
    }
  }
}
