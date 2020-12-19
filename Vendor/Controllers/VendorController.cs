using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendor")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }

        [HttpGet("/vendor/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendor")]
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
            List<Order> vendorOrders = selectedVendor.Order;
            model.Add("vendor", selectedVendor);
            model.Add("order", vendorOrders);
            return View(model);
        }

        [HttpPost("/vendor/{vendorId}/order")]
        public ActionResult Create(int vendorId, string orderName, string orderDescription, string orderPrice, string orderDate)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor foundVendor = Vendor.Find(vendorId);
            Order newOrder = new Order(orderName, orderDescription, orderPrice, orderDate);
            foundVendor.AddOrder(newOrder);
            List<Order> vendorOrders = foundVendor.Order;
            model.Add("order", vendorOrders);
            model.Add("vendor", foundVendor);
            return View("Show", model);
        }

        [HttpPost("/vendors/delete")]
        public ActionResult DeleteAll()
        {
            Vendor.ClearAll();
            return View();
        }

    }
}