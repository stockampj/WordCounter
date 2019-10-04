using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace LiveProgam
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to my word counter.");
      Loop();
    }

    public static void Loop()
    {
      Console.WriteLine("Please enter a block of text you'd like me to analyze:");
      string userPhrase = Console.ReadLine();
      Console.WriteLine("What word should I search for in this text?");
      string userWord = Console.ReadLine();
      WordCounterCalc wordCounterCalc = new WordCounterCalc(userWord, userPhrase);
      wordCounterCalc.PhraseContains();
      int count = wordCounterCalc.Count;
      if (count > 0)
      {
        Console.WriteLine("I found that word in the text. Count: " + count);        
      }
      else
      {
        Console.WriteLine("I'm sorry, I couldn't find that word in the text");
      }
      Console.WriteLine("Would you like to try again? [Y/N]");
      string userResponse = Console.ReadLine();
      if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
      {
        Loop();
      }
    }
  }
}