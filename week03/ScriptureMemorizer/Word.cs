using System;


public class Word
{
    // Member variable to store the actual word text
    private string _text;

    // Member variable to track if this word is hidden (true) or visible (false)
    private bool _isHidden;

    // Constructor: takes the word text and sets it to visible by default
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Words start visible
    }

    // Method to hide this word (sets _isHidden to true)
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to show this word (sets _isHidden to false)
    // Not used in basic program but good to have
    public void Show()
    {
        _isHidden = false;
    }

    // Method to check if this word is currently hidden
    // Returns true if hidden, false if visible
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method to get the display text for this word
    // If hidden: returns underscores matching the word length (e.g., "______")
    // If visible: returns the actual word text (e.g., "prayer")
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Create a string of underscores the same length as the word
            return new string('_', _text.Length);
        }
        else
        {
            // Return the actual word
            return _text;
        }
    }
}