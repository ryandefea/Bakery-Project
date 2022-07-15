using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bd.Models;

namespace Bd.Tests
{
  [TestClass]
  public class BdTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void breadPrice_ReturningFinalBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(5, newBread.breadPrice());
    }

    [TestMethod]
    public void breadFigure_GivePrice_int()
    {
      Bread newBread = new Bread(3);
      newBread.breadPrice();
      newBread.breadFigure();
      Assert.AreEqual(10, newBread.Price);
    }

    [TestMethod]
    public void SetPrice_SetPrice_int()
    {
      Bread newBread = new Bread(1);
      newBread.breadPrice();
      Assert.AreEqual(5,newBread.Price);
    }

   
  }
}