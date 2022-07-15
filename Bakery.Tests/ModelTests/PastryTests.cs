using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Py.Models;

namespace Py.Tests
{
  [TestClass]
  public class PyTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void pastryPrice_ReturningFinalPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(2, newPastry.pastryPrice());
    }

    [TestMethod]
    public void pastryFigure_SetPrice_int()
    {
      Pastry newPastry = new Pastry(1);
      newPastry.pastryPrice();
      newPastry.pastryFigure();
      Assert.AreEqual(2,newPastry.Price);
    }

    [TestMethod]
    public void SetPrice_SetPrice_int()
    {
      Pastry newPastry = new Pastry(1);
      newPastry.pastryPrice();
      Assert.AreEqual(2,newPastry.Price);
    }

   
  }
}