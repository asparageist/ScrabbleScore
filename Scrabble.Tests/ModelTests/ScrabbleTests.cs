using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System.Collections.Generic;
using System;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScoreCheckerTests
  {
    [TestMethod]
    public void CalculateScore_EmptyString()
    {

      //Arrange
      ScoreChecker checker = new ScoreChecker();

      //Act
      int score = checker.CalculateScore("");

      //Assert
      Assert.AreEqual(0, score);
    }

    [TestMethod]
    public void CalculateScore_CheckValues()
    {

      //Arrange
      ScoreChecker checker = new ScoreChecker();
      //Act
      int score = checker.CalculateScore("accounting");
      //Assert
      Assert.AreEqual(15, score);

    }

    // [TestMethod]
    // public void CalculateScore_CheckIncorrectValues()
    // {

    //   //Arrange
    //   ScoreChecker checker = new ScoreChecker();
    //   //Act
    //   int score = checker.CalculateScore("accounting");
    //   //Assert
    //   Assert.AreEqual(17, score);

    // }
  }
}
