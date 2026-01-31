using System;
using System.Collections.Generic;

// Main program for Scripture Memorizer
// Helps users memorize scriptures by progressively hiding words
class Program
{
    static void Main(string[] args)
    {
        // Exceeding Requirements:
        // 1. Scripture Library - Program has multiple scriptures and randomly selects one
        // 2. Loop to Main Menu - User can memorize multiple scriptures without restarting program

        // Keep running until user chooses to quit
        bool keepGoing = true;
        while (keepGoing)
        {
            // Create scripture library
            List<Scripture> scriptureLibrary = CreateScriptureLibrary();

            // Randomly select a scripture from the library
            Random random = new Random();
            Scripture scripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

            // Run the memorization loop for this scripture
            RunMemorizationLoop(scripture);

            // Ask if user wants to memorize another scripture
            Console.WriteLine();
            Console.WriteLine("Would you like to memorize another scripture? (yes/no):");
            string response = Console.ReadLine().ToLower();

            if (response != "yes" && response != "y")
            {
                keepGoing = false;
            }
        }

        Console.WriteLine("Thank you for using Scripture Memorizer!");
    }

    // Method to create and return a library of scriptures
    static List<Scripture> CreateScriptureLibrary()
    {
        List<Scripture> library = new List<Scripture>();

        // Add John 3:16
        library.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
        ));

        // Add Proverbs 3:5-6
        library.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."
        ));

        // Add Philippians 4:13
        library.Add(new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me."
        ));

        // Add 1 Nephi 3:7
        library.Add(new Scripture(
            new Reference("1 Nephi", 3, 7),
            "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
        ));

        // Add Mosiah 2:17
        library.Add(new Scripture(
            new Reference("Mosiah", 2, 17),
            "When ye are in the service of your fellow beings ye are only in the service of your God."
        ));

        return library;
    }

    // Method to run the memorization loop for a scripture
    static void RunMemorizationLoop(Scripture scripture)
    {
        // Main program loop
        // Continues until user types "quit" or all words are hidden
        string userInput = "";
        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            // Clear the console screen for a clean display
            Console.Clear();

            // Display the scripture (with some words hidden)
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            // Prompt the user
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            // If user didn't type "quit", hide 3 more random words
            if (userInput != "quit")
            {
                scripture.HideRandomWords(3); // Hide 3 words at a time
            }
        }

        // Show final hidden scripture if all words are hidden
        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("All words are hidden! Great job!");
        }
    }
}