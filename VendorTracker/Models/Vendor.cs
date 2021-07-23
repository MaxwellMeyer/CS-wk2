using System.Collections.Generic;

namespace TrackVendor.Models
{
  public class Vendor
  {

    private static List<Vendor> _vendorsList = new List<Vendor> { };
    public string Company { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    public Vendor(string vendorCompany)
    {
      Company = vendorCompany;
      Id = _vendorsList.Count + 1;
      _vendorsList.Add(this);
      Orders = new List<Order> { };

    }
  }
}