using System.Collections.Generic;

namespace BakeryOrders.Models
{
  public class Order
  {
    // auto implemented properties
    public string Title { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    //constructor
    public Order(string OrderTitle)
    {
      Title = OrderTitle;
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

    // public static Order Find(int searchId)
    // {
    //   return _instances[searchId-1];
    // }
  }
}