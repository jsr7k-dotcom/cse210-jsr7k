using System;
using System.Collections.Generic;


public class Scripture
{
    // Member variable to store the scripture reference (e.g., "John 3:16")
    private Reference _reference;

    // Member variable to store the list of Word objects
    // Each Word knows if it's hidden or visible
    private List<Word> _words;

    // Constructor: takes a Reference object and the scripture text as a string
    // Splits the text into individual words and creates Word objects
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text by spaces to get individual words
        string[] words = text.Split(' ');

        // Create a Word object for each word and add to the list
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    // Method to hide a random number of words that aren't already hidden
    // Takes the number of words to hide as a parameter
    public void HideRandomWords(int numberToHide)
    {
        // Create a Random object to generate random numbers
        Random random = new Random();
        int hiddenCount = 0;

        // Keep hiding words until we've hidden the requested amount
        while (hiddenCount < numberToHide)
        {
            // Pick a random index from the words list
            int index = random.Next(_words.Count);

            // Only hide the word if it's not already hidden
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }

            // Break if all words are hidden (prevents infinite loop)
            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }

    // Method to get the complete display text of the scripture
    // Returns the reference followed by all words (hidden or visible)
    public string GetDisplayText()
    {
        // Start with the reference (e.g., "John 3:16")
        string result = _reference.GetDisplayText() + " ";

        // Add each word's display text (either the word or underscores)
        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        // Remove the trailing space and return
        return result.Trim();
    }

    // Method to check if all words in the scripture are hidden
    // Returns true if all words are hidden, false if any are still visible
    public bool IsCompletelyHidden()
    {
        // Loop through all words
        foreach (Word word in _words)
        {
            // If we find any word that's not hidden, return false
            if (!word.IsHidden())
            {
                return false;
            }
        }
        // If we made it through the whole list, all words are hidden
        return true;
    }
}