using System;
using System.Security.Cryptography;

public class Prompt
{

    public List<Entry> _newPrompt = new List<Entry>();

    public void Display()
    {
        Console.WriteLine(_newPrompt);

        foreach (Entry displayPrompt in _newPrompt)
        {
            Random GetRandomPrompt = new Random();
            int index = GetRandomPrompt.Next(_newPrompt.Count);
            Console.WriteLine(_newPrompt[index]);
        }
    }
}