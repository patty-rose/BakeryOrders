using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BakeryOrders.Models;

namespace BakeryOrders.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("Vendor", selectedVendor);
      model.Add("Orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int orderPrice)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();

      Vendor foundVendor = Vendor.Find(vendorId);

      Order newOrder = new Order(orderTitle, orderDescription, orderPrice);

      foundVendor.AddOrder(newOrder);

      List<Order> vendorOrders = foundVendor.Orders;

      model.Add("Orders", vendorOrders);

      model.Add("Vendor", foundVendor);

      return View("Show", model);
    }
  }
}