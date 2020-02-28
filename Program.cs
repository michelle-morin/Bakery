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
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Magenta;
      string pierre = @"
       _____ _____ ______ _____  _____  ______ #  _____ 
      |  __ \_   _|  ____|  __ \|  __ \|  ____|# / ____|
      | |__) || | | |__  | |__) | |__) | |__    | (___  
      |  ___/ | | |  __| |  _  /|  _  /|  __|    \___ \ 
      | |    _| |_| |____| | \ \| | \ \| |____   ____) |
      |_|   |_____|______|_|  \_\_|  \_\______| |_____/ ";
      string bakery = @"
       ____          _  ________ _______     __
      |  _ \   /\   | |/ /  ____|  __ \ \   / /
      | |_) | /  \  | ' /| |__  | |__) \ \_/ / 
      |  _ < / /\ \ |  < |  __| |  _  / \   /  
      | |_) / ____ \| . \| |____| | \ \  | |   
      |____/_/    \_\_|\_\______|_|  \_\ |_|   
                                                ";
      Console.WriteLine("".PadLeft(2) + pierre);
      Console.WriteLine("".PadLeft(2) + bakery);
      Console.WriteLine("".PadLeft(8) + "Bread is $5/loaf, $10/three loaves, or $30/ten loaves");
      Console.WriteLine("".PadLeft(8) + "Pastries are $2/each, $5/three, or $30/twenty.");
      Console.WriteLine("".PadLeft(8) + "Would you like to purchase bread, pastry, or both?");
      Console.WriteLine("".PadLeft(20) + "[BREAD] [PASTRY] [BOTH]");
      string bakerySelection = Console.ReadLine();
      return bakerySelection;
    }

    public static void TakeOrder(string selection)
    {
      if (selection.ToLower() == "bread")
      {
        int breadOrderTotal = OrderBread();
        int totalOrderPrice = GetTotalPrice();
        if (breadOrderTotal > 0)
        {
          Console.Clear();
          Console.WriteLine("".PadLeft(4) + "Your current total at Pierre's Bakery is $" + totalOrderPrice);
          AddToOrder();
        }
        else
        {
          AddToOrder();
        }
      }
      else if (selection.ToLower() == "pastry")
      {
        int pastryOrderTotal = OrderPastry();
        int totalOrderPrice = GetTotalPrice();
        if (pastryOrderTotal > 0)
        {
          Console.Clear();
          Console.WriteLine("".PadLeft(4) + "Your current total at Pierre's Bakery is $" + totalOrderPrice);
          AddToOrder();
        }
        else
        {
          AddToOrder();
        }
      }
      else if (selection.ToLower() == "both")
      {
        int breadTotal = OrderBread();
        int pastryTotal = OrderPastry();
        int comboOrderTotal = breadTotal + pastryTotal;
        int totalOrderPrice = GetTotalPrice();
        if (breadTotal >= 0 && pastryTotal >= 0 && comboOrderTotal > 0)
        {
          Console.Clear();
          Console.WriteLine("".PadLeft(4) + "Your current total at Pierre's Bakery is $" + totalOrderPrice);
          AddToOrder();
        }
        else if (breadTotal == 0 && pastryTotal == 0)
        {
          Console.Clear();
          Console.WriteLine("".PadLeft(4) + "You did not select any bread or pastries to purchase.");
          Console.WriteLine("".PadLeft(4) + "Your current total at Pierre's Bakery is $" + totalOrderPrice);
          AddToOrder();
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
      Console.WriteLine("".PadLeft(4) + "Please enter a quantity of bread loaves you would like to purchase:");
      string stringBreadQuantity = Console.ReadLine();
      int breadQuantity = ValidateInputQuantity(stringBreadQuantity);
      if (breadQuantity > 0)
      {
        Bread breadOrder = new Bread(breadQuantity);
        breadOrder.ApplyDealsToSingleOrder();
        return breadOrder.Price;
      }
      else
      {
        return 0;
      }
    }

    public static int OrderPastry()
    {
      Console.WriteLine("".PadLeft(4) + "Please enter a quantity of pastries you would like to purchase:");
      string stringPastryQuantity = Console.ReadLine();
      int pastryQuantity = ValidateInputQuantity(stringPastryQuantity);
      if (pastryQuantity > 0)
      {
        Pastry pastryOrder = new Pastry(pastryQuantity);
        pastryOrder.ApplyDealsToSingleOrder();
        return pastryOrder.Price;
      }
      else
      {
        return 0;
      }
    }

    public static int GetTotalPrice()
    {
      List<Bread> allBreadOrders = Bread.GetThatBread();
      List<Pastry> allPastryOrders = Pastry.GetThePastries();
      Pastry.ApplyPastryDeals();
      Bread.ApplyBreadDeals();
      int totalOrderPrice = Pastry.GetTotalPastryPrice() + Bread.GetTotalBreadPrice();
      return totalOrderPrice;
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
        Console.WriteLine("".PadLeft(4) + "The quantity entered is not valid");
        return 0;
      }
      catch (Exception exception)
      {
        Console.WriteLine("".PadLeft(4) + "Unexpected error: " + exception.Message);
        return 0;
      }
    }

    public static void AskToReturn()
    {
      Console.WriteLine("".PadLeft(4) + "Would you like to return to the main menu?");
      Console.WriteLine("".PadLeft(10) + "[YES] or [NO]");
      string returnToMenu = Console.ReadLine();
      if (returnToMenu.ToLower() == "yes" || returnToMenu.ToLower() == "y")
      {
        Main();
      }
      else if (returnToMenu.ToLower() == "no" || returnToMenu.ToLower() == "n")
      {
        DisplayComeAgain();
      }
      else
      {
        AskToReturn();
      }
    }

    public static void AddToOrder()
    {
      Console.WriteLine("".PadLeft(4) + "Your total order includes: " + Bread.GetQuantity() + " bread, " + Pastry.GetQuantity() + " pastry");
      Console.WriteLine("".PadLeft(4) + "Would you like to add additional bread or pastry to your order?");
      Console.WriteLine("".PadLeft(16) + "[BREAD] [PASTRY] [BOTH] [QUIT]");
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
        DisplayComeAgain();
      }
      else
      {
        AddToOrder();
      }
    }

    public static void DisplayComeAgain()
    {
      string come = @"
        _____ ____  __  __ ______ 
       / ____/ __ \|  \/  |  ____|
      | |   | |  | | \  / | |__   
      | |   | |  | | |\/| |  __|  
      | |___| |__| | |  | | |____ 
       \_____\____/|_|  |_|______|";
      string again = @"
                _____          _____ _   _ 
          /\   / ____|   /\   |_   _| \ | |
         /  \ | |  __   /  \    | | |  \| |
        / /\ \| | |_ | / /\ \   | | | . ` |
       / ____ \ |__| |/ ____ \ _| |_| |\  |
      /_/    \_\_____/_/    \_\_____|_| \_|";
      string soon = @"
        _____  ____   ____  _   _ 
       / ____|/ __ \ / __ \| \ | |
      | (___ | |  | | |  | |  \| |
       \___ \| |  | | |  | | . ` |
       ____) | |__| | |__| | |\  |
      |_____/ \____/ \____/|_| \_|";
      Console.Clear();
      Console.WriteLine(come);
      Console.WriteLine(again);
      Console.WriteLine(soon);
    }
  }
}