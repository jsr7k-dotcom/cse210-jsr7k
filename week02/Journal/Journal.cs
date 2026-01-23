using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("\n--- Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("-----------------------");
    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to file...");

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                // I am using a pipe symbol | as a separator to ensure 
                // commas in the user's text don't break the file format.
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine("Saved successfully.");
    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine("Loading from file...");
        _entries.Clear(); // Clears current entries before loading new ones

        try
        {
            string[] lines = System.IO.File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                // Ensure the line has 3 parts (Date, Prompt, Text)
                if (parts.Length == 3)
                {
                    Entry loadedEntry = new Entry();
                    loadedEntry._date = parts[0];
                    loadedEntry._promptText = parts[1];
                    loadedEntry._entryText = parts[2];

                    _entries.Add(loadedEntry);
                }
            }
            Console.WriteLine("Loaded successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");
        }
    }
}