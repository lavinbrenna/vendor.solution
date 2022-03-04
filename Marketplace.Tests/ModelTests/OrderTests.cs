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
  }

}