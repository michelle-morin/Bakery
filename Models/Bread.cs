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
    private static int _totalQuantity;
    
    public Bread(int quantity)
    {
      Quantity = quantity;
      Price = 5 * quantity;
      _ordersOfBread.Add(this);
      _totalQuantity += quantity;
    }

    public static List<Bread> GetThatBread()
    {
      return _ordersOfBread;
    }

    public static int GetTotalBreadPrice()
    {
      return _totalPrice;
    }

    public static int GetQuantity()
    {
      return _totalQuantity;
    }

    public void ApplyDealsToSingleOrder()
    {
      if (Quantity % 3 == 0)
      {
        Price = (Quantity / 3) * 10;
      }
      else if (Quantity >= 3)
      {
        int remainder = Quantity % 3;
        int quotient = Quantity / 3;
        Price = (remainder * 5) + (quotient * 10);
      }
    }

    public static void ApplyBreadDeals()
    {
      // int totalQuantity = 0;
      // foreach(Bread breadOrder in _ordersOfBread)
      // {
      //   totalQuantity += breadOrder.Quantity;
      // }
      if (_totalQuantity % 3 == 0)
      {
        _totalPrice = (_totalQuantity / 3) * 10;
      }
      else if (_totalQuantity >= 3)
      {
        int remainder = _totalQuantity % 3;
        int quotient = _totalQuantity / 3;
        _totalPrice = (remainder * 5) + (quotient * 10);
      }
      else
      {
        _totalPrice = 5 * _totalQuantity;
      }
    }
  }
}