using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        String grade = Console.ReadLine();
        int percentageGrade = int.Parse(grade);

        string letter = "";

        if (percentageGrade >= 90)
        {
            letter = "A";
        }
        else if (percentageGrade >= 80)
        {
            letter = "B";
        }
        else if (percentageGrade >= 70)
        {
            letter = "C";
        }
        else if (percentageGrade >= 60)
        {
            letter = "D";
        }
        else if (percentageGrade < 60)
        {
            letter = "F";
        }
        if (letter == "F" || letter == "D")
        {
            Console.WriteLine("I'm sorry but you didn't pass, better luck next time!");
        }
        else if (letter == "C" || letter == "B" || letter == "A")
        {
            Console.WriteLine("Congratulations you passed the course!");
        }
    }
}