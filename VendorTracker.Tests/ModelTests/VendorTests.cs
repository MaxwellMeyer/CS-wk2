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
  }
}