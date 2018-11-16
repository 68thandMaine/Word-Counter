using System.Collections.Generic;

namespace WordCounter.Models
{
  public class WordFrequencyCounter
  {
    private string _capturedWord;
    private string _capturedSentence;

    public WordFrequencyCounter (string word, string sentence)
    {
      _capturedWord = word;
      _capturedSentence = sentence;
    }
    public string ReturnString()
    {
      string compareString = _capturedWord;
      return compareString;
    }
    public string ReturnSentence()
    {
      string compareSentence = _capturedSentence;
      return compareSentence;
    }
    public string[] SplitSentence()
    {
      string userSentence = _capturedSentence;
      string[] splitList = userSentence.Split(' ');
      return splitList;

    }
  }
}
