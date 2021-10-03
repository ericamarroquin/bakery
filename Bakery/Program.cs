using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Bread is $5 per loaf, where every third loaf is free.");
      Console.WriteLine("Pasties are $2 for 1 or $5 for 3.");
      
      Console.WriteLine("How many loaves of bread would you like?");
      string userBreadQuantity = Console.ReadLine();

      Console.WriteLine("How many pastries would you like?");
      string userPastryQuantity = Console.ReadLine();

      Bread loavesOfBread = new Bread(int.Parse(userBreadQuantity));
      Pastry numberOfPastries = new Pastry(int.Parse(userPastryQuantity));
      int totalCost = loavesOfBread.Cost() + numberOfPastries.Cost();

      Console.WriteLine("Thank you! Your total cost today is $" + totalCost + ".");
      Console.WriteLine("Would you like to make another purchase? Yes to continue, anything else to quit.");
      string continueOrder = Console.ReadLine();
      if (continueOrder.ToLower() == "yes")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}