using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptForUserName();
        int favoriteNumber = PromptForFavoriteNumber();

        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(userName, favoriteNumber, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptForUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptForFavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    static int SquareNumber(int number)
    {
        int result = number * number;
        return result;
    }

    static void DisplayResult(string name, int original, int squared)
    {
        Console.WriteLine();
        Console.WriteLine($"Hello {name}!");
        Console.WriteLine($"Your favorite number is {original}, and its square is {squared}.");
    }
}