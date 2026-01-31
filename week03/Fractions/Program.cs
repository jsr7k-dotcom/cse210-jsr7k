using System;

// Program to test the Fraction class
class Program
{
    static void Main(string[] args)
    {
        // Test the no-parameter constructor (should create 1/1)
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        // Test the single-parameter constructor (should create 6/1)
        Fraction fraction2 = new Fraction(6);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        // Test two-parameter constructor with 3/4
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        // Test two-parameter constructor with 1/3
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
    }
}