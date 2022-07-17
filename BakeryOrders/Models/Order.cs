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
    public Order(string orderTitle, int breadOrder, int pastryOrder, string orderDescription, string orderDate)
    {
      Title = orderTitle;
      BreadOrder = breadOrder;
      PastryOrder = pastryOrder;
      Description = orderDescription;
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

    public void CalculatePrice()
    {
      int discountedPastries = PastryOrder / 3;
      int pastryCost = ((PastryOrder - discountedPastries) * 2) + discountedPastries * 1;

      int freeBreads = BreadOrder / 3;
      int breadCost = (BreadOrder - freeBreads) * 5;

      Price = pastryCost + breadCost;
    }
  }
}