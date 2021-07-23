using System.Collections.Generic;

namespace VendorTracker.Models
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

    public static void ClearAll()
    {
      _vendorsList.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _vendorsList;
    }
    public static Vendor Find(int searchId)
    {
      return _vendorsList[searchId - 1];
    }
  }
}