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
    
    public Pastry(int quantity)
    {
      Quantity = quantity;
      Price = 2 * quantity;
      _ordersOfPastries.Add(this);
    }

    public static List<Pastry> GetThePastries()
    {
      return _ordersOfPastries;
    }

    public static int GetTotalPastryPrice()
    {
      return _totalPrice;
    }

    public static void ApplyPastryDeals()
    {
      int totalQuantity = 0;
      foreach(Pastry pastryOrder in _ordersOfPastries)
      {
        totalQuantity += pastryOrder.Quantity;
      }
      if (totalQuantity >= 3)
      {
        int remainder = totalQuantity % 3;
        int quotient = totalQuantity / 3;
        _totalPrice = (remainder * 2) + (quotient * 5);
      }
      else
      {
        _totalPrice = 2 * totalQuantity;
      }
    }
  }
}