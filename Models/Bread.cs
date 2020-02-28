using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }
    public int Price { get; set; }
    
    public Bread(int quantity)
    {
      Quantity = quantity;
      Price = 5 * quantity;
    }

    public void ApplyBreadDeals()
    {
      if (Quantity % 3 == 0)
      {
        Price = (Quantity / 3) * 5;
      }
      else if (Quantity >= 3)
      {
        int remainder = Quantity % 3;
        int quotient = Quantity / 3;
        Price = (remainder * 5) + (quotient * 10);
      }
    }
  }
}