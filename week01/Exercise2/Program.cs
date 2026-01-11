using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the grade percentage:");
        string input = Console.ReadLine();

        int gradePercentage = int.Parse(input);

        string gradeLetter;

        if (gradePercentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        string gradeSign;
        int lastDigit = gradePercentage % 10;

        if (lastDigit >= 7)
        {
            gradeSign = "+";
        }
        else if (lastDigit <3)
        {
            gradeSign = "-";
        }
        else
        {
            gradeSign = "";
        }

        if (gradeLetter == "A" && lastDigit < 3)
        {
            gradeSign = "-";
        }
        else if (gradeLetter == "A" && lastDigit >= 3)
        {
            gradeSign = "";
        }
        else if (gradeLetter == "F")
        {
            gradeSign = "";
        }


        Console.WriteLine($"Your letter grade is {gradeLetter}{gradeSign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you approved the class.");
        }
        else
        {
            Console.WriteLine("You need to work harder, the luck is not required in this class.");
        }
    }
}