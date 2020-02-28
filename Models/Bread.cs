using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }
    public int Price { get; set; }
    private static List<Bread> _ordersOfBread = new List<Bread>() {};
    private static int _totalPrice;
    
    public Bread(int quantity)
    {
      Quantity = quantity;
      Price = 5 * quantity;
      _ordersOfBread.Add(this);
    }

    public static List<Bread> GetThatBread()
    {
      return _ordersOfBread;
    }

    public static int GetTotalBreadPrice()
    {
      return _totalPrice;
    }

    public static void ApplyBreadDeals()
    {
      int totalQuantity = 0;
      foreach(Bread breadOrder in _ordersOfBread)
      {
        totalQuantity += breadOrder.Quantity;
      }
      if (totalQuantity % 3 == 0)
      {
        _totalPrice = (totalQuantity / 3) * 10;
      }
      else if (totalQuantity >= 3)
      {
        int remainder = totalQuantity % 3;
        int quotient = totalQuantity / 3;
        _totalPrice = (remainder * 5) + (quotient * 10);
      }
      else
      {
        _totalPrice = 5 * totalQuantity;
      }
    }
  }
}