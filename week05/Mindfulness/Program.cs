using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Mindfulness Project.");

        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (choice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunBreathing();
                    break;

                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.RunReflection();
                    break;

                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.RunListing();
                    break;

                case 4:
                    Console.WriteLine("Please come back soon!");
                    break;

                default:
                    Console.WriteLine("I'm afraid that's an invalid choice. Please try again.");
                    break;
            }

            if (choice != 4)
            {
                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}