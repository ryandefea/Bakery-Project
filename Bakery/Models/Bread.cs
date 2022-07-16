using System;
using System.Collections.Generic;

namespace Bd.Models
{
  public class Bread
  {
    public int BreadAmount { get; set; }
    public int Price { get; set; }
    
    public Bread(int userInput)
    {
      BreadAmount = userInput;
      Price = 0;
    }

    public int breadPrice () {
      int currentBread = 5;
      int finalBread = currentBread * BreadAmount;
      Price = finalBread;
      return finalBread;
    } 

    public void breadFigure () { 
      if (Price % 3 == 0)
      {
        int endBread = Price-(Price*1/3);
        Price = endBread;
      }   
      else
      {
        Price = Price;
      }

    }


    
    }
  }
