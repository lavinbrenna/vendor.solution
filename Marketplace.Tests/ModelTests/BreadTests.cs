using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Marketplace.Models;

namespace Marketplace.Tests
{
  [TestClass]

  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("Shokupan");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }


    [TestMethod]
    public void GetLoafPrice_ReturnPriceOfLoaves_Int()
    {
      Bread newBread = new Bread("Shokupan");
      Bread multipleLoaves = new Bread("Brioche");
      Bread newBread3 = new Bread("Baguette");
      int breadPrice = Bread.GetLoafPrice();
      Assert.AreEqual(breadPrice, 10);
    }
    [TestMethod]
    public void GetBreadType_ReturnBreadType_String()
    {
      Bread newBread = new Bread("Shokupan");
      string breadStyle = newBread.BreadType;
      Assert.AreEqual(breadStyle, "Shokupan");
    }
    [TestMethod]
    public void GetAllBread_ReturnsEmptyBreadList_BreadList()
    {
      List<Bread> newList = new List<Bread> {};
      List<Bread> result = Bread.GetAllBread();
      foreach(Bread thisBread in result)
      {
        Console.WriteLine("Output from empty list GetAllBread test: " + thisBread.BreadType);
      }
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAllBread_ReturnsBreadLoaves_BreadList()
    {
      string breadStyle1 = "Brioche";

      string breadStyle2 = "Challah";

      Bread newBread1 = new Bread(breadStyle1);
      Bread newBread2 = new Bread(breadStyle2);
      List<Bread> newList = new List<Bread>{
        newBread1, newBread2
      };
      List<Bread> result = Bread.GetAllBread();
      foreach( Bread thisBread in result)
      {
        Console.WriteLine("Output from second GetAllBread test: " + thisBread.BreadType);
      }
      CollectionAssert.AreEqual(newList, result);
    }
  }
}