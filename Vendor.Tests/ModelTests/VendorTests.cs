using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
    [TestClass]
    public class VendorTest : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }

        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("test");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = "test";
            Vendor newVendor = new Vendor(name);
            string result = newVendor.Name;
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void GetId_ReturnVendorId_Int()
        {
            string name = "test";
            Vendor newVendor = new Vendor(name);
            int result = newVendor.Id;
            Assert.AreEqual(1,result);
        }
    }
}