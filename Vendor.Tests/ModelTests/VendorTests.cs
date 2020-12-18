using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendorTracker.Models;
using System.Collections.Generic;

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
            Vendor newVendor = new Vendor("test", "new test");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = "test";
            string description = "new test";
            Vendor newVendor = new Vendor(name, description);
            string result = newVendor.Name;
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void GetId_ReturnVendorId_Int()
        {
            string name = "test";
            string description = "new test";
            Vendor newVendor = new Vendor(name, description);
            int result = newVendor.Id;
            Assert.AreEqual(1,result);
        }

        [TestMethod]
        public void GetDescription_ReturnDescription_String()
        {   
            string name = "test";
            string description = "new test";
            Vendor newVendor = new Vendor( name, description);
            string result = newVendor.Description;
            Assert.AreEqual(description, result);
            
        }

        [TestMethod]
        public void GetAll_ReturnAllVendorObjects_VendorList()
        {
        string name1 = "test1";
        string description1 = "new test1";
        string name2 = "test2";
        string description2 = "new test2";
        Vendor vendor1 = new Vendor(name1, description1);
        Vendor vendor2 = new Vendor(name2, description2);
        List<Vendor> newList = new List<Vendor> {vendor1, vendor2};
        List<Vendor> answer = Vendor.GetAll();
        CollectionAssert.AreEqual(newList, answer);
        }

        
    }
}