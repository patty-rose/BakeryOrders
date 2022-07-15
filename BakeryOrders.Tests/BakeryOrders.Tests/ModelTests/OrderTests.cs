using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using BakeryOrders.Models;

namespace BakeryOrders.Tests
{
  [TestClass]
  public class OrderTests  //: IDisposable
  {
    // public void Dispose()
    // {
    //   Order.ClearAll();
    // }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test Order");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}