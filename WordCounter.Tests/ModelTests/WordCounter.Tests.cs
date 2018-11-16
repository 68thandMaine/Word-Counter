using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordFrequencyCounterTest
  {

    [TestMethod]
    public void Constructor_CreatesInstanceOfWordFrequencyCounter_True()
    {
      WordFrequencyCounter newWord = new WordFrequencyCounter(" ", " ");
      Assert.AreEqual(typeof(WordFrequencyCounter), newWord.GetType());
    }

    [TestMethod]
    public void ReturnString_ReturnsAString_String()
    {
      string testLetter = "a";
      WordFrequencyCounter newTest = new WordFrequencyCounter("a", " ");
      string result = newTest.ReturnString();
      Assert.AreEqual(testLetter, result);
    }

    [TestMethod]
    public void ReturnSentence_ReturnASentence_String()
    {
      string testSentence = "Wow, what a task this is";
      WordFrequencyCounter newTest = new WordFrequencyCounter("a", "Wow, what a task this is");
      string result = newTest.ReturnSentence();
      Assert.AreEqual(testSentence, result);
    }

  }
}
