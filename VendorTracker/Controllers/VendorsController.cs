using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorsList = Vendor.GetAll();
      return View(vendorsList);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorCompany)
    {
      Vendor newVendor = new Vendor(vendorCompany);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{Id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor showVendor = Vendor.Find(id);
      List<Order> vendOrders = showVendor.Orders;
      model.Add("vendor", showVendor);
      model.Add("order", vendOrders);
      return View(model);
    }

    [HttpPost("/vendors/{Id}/orders")]
    public ActionResult Create(string orderCompany, string description, int price, int Id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(Id);
      Order newOrder = new Order(orderCompany, description, price);
      foundVendor.AddOrder(newOrder);
      List<Order> vendOrders = foundVendor.Orders;
      model.Add("order", vendOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);

    }
  }
}