using System.Collections.Generic;

namespace TrackVendor.Models
{
  public class Order
  {
    public string Company { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Id { get; }
    private static List<Order> _ordersList = new List<Order> { };

    public Order(string orderCompany, string description, int price)
    {
      Company = orderCompany;
      Description = description;
      Price = price;
      Id = _ordersList.Count + 1;
      _ordersList.Add(this);
    }
  }
}