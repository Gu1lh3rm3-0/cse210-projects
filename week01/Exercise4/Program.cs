using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int userNumber = -1 ; 

        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            String userNew = Console.ReadLine();
            userNumber = int.Parse(userNew);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;

        foreach (int summedNumber in numbers)
        {
            sum += summedNumber; 
        }

        Console.WriteLine($"The sum of the numbers is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int maxNumber in numbers)
        {
            if (maxNumber > max)
            {
                max = maxNumber;
            }
        }
        Console.WriteLine($"The max number is: {max}");
    }
}