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
    }
}