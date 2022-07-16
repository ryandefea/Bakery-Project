using System;
using System.Collections.Generic;
using Bd.Models;
using Py.Models;

namespace Program.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Bakery");
      Console.WriteLine("A loaf of bread costs $5 and a pastry cost $2");
      Console.WriteLine("Would you like to buy bread and a pastry?(yes/no)");
      string answer = Console.ReadLine();
       if (answer == "yes")
       {
        Console.WriteLine("How many loaves of bread would you like?");
        int breadResponse = int.Parse(Console.ReadLine());

        Console.WriteLine("How many pastries would you like?");
        int pastryResponse = int.Parse(Console.ReadLine());

        Bread yesBread = new Bread(breadResponse);
        Pastry yesPastry = new Pastry(pastryResponse);

        yesBread.breadPrice();
        yesBread.breadFigure();
        yesPastry.pastryPrice();
        yesPastry.pastryFigure();
        Console.WriteLine("Your total for bread is $" + yesBread.Price);
        Console.WriteLine("Your total for pastries is $" + yesPastry.Price);
       }
       else
       {
        Console.WriteLine("Goodbye");
       }
    }
  }
}