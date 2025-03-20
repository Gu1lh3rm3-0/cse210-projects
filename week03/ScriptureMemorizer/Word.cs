using System;

public class Word
{
    private string _Text;
    private bool _isHidden;
    public Word(string text);
    
    public void Hide();
    public void Show();
    public bool IsHidden();
    public string GetDisplayText();

}