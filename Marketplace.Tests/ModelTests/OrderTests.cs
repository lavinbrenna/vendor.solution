using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Marketplace.Models;
using System.Collections.Generic;

namespace Marketplace.Tests
{
  [TestClass]
  public class OrderTests
  {
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
  }

}