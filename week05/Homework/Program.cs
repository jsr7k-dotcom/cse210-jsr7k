using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Charles Brown", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignment math1 = new MathAssignment("Sheldon Cooper", "Fractions", "6.8", "7-18");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writing1 = new WritingAssignment("Leonard Hoftstader", "European History", "The Causes of World War II");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}