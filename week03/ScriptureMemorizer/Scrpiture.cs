using System;

public class Scripture
{
    private string _Reference;
    public List<Word> _Text = new List<Word>();
    public string Scripture();
    public void HideRandomWords();
    public string GetDisplayText();
    public bool IsCompletlyHidden();

}
