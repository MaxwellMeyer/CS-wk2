using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
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
      Order newOrder = new Order("Williams Inc.", "A bunch of stuff", 1000);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    public void GetOrder_ReturnOrder_String()
    {
      string testOrderCompany = "The Company";

      Order newOrder = new Order("The Company", "Stuff", 444);
      string result = newOrder.Company;
      Assert.AreEqual(testOrderCompany, "stuff");
    }
  }
}