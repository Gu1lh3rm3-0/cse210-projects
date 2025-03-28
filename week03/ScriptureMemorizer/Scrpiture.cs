using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _Reference;
    private List<Word> _words = new List<Word>();
    public Scripture (Reference Reference, string text)
    {
       _words = new List<Word>();
       _words.Add(_Reference);
    }
    public void HideRandomWords(int numberToHide)
    {
      Random words = new Random();
      words.Next(_words);
    }
    public string GetDisplayText()
    {
       string text = $"{_words}";
       return text;
    }
    public bool IsCompletlyHidden()
    {
        isHidden = true; 
       foreach (Word word in _words)
       {
        if (word == "_")
        {
           isHidden = true;
        }
        return isHidden;
       }
    }

}
