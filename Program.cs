using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      string bakerySelection = InitializeOrder();
      TakeOrder(bakerySelection);
    }

    public static string InitializeOrder()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! We sell bread for $5/loaf or $10/three loaves, and also sell pastries for $2/each or $5/three pastries.");
      Console.WriteLine("Would you like to purchase bread, pastry, or both?");
      Console.WriteLine("[BREAD] [PASTRY] [BOTH]");
      string bakerySelection = Console.ReadLine();
      return bakerySelection;
    }

    public static void TakeOrder(string selection)
    {
      if (selection.ToLower() == "bread")
      {
        int breadOrderTotal = OrderBread();
        Console.WriteLine("Your total will be $" + breadOrderTotal);

      }
      else if (selection.ToLower() == "pastry")
      {
        int pastryOrderTotal = OrderPastry();
        Console.WriteLine("Your total will be $" + pastryOrderTotal);
      }
      else if (selection.ToLower() == "both")
      {
        int breadTotal = OrderBread();
        int pastryTotal = OrderPastry();
        int comboOrderTotal = breadTotal + pastryTotal;
        Console.WriteLine("Your total will be $" + comboOrderTotal);
      }
      else
      {
        Main();
      }
    }

    public static int OrderBread()
    {
      Console.WriteLine("Please enter a quantity of bread loaves you would like to purchase:");
      string stringBreadQuantity = Console.ReadLine();
      int breadQuantity = int.Parse(stringBreadQuantity);
      Bread breadOrder = new Bread(breadQuantity);
      breadOrder.ApplyBreadDeals();
      int breadOrderTotal = breadOrder.Price;
      return breadOrderTotal;
    }
    
    public static int OrderPastry()
    {
      Console.WriteLine("Please enter a quantity of pastries you would like to purchase:");
      string stringPastryQuantity = Console.ReadLine();
      int pastryQuantity = int.Parse(stringPastryQuantity);
      Pastry pastryOrder = new Pastry(pastryQuantity);
      pastryOrder.ApplyPastryDeals();
      int pastryOrderTotal = pastryOrder.Price;
      return pastryOrderTotal;
    }
  }
}