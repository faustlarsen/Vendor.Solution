using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
    [TestClass]
    public class OrderTest : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("test");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = "test";
            Order newVendor = new Order(name);
            string result = newVendor.Name;
            Assert.AreEqual(name, result);
        }
    }

}