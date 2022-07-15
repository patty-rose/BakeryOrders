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
      Order newOrder = new Order("test Order");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String() 
    {
      // Arrange
      string Title = "Suzie's Cafe-07/15/2022";
      Order newOrder = new Order(Title);

      // Act
      string result = newOrder.Title;

      // Assert (test)
      Assert.AreEqual(Title, result);
    }

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
      Order newOrder = new Order(title);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

  }
}