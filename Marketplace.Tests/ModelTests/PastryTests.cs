using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Marketplace.Models;
using System.Collections.Generic;


namespace Marketplace.Tests
{
  [TestClass]

  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearAll();
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry("Croissant");
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryPrice_ReturnPriceOfPastries_Int()
    {
      Pastry newPastry = new Pastry("Croissant");
      Pastry multiplePastries = new Pastry("Cronut");
      Pastry newPastry2 = new Pastry("Chocolate Croissant");
      int pastryPrice = Pastry.GetPastryPrice();
      Assert.AreEqual(pastryPrice, 5);
    }

    [TestMethod]
    public void GetPastryType_ReturnPastryType_String()
    {
      Pastry newPastry = new Pastry("Croissant");
      string pastryStyle = newPastry.PastryType;
      Assert.AreEqual(pastryStyle, "Croissant");
    }
    [TestMethod]
    public void GetAllPastries_ReturnsEmptyPastryList_PastryList()
    {
      List<Pastry> newList = new List<Pastry>{};
      List<Pastry> result = Pastry.GetAllPastries();
      foreach(Pastry thisPastry in result)
      {
        Console.WriteLine("Output from empty list GetAllPastries test: "+ thisPastry.PastryType);
      }
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAllPastries_ReturnsPastryTypes_PastryList()
    {
      string pastryStyle1 = "Croissant";
      string pastryStyle2 = "Cheese Danish";
      Pastry newPastry1 = new Pastry(pastryStyle1);
      Pastry newPastry2 = new Pastry(pastryStyle2);
      List<Pastry> newList = new List<Pastry>{
        newPastry1, newPastry2
      };
      List<Pastry> result = Pastry.GetAllPastries();
      foreach(Pastry thisPastry in result)
      {
        Console.WriteLine("Output from second GetAllPastries test: "+ thisPastry.PastryType);
      }
      CollectionAssert.AreEqual(newList, result);
    }
  }
}