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
      if (Quantity >= 10)
      {
        int firstRemainder = Quantity % 10;
        int firstQuotient = Quantity / 10;
        if (firstRemainder >= 3)
        {
          int secondRemainder = firstRemainder % 3;
          int secondQuotient = firstRemainder / 3;
          Price = (firstQuotient * 30) + (secondRemainder * 5) + (secondQuotient * 10);
        }
        else
        {
          Price = (firstQuotient * 30) + (firstRemainder * 5);
        } 
      }
      else if (Quantity % 3 == 0)
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
      if (_totalQuantity >= 10)
      {
        int firstRemainder = _totalQuantity % 10;
        int firstQuotient = _totalQuantity / 10;
        if (firstRemainder >= 3)
        {
          int secondRemainder = firstRemainder % 3;
          int secondQuotient = firstRemainder / 3;
          _totalPrice = (firstQuotient * 30) + (secondRemainder * 5) + (secondQuotient * 10);
        }
        else
        {
          _totalPrice = (firstQuotient * 30) + (firstRemainder * 5);
        } 
      }
      else if (_totalQuantity % 3 == 0)
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