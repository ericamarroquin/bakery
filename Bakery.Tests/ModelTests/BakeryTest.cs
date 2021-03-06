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
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int()
    {
      int quantity = 1;
      Bread newBread = new Bread(1);
      int result = newBread.Quantity;
      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void Cost_ReturnTotalCostOfSingleBread_Int()
    {
      Bread newBread = new Bread(1);
      int resultCost = newBread.Cost();
      int cost = 5;
      Assert.AreEqual(cost, resultCost);
    }

    [TestMethod]
    public void Cost_ReturnTotalCostOfThreeBread_Int()
    {
      Bread newBread = new Bread(3);
      int resultCost = newBread.Cost();
      int cost = 10;
      Assert.AreEqual(cost, resultCost);
    }

    [TestMethod]
    public void Cost_ReturnTotalCostOfFourBread_Int()
    {
      Bread newBread = new Bread(4);
      int resultCost = newBread.Cost();
      int cost = 20;
      Assert.AreEqual(cost, resultCost);
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetQuantity_ReturnsPastryQuantity_Int()
    {
      Pastry newPastry = new Pastry(1);
      int quantity = 1;
      int result = newPastry.Quantity;
      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void Cost_ReturnTotalCostOfOnePastry_Int()
    {
      Pastry newPastry = new Pastry(1);
      int resultCost = newPastry.Cost();
      int cost = 2;
      Assert.AreEqual(cost, resultCost);
    }

    [TestMethod]
    public void Cost_ReturnTotalCostOfThreePastry_Int()
    {
      Pastry newPastry = new Pastry(3);
      int resultCost = newPastry.Cost();
      int cost = 5;
      Assert.AreEqual(cost, resultCost);
    }

    [TestMethod]
    public void Cost_ReturnTotalCostOfSixPastry_Int()
    {
      Pastry newPastry = new Pastry(6);
      int resultCost = newPastry.Cost();
      int cost = 10;
      Assert.AreEqual(cost, resultCost);
    }
  }
}