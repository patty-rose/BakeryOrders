using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using BakeryOrders.Models;

namespace BakeryOrders.Tests
{
  [TestClass]
  public class OrderTests  : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test Order", 15, 20, "test Description", "1/1/2022");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String() 
    {
      // Arrange
      string title = "Suzie's Cafe-07/15/2022";
      Order newOrder = new Order(title, 15, 20, "test Description", "1/1/2022");

      // Act
      string result = newOrder.Title;

      // Assert (test)
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String() 
    {
      // Arrange
      string description = "test description";
      Order newOrder = new Order("test order", 15, 20, description, "1/1/2022");

      // Act
      string result = newOrder.Description;

      // Assert (test)
      Assert.AreEqual(description, result);
    }

    // [TestMethod]
    // public void GetPrice_ReturnsPrice_Int() 
    // {
    //   // Arrange
    //  int price = 10
    //   Order newOrder = new Order("test order", 15, 20, "test description", 10, "1/1/2022");

    //   // Act
    //   int result = newOrder.Price;

    //   // Assert (test)
    //   Assert.AreEqual(price, result);
    // }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string title = "Suzie's Cafe-07/15/2022";
      Order newOrder = new Order(title, 15, 20, "test Description", "1/1/2022");

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string title01 = "Suzie's Cafe-07/15/2022";
      string title02 = "New seasons-07/15/2022";
      Order newOrder1 = new Order(title01, 15, 20, "test Description", "1/1/2022");
      Order newOrder2 = new Order (title02, 15, 20, "test Description", "1/1/2022");

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }

    [TestMethod]
    public void GetsBreadOrder_ReturnsBreadOrder_Int() 
    {
      // Arrange
      int breadOrder = 15;
      Order newOrder = new Order("Suzie's Cafe-07/15/2022", breadOrder, 20, "test Description", "1/1/2022");

      // Act
      int result = newOrder.BreadOrder;

      // Assert (test)
      Assert.AreEqual(breadOrder, result);
    }

    [TestMethod]
    public void GetsPastryOrder_ReturnsPastryOrder_Int() 
    {
      // Arrange
      int pastryOrder = 20;
      Order newOrder = new Order("Suzie's Cafe-07/15/2022", 15, pastryOrder, "test Description", "1/1/2022");

      // Act
      int result = newOrder.PastryOrder;

      // Assert (test)
      Assert.AreEqual(pastryOrder, result);
    }

    [TestMethod]
    public void CalculateOrderPrice_ReturnsCalculatedPrice_Int() 
    {
      // Arrange
      Order newOrder = new Order("Suzie's Cafe-07/15/2022", 15, 20, "test Description", "1/1/2022");

      // Act
      newOrder.CalculatePrice();
      int result = newOrder.Price;

      // Assert (test)
      Assert.AreEqual(84, result);
    }
  }
}