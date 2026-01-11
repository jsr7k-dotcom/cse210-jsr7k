using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int userGuess = -1;
            int guessCount = 1;

            while (userGuess != magicNumber)
            {
                Console.WriteLine("Guess a number between 1 and 100");
                userGuess = int.Parse(Console.ReadLine());
                guessCount++;

                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You win!");
                    Console.WriteLine($"It took you {guessCount} times to guess.");
                }
            }
            Console.WriteLine("Do you want to play again?y/n");
            playAgain = Console.ReadLine().ToLower();
        }while (playAgain == "y");
    }
}