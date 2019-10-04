using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTest
  {
    [TestMethod]
    public void WordMatch_ReturnsWhetherPhraseMatchesWord_BoolTrue()
    {
        // Arrange
        WordCounterCalc wordCounter = new WordCounterCalc("pat", "pat");
        // Act
        bool actual = wordCounter.WordMatch("pat", "pat");
        // Assert
        Assert.AreEqual(true, actual);
    }

    [TestMethod]
    public void WordMatch_ReturnsWhetherPhraseMatchesWord_BoolFalse()
    {
        // Arrange
        WordCounterCalc wordCounter = new WordCounterCalc("hat", "pat");
        // Act
        bool actual = wordCounter.WordMatch("hat", "pat");
        // Assert
        Assert.AreEqual(false, actual);
    }

    [TestMethod]
    public void PhraseContains_ReturnsWhetherPhraseContainsWord_BoolTrue()
    {
        // Arrange
        WordCounterCalc wordCounter = new WordCounterCalc("this", "this place");
        // Act
        bool actual = wordCounter.PhraseContains();
        // Assert
        Assert.AreEqual(true, actual);
    }

    [TestMethod]
    public void PhraseContains_ReturnsWhetherPhraseContainsWord_BoolFalse()
    {
        // Arrange
        WordCounterCalc wordCounter = new WordCounterCalc("this", "that place");
        // Act
        bool actual = wordCounter.PhraseContains();
        // Assert
        Assert.AreEqual(false, actual);
    }  

    [TestMethod]
    public void PhraseContains_CountValueisIncreasedByMatches_Int2()
    {
        // Arrange
        WordCounterCalc wordCounter = new WordCounterCalc("an", "an apple, an orange");
        // Act
        wordCounter.PhraseContains();
        int actual = wordCounter.Count;
        // Assert
        Assert.AreEqual(2, actual);
    }

    [TestMethod]
    public void PhraseContains_CountValueIgnoresPartialMatches_Int2()
    {
        // Arrange
        WordCounterCalc wordCounter = new WordCounterCalc("an", "an apple and an orange");
        // Act
        wordCounter.PhraseContains();
        int actual = wordCounter.Count;
        // Assert
        Assert.AreEqual(2, actual);
    }
    
    [TestMethod]
    public void WordMatch_AccountsForCapitals_Int2()
    {
        // Arrange
        WordCounterCalc wordCounter = new WordCounterCalc("an", "An apple and an orange");
        // Act
        wordCounter.PhraseContains();
        int actual = wordCounter.Count;
        // Assert
        Assert.AreEqual(2, actual);
    } 

    [TestMethod]
    public void CharacterCleaner_IgnoresSpecialCharacters_StringCant()
    {
        // Arrange
        WordCounterCalc wordCounter = new WordCounterCalc("", "");
        // Act
        string actual = wordCounter.CharacterCleaner("can't");
        // Assert
        Assert.AreEqual("cant", actual);
    }

    [TestMethod]
    public void CharacterCleaner_IgnoresSpecialCharacters_Int1()
    {
        // Arrange
        WordCounterCalc wordCounter = new WordCounterCalc("cant", "I can't");
        // Act
        wordCounter.PhraseContains();
        int actual = wordCounter.Count;
        // Assert
        Assert.AreEqual(1, actual);
    } 
  }
}