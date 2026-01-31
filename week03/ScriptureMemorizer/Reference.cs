using System;


public class Reference
{
    // Member variable for the book name (e.g., "John", "Proverbs")
    private string _book;

    // Member variable for the chapter number
    private int _chapter;

    // Member variable for the verse number (or starting verse for a range)
    private int _verse;

    // Member variable for the ending verse (only used for verse ranges)
    // Set to -1 if there is no end verse (single verse reference)
    private int _endVerse;

    // Constructor for single verse reference (e.g., "John 3:16")
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1; // Indicates no end verse
    }

    // Constructor for verse range (e.g., "Proverbs 3:5-6")
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Method to get the formatted reference string
    // Returns "Book Chapter:Verse" for single verse
    // Returns "Book Chapter:Verse-EndVerse" for verse range
    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {
            // Single verse: "John 3:16"
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            // Verse range: "Proverbs 3:5-6"
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
