using System;
using System.Security.Cryptography;

public class Prompt
{
    public string _prompt;

    public List<Prompt> myPrompts = new List<Prompt>();

    public void Display()
    {
        foreach (Prompt displayPrompt in myPrompts)
        {
            displayPrompt.Display();
        }
    }
}