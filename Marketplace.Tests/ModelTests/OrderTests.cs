using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Marketplace.Models;
using System.Collections.Generic;

namespace Marketplace.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      DateTime date = new DateTime(2022, 03, 04);
      Order newOrder = new Order("title", "description", 25, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_Returns_Title_String()
    {
      string title = "title";
      string description = "description";
      int price = 25;
      DateTime date = new DateTime(2022, 03, 04);
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetDescription_Returns_Description_String()
    {
      string title = "title";
      string description = "description";
      int price = 25;
      DateTime date = new DateTime(2022, 03, 04);
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetPrice_Returns_Price_Int()
    {
      string title="title";
      string description = "description";
      int price = 25;
      DateTime date = new DateTime(2022, 03, 04);
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void GetDate_Returns_Date_DateTime()
    {
      string title="title";
      string description = "description";
      int price= 25;
      DateTime date = new DateTime(2022, 03, 04);
      Order newOrder = new Order(title, description, price, date);
      DateTime result = newOrder.Date;
      Assert.AreEqual(date, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order>{};
      List<Order> result = Order.GetAll();
      foreach(Order thisOrder in result)
      {
        Console.WriteLine("Output from empty list GetAll test:" + thisOrder.Title);
      }
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title01 = "title";
      string title02 = "title";
      string description01 ="description";
      string description02="description";
      int price01 = 25;
      int price02 = 25;
      DateTime date01 = new DateTime(2022, 03,04);
      DateTime date02 = new DateTime(2022, 03, 04);
      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
      List<Order> newList = new List<Order>{
        newOrder1, newOrder2
      };
      List<Order> result = Order.GetAll();
      foreach(Order thisOrder in result)
      {
        Console.WriteLine("Output from getAll Test: "+ thisOrder.Title);
      }
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "title";
      string description = "description";
      int price = 24;
      DateTime date = new DateTime(2022, 03, 04);
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title01 = "title";
      string title02 = "title";
      string description01 ="description";
      string description02="description";
      int price01 = 25;
      int price02 = 25;
      DateTime date01 = new DateTime(2022, 03,04);
      DateTime date02 = new DateTime(2022, 03, 04);
      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
    [TestMethod]
    public void AddPastry_AssociatesPastriesToOrder_PastryList()
    {
      string type = "croissant";
      Pastry newPastry1 = new Pastry(type);
      string title = "title";
      string description = "description";
      int price = Pastry.GetPastryPrice();
      DateTime date = new DateTime(2022, 03, 04);
      List<Pastry> pastryList = new List<Pastry>{newPastry1};
      Order newOrder = new Order(title, description, price, date);
      newOrder.AddPastry(newPastry1);
      List<Pastry> result = newOrder.Pastries;
      CollectionAssert.AreEqual(pastryList, result);
    }
    [TestMethod]
    public void AddBread_AssociatesBreadToOrder_BreadList()
    {
      string type ="Shokupan";
      Bread newBread = new Bread(type);
      string title = "title";
      string description = "description";
      int price = Bread.GetLoafPrice();
      DateTime date = new DateTime(2022, 03, 04);
      List<Bread> breadList = new List<Bread>{newBread};
      Order newOrder = new Order(title, description, price, date);
      newOrder.AddBread(newBread);
      List<Bread> result = newOrder.Breads;
      CollectionAssert.AreEqual(breadList, result);
    }
    [TestMethod]

    public void GetOrderTotal_GetsTotalForAllBreadAndPastries_Int()
    {
      string type1 = "croissant";
      Pastry newPastry1 = new Pastry(type1);
      string type2 = "cruffin";
      Pastry newPastry2 = new Pastry(type2);
      string type3 ="Shokupan";
      string type4 = "Sourdough";
      Bread newBread1 = new Bread(type3);
      Bread newBread2 = new Bread(type4);
      string title = "title";
      string description = "description";
      int price = 0;
      DateTime date = new DateTime(2022, 03,04);
      Order newOrder = new Order(title, description, price, date);
      newOrder.AddBread(newBread1);
      newOrder.AddBread(newBread2);
      newOrder.AddPastry(newPastry1);
      newOrder.AddPastry(newPastry2);
      newOrder.Price = newOrder.GetOrderTotal();
      int orderTotal = newOrder.Price;
      int result = Pastry.GetPastryPrice() + Bread.GetLoafPrice();
      Assert.AreEqual(result, orderTotal);
    }
  }

}