public class Fraction
{
    // Top number of the fraction
    private int _numerator;

    // Bottom number of the fraction
    private int _denominator;

    // Constructor with no parameters - creates 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor with one parameter - creates whole number as fraction (e.g., 5 = 5/1)
    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    // Constructor with two parameters - creates fraction with specified numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Returns the fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        // Build the string representation
        return $"{_numerator}/{_denominator}";
    }

    // Returns the decimal value of the fraction (e.g., 0.75 for 3/4)
    public double GetDecimalValue()
    {
        // Divide numerator by denominator to get decimal
        // Cast to double to get decimal result
        return (double)_numerator / (double)_denominator;
    }
}