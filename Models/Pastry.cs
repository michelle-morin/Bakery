using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    public int Price { get; set; }
    
    public Pastry(int quantity)
    {
      Quantity = quantity;
      Price = 2 * quantity;
    }

    // 3 for 5

    public void ApplyPastryDeals()
    {
      if (Quantity >= 3)
      {
        int remainder = Quantity % 3;
        int quotient = Quantity / 3;
        Price = (remainder * 2) + (quotient * 5);
      }
    }
  }
}