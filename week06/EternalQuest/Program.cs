/*
José Roberto Hernández Peña
CSE210
W06 Project: Eternal Quest Program
Extra Feature: I added a leveling system that increases the player's level every 100 points the player earns and displays a congratulatory message.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}