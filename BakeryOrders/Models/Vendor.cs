using System.Collections.Generic;

namespace BakeryOrders.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }
  }
}