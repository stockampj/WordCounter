using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class WordCounterCalc
  {
    public string Word {get; set;}
    public string Phrase {get; set;}
    public int Count {get; set;}
    public int PartialCount {get; set;}

    public WordCounterCalc( string word, string phrase)
    {
      Word = word;
      Phrase = phrase;
      Count = 0;
      PartialCount = 0;
    }

    public bool WordMatch()
    {
      if (Word == Phrase)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool PhraseContains()
    {
      bool PhraseContainsWord = false;
      string[] phraseSplit = Phrase.Split(' ');
      foreach (string wordInPhrase in phraseSplit)
      {
        if (wordInPhrase == Word)
        {
          PhraseContainsWord = true;
          Count++;
        }
      }
      return PhraseContainsWord;
    }
  }
}