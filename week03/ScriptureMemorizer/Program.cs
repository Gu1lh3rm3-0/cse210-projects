using System;

public class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("D&C" , 82, 10);
        Console.WriteLine(r1.GetDisplayText());

        Word w1 = new Word("I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise.");
        Console.WriteLine(w1.GetDisplayText());
        Console.ReadLine();
        Scripture s1 = new Scripture();
        s1.GetDisplayText();
       
    }
}