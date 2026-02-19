using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        Running run = new Running("07 Nov 2025", 30, 4.8);
        Cycling cycle = new Cycling("15 Nov 2025", 45, 20.0);
        Swimming swim = new Swimming("30 Nov 2025", 25, 40);

        List<Activity> activities = new List<Activity>();
        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}