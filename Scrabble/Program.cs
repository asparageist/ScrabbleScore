using System;
using System.Collections.Generic;
using System.Linq;
using Scrabble.Models;


namespace Scrabble
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Scrabble Score!");
      Console.WriteLine("Please enter a word to score!");

      string userWord = Console.ReadLine();
      ScoreChecker checker = new ScoreChecker();
      var scoreTotal = checker.CalculateScore(userWord);

      Console.WriteLine($"Your score is {scoreTotal}.");
    }
  }
}