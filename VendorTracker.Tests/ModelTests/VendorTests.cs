using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Williams Inc.");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetCompany_ReturnCompany_String()
    {
      string vendorCompany = "Blahh Inc.";

      Vendor newVendor = new Vendor(vendorCompany);
      string result = newVendor.Company;

      Assert.AreEqual(vendorCompany, result);
    }
[TestMethod]
    public void Find_CorrectlyReturnsVendor_Vendor()
    {
    
      Vendor newVendor = new Vendor("a company");
      Vendor anotherVendor = new Vendor("nike");

      Vendor result = Vendor.Find(1);

      Assert.AreEqual(newVendor, result);
    }
[TestMethod]
    public void AddOrder_AddsOrderToVendor_OrderList()
    {
      
      Order anOrder = new Order("a company", "a description", 345);
      List<Order> theList = new List<Order> { anOrder };
      
      Vendor newVendor = new Vendor("worlds greatest VENDOR");
      newVendor.AddOrder(anOrder);
      List<Order> theResult = newVendor.Orders;

    
      CollectionAssert.AreEqual(theList, theResult);
    }
  }
}