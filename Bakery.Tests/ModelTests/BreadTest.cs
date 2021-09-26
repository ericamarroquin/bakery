using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int()
    {
      int quantity = 1;
      Bread newBread = new Bread();
      int result = newBread.Quantity;
      Assert.AreEqual(quantity, result);
    }
  }

  // [TestClass]
  // public class PastryTests
  // {
  //   [TestMethod]

  // }
}