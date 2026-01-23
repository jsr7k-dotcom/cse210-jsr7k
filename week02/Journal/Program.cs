using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the classes
        Journal theJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Write a new entry
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"\n{prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry(); // Create an empty entry
                newEntry._date = date;        // Fill in the date manually
                newEntry._promptText = prompt; // Fill in the prompt
                newEntry._entryText = response; // Fill in the response

                theJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                // Display all entries
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                // Load from file
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                theJournal.LoadFromFile(fileName);
            }
            else if (choice == "4")
            {
                // Save to file
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                theJournal.SaveToFile(fileName);
            }
            else if (choice == "5")
            {
                // Quit
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}