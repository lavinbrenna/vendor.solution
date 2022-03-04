using Microsoft.VisualStudio.TestTools.UnitTesting;
using Marketplace.Models;
using System.Collections.Generic;
using System;

namespace Marketplace.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}