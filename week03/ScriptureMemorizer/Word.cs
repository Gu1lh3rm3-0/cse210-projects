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
       _Text = "_";
    }
    public void Show()
    {
       Console.WriteLine(_Text);
    }
    public bool isHidden()
    {
       return _isHidden;
    }
    public string GetDisplayText()
    {
       string displayText = $"{_Text}";
       return displayText;
    }
}