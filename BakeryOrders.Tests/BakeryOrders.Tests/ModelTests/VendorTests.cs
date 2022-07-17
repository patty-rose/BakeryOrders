using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using BakeryOrders.Models;

namespace BakeryOrders.Tests
{
  [TestClass]
  public class VendorTests  : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor", "test Description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name, "test Description");

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Test Description";
      Vendor newVendor = new Vendor("test Vendor", description);

      //Act
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name, "test Description");

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "Suzie's Cafe";
      string name02 = "New Season's";
      Vendor newVendor1 = new Vendor(name01, "test Description");
      Vendor newVendor2 = new Vendor(name02, "test Description");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "Suzie's Cafe";
      string name02 = "New Season's";
      Vendor newVendor1 = new Vendor(name01, "test Description");
      Vendor newVendor2 = new Vendor(name02, "test Description");

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      Order newOrder = new Order("Suzie's Cafe-07/15/2022", 15, 20, "test Description", "1/1/2022");
      Vendor newVendor = new Vendor("Suzie's Cafe", "test Description");
      newVendor.AddOrder(newOrder);
      List<Order> newList = new List<Order> { newOrder };

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}