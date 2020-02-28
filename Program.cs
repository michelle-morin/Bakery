using System;
using System.Collections.Generic;
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
      List<Bread> allBreadOrders = Bread.GetThatBread();
      List<Pastry> allPastryOrders = Pastry.GetThePastries();
      if (selection.ToLower() == "bread")
      {
        int breadOrderTotal = OrderBread();
        if (breadOrderTotal > 0)
        {
          Console.WriteLine("Your total will be $" + breadOrderTotal);
          AddToOrder();
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
          AddToOrder();
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
          AddToOrder();
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
        Bread.ApplyBreadDeals();
        int breadOrderTotal = Bread.GetTotalBreadPrice();
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
      if (pastryQuantity > 0)
      {
        Pastry pastryOrder = new Pastry(pastryQuantity);
        Pastry.ApplyPastryDeals();
        int pastryOrderTotal = Pastry.GetTotalPastryPrice();
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
        return 0;
      }
      catch (Exception exception)
      {
        Console.WriteLine("Unexpected error: " + exception.Message);
        return 0;
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
        Console.WriteLine("Have a nice day!");
      }
      else
      {
        AskToReturn();
      }
    }

    public static void AddToOrder()
    {
      Console.WriteLine("Would you like to add additional bread or pastry to your order?");
      Console.WriteLine("[BREAD] [PASTRY] [BOTH] [QUIT]");
      string addOrNot = Console.ReadLine();
      if (addOrNot.ToLower() == "bread")
      {
        TakeOrder("bread");
      }
      else if (addOrNot.ToLower() == "pastry")
      {
        TakeOrder("pastry");
      }
      else if (addOrNot.ToLower() == "both")
      {
        TakeOrder("both");
      }
      else if (addOrNot.ToLower() == "quit" || addOrNot.ToLower() == "no")
      {
        Console.WriteLine("Come again soon!");
      }
      else
      {
        AddToOrder();
      }
    }
  }
}