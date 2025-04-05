using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _Reference;
    private List<Word> _words = new List<Word>();
    public Scripture (Reference reference, string text)
    {
      _Reference = reference;
      _words = new List<Word>();
      String[] scriptureWords = text.Split((" "),StringSplitOptions.RemoveEmptyEntries);
      foreach (string scptText in scriptureWords)
      {
        _words.Add(new Word(scptText));
      }
    }
    public void HideRandomWords(int numberToHide)
    {
       Random random = new Random();
       int hiddenWord = 0;

       while (hiddenWord < numberToHide)
       {
          int numbers = random.Next(_words.Count);
          if (_words[numbers].isHidden())
          {
            _words[numbers].Hide();
            hiddenWord++;
          }
       }
    }
    public string GetDisplayText()
    {
       string displayText = $"{_Reference.GetDisplayText()}";
       return displayText;
    }
    public bool IsCompletlyHidden()
    {
      foreach (var word in _words)
      if (word.isHidden())
      {
        return false;
      }
      return true;
    }

}
