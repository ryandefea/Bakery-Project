using System;
using System.Collections.Generic;

namespace Py.Models
{
  public class Pastry
  {
    public int PastryAmount { get; set; }
    public int Price { get; set; }
    
    public Pastry(int userInput)
    {
      PastryAmount = userInput;
      Price = 0;
    }

     public int pastryPrice () {
      int currentPastry = 2;
      int finalPastry = currentPastry * PastryAmount;
      Price = finalPastry;
      return finalPastry;
    } 

    public void pastryFigure () {
      if (PastryAmount == 1)
      {
        Price = 2;
      }
      else if (PastryAmount == 2)
      {
        Price = 4;
      }
      else if (PastryAmount == 3)
      {
        Price = 5;
      }
      else if (PastryAmount == 4)
      {
        Price = 7;
      }
      else if (PastryAmount == 5)
      {
        Price = 9;
      }
      else 
      {
        Price = 10;
      }
    }

  }
}
