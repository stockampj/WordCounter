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
    public void CharValue_ReturnsCountOfAGivenCharacter_StringA()
    {
        // Arrange
        WordCounter wordCounter = new WordCounter("an apple is a fruit");
        // Act
        int actual = wordCounter.count('a');

        // Assert
        Assert.AreEqual(1, actual);
    }
  }
}