using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendorTracker.Models;
using System.Collections.Generic;

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
            Order newOrder = new Order("test", "test", "test", "test");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = "test";
            string description = "new test";
            string price = "$1";
            string date = "December 18";
            Order newOrder = new Order (name, description, price, date);
            string result = newOrder.Name;
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void GetAll_ReturnAllValues_List()
        {
            string name1 = "test1";
            string description1 = "new test1";
            string price1 = "$1";
            string date1 = "December 18";
            string name2 = "test2";
            string description2 = "new test2";
            string price2 = "$2";
            string date2 = "January 20";
            Order newOrder1 = new Order (name1, description1, price1, date1);
            Order newOrder2 = new Order (name2, description2, price2, date2);
            List<Order> newList = new List<Order> { newOrder1, newOrder2 };
            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }
    }

}