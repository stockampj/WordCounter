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

    public bool WordMatch(string comparisonWord, string evaluatedWord)
    {
      if (comparisonWord.ToLower() == evaluatedWord.ToLower())
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public string CharacterCleaner(string wordToBeCleaned)
    {
      List<char> acceptedCharacters = new List<char> {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
      string output = "";
      char[] wordArray = wordToBeCleaned.ToLower().ToCharArray();
      foreach (char character in wordArray)
        {
          if (acceptedCharacters.Contains(character))
          {
            output += character;
          }
        }
      return output;
    }

    public bool PhraseContains()
    {
      bool PhraseContainsWord = false;
      string[] phraseSplit = Phrase.Split(' ');
      string wordToMatch = CharacterCleaner(Word);
      foreach (string wordInPhrase in phraseSplit)
      {
        string wordInPhraseCleaned = CharacterCleaner(wordInPhrase);
        if (WordMatch(wordToMatch, wordInPhraseCleaned))
        {
          PhraseContainsWord = true;
          Count++;
        }
      }
      return PhraseContainsWord;
    }
  }
}