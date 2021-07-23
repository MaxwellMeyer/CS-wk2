using System.Collections.Generic;

namespace VendorTracker.Models
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

    public static void ClearAll()
    {
      _ordersList.Clear();
    }
    public static List<Order> GetAll()
    {
      return _ordersList;
    }
    public static Order Find(int Id)
    {
      return _ordersList[Id - 1];
    }
  }
}