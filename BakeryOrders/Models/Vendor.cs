using System.Collections.Generic;

namespace BakeryOrders.Models
{
  public class Vendor
  {
    // auto implemented properties
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> {};
    public List<Order> Orders { get; set; }

    //constructor
    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }

    //class methods
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}