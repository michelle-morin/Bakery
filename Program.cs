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
        Console.WriteLine("Please enter a quantity of bread loaves you would like to purchase:");
        string stringBreadQuantity = Console.ReadLine();
        int breadQuantity = int.Parse(stringBreadQuantity);
        // add bread order logic
      }
      else if (selection.ToLower() == "pastry")
      {
        Console.WriteLine("Please enter a quantity of pastries you would like to purchase:");
        string stringPastryQuantity = Console.ReadLine();
        int pastryQuantity = int.Parse(stringPastryQuantity);
        // add pastry order logic
      }
      else if (selection.ToLower() == "both")
      {
        Console.WriteLine("Please enter a quantity of bread loaves you would like to purchase:");
        string stringBreadQuantity = Console.ReadLine();
        int breadQuantity = int.Parse(stringBreadQuantity);
        Console.WriteLine("Please enter a quantity of pastries you would like to purchase:");
        string stringPastryQuantity = Console.ReadLine();
        int pastryQuantity = int.Parse(stringPastryQuantity);
        // add logic for combo order
      }
      else
      {
        Main();
      }
    }
  }
}