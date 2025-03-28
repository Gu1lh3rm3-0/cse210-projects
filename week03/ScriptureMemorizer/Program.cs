using System;

public class Program
{
    static void Main(string[] args)
    {
        Scripture s1 = new Scripture("D&C 82:10","I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise.")
        Console.WriteLine(s1.GetDisplayText());
        Console.Clear();
        Console.WriteLine(s1.GetDisplayText());
    }
}