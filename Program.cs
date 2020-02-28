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
      Console.BackgroundColor = ConsoleColor.Cyan;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Bread is $5/loaf or $10/three loaves; pastries are $2/each or $5/three pastries.");
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
        if (breadOrderTotal > 0)
        {
          Console.WriteLine("Your total will be $" + breadOrderTotal);
        }
        else
        {
          AskToReturn();
        }
      }
      else if (selection.ToLower() == "pastry")
      {
        int pastryOrderTotal = OrderPastry();
        if (pastryOrderTotal > 0)
        {
          Console.WriteLine("Your total will be $" + pastryOrderTotal);
        }
        else
        {
          AskToReturn();
        }
      }
      else if (selection.ToLower() == "both")
      {
        int breadTotal = OrderBread();
        int pastryTotal = OrderPastry();
        int comboOrderTotal = breadTotal + pastryTotal;
        if (breadTotal >= 0 && pastryTotal >= 0 && comboOrderTotal > 0)
        {
          Console.WriteLine("Your total will be $" + comboOrderTotal);
        }
        else if (breadTotal == 0 && pastryTotal == 0)
        {
          Console.WriteLine("You did not select any bread or pastries to purchase.");
          AskToReturn();
        }
        else
        {
          AskToReturn();
        }
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
      int breadQuantity = ValidateInputQuantity(stringBreadQuantity);
      if (breadQuantity > 0)
      {
        Bread breadOrder = new Bread(breadQuantity);
        breadOrder.ApplyBreadDeals();
        int breadOrderTotal = breadOrder.Price;
        return breadOrderTotal;
      }
      else
      {
        return 0;
      }
    }

    public static int OrderPastry()
    {
      Console.WriteLine("Please enter a quantity of pastries you would like to purchase:");
      string stringPastryQuantity = Console.ReadLine();
      int pastryQuantity = ValidateInputQuantity(stringPastryQuantity);
      if (pastryQuantity >= 0)
      {
        Pastry pastryOrder = new Pastry(pastryQuantity);
        pastryOrder.ApplyPastryDeals();
        int pastryOrderTotal = pastryOrder.Price;
        return pastryOrderTotal;
      }
      else
      {
        return 0;
      }
    }

    public static int ValidateInputQuantity(string quantity)
    {
      try
      {
        int intQuantity = int.Parse(quantity);
        return intQuantity;
      }
      catch (FormatException)
      {
        Console.WriteLine("The quantity entered is not valid");
        return -1;
      }
      catch (Exception exception)
      {
        Console.WriteLine("Unexpected error: " + exception.Message);
        return -1;
      }
    }

    public static void AskToReturn()
    {
      Console.WriteLine("Would you like to return to the main menu?");
      Console.WriteLine("[YES] or [NO]");
      string returnToMenu = Console.ReadLine();
      if (returnToMenu.ToLower() == "yes" || returnToMenu.ToLower() == "y")
      {
        Main();
      }
      else if (returnToMenu.ToLower() == "no" || returnToMenu.ToLower() == "n")
      {
        Console.WriteLine("Come again soon!");
      }
      else
      {
        AskToReturn();
      }
    }
  }
}