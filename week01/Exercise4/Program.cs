using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.WriteLine("Enter a number (0 to stop):");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput); 

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
//Sum of numbers
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
//Average
        double avg = 0;
        if (numbers.Count > 0)
        {
            avg = sum / numbers.Count;
        }
//Max number
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
