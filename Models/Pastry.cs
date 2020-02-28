using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    public int Price { get; set; }
    private static List<Pastry> _ordersOfPastries = new List<Pastry>() {};
    private static int _totalPrice;
    private static int _totalQuantity;
    
    public Pastry(int quantity)
    {
      Quantity = quantity;
      Price = 2 * quantity;
      _ordersOfPastries.Add(this);
      _totalQuantity += quantity;
    }

    public static List<Pastry> GetThePastries()
    {
      return _ordersOfPastries;
    }

    public static int GetTotalPastryPrice()
    {
      return _totalPrice;
    }

    public static int GetQuantity()
    {
      return _totalQuantity;
    }

    public void ApplyDealsToSingleOrder()
    {
      if (Quantity >= 3)
      {
        int remainder = Quantity % 3;
        int quotient = Quantity / 3;
        Price = (remainder * 2) + (quotient * 5);
      }
      else
      {
        Price = 2 * Quantity;
      }
    }

    public static void ApplyPastryDeals()
    {
      // int totalQuantity = 0;
      // foreach(Pastry pastryOrder in _ordersOfPastries)
      // {
      //   totalQuantity += pastryOrder.Quantity;
      // }
      if (_totalQuantity >= 3)
      {
        int remainder = _totalQuantity % 3;
        int quotient = _totalQuantity / 3;
        _totalPrice = (remainder * 2) + (quotient * 5);
      }
      else
      {
        _totalPrice = 2 * _totalQuantity;
      }
    }
  }
}