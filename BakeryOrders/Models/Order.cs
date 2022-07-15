using System.Collections.Generic;
using System;

namespace BakeryOrders.Models
{
  public class Order
  {
    // auto implemented properties
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    // public DateTime Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    //constructor
    public Order(string orderTitle, string orderDescription, int orderPrice)
    {
      Title = orderTitle;
      Description = orderDescription;
      Price = orderPrice;
      _instances.Add(this);
      Id = _instances.Count;
    }

    //class methods
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}