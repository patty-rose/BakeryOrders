using System.Collections.Generic;
using System;

namespace BakeryOrders.Models
{
  public class Order
  {
    // auto implemented properties
    public string Title { get; set; }
    public int BreadOrder { get; set; }
    public int PastryOrder { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    //constructor
    public Order(string orderTitle, int breadOrder, int pastryOrder, string orderDescription, int orderPrice, string orderDate)
    {
      Title = orderTitle;
      BreadOrder = breadOrder;
      PastryOrder = pastryOrder;
      Description = orderDescription;
      Price = orderPrice;
      Date = orderDate;
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