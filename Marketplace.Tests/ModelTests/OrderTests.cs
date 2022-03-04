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
      Order newOrder = new Order("title");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_Returns_Title_String()
    {
      string title = "title";
      Order newOrder = new Order(title);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    public void GetDescription_Returns_Description_String()
    {
      string description = "description";
      Order newOrder = new Order(description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
  }

}