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
      ScoreChecker checker = new ScoreChecker();

      int score = ScoreChecker.CalculateScore("");
      Assert.AreEqual("", score);
    }
  }
}
