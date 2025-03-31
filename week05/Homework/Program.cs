using System;

class Program
{
    static void Main(string[] args)
    {
        Assingment a1 = new Assingment("Samuel Bennet","Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssingment m1 = new MathAssingment("Roberto Rodriguez", "Fractions", "7:3", "8-19");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());

        WritingAssingment w1 = new WritingAssingment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInfo());
    }
}