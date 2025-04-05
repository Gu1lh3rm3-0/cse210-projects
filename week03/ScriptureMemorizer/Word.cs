using System;

public class Word
{
    private string _Text;
    private bool _isHidden;
    public Word(string text)
    {
       _Text = text;
    }
    public void Hide()
    {
       _isHidden = true;
    }
    public void Show()
    {
       _isHidden = false;
    }
    public bool isHidden()
    {
       return _isHidden;
    }
    public string GetDisplayText()
    {
       if (_isHidden)
       {
         return "__";
       }
       else
       {
         return _Text;
       }
    }
}