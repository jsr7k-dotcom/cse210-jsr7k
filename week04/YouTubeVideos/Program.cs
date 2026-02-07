using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Emotional Intelligence", "Daniel Goleman", 660);
        v1.AddComment(new Comment("Garret Cato", "This video is right on point!"));
        v1.AddComment(new Comment("Anakin", "This helped me a lot."));
        v1.AddComment(new Comment("Lucius M.", "Thanks for the video!"));

        Video v2 = new Video("Defense against dark arts", "Severus Snape", 420);
        v2.AddComment(new Comment("Harry", "Nice examples."));
        v2.AddComment(new Comment("Ron", "Good pace."));
        v2.AddComment(new Comment("Hermione", "Can you do more?"));

        videos.Add(v1);
        videos.Add(v2);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (sec): {video.LengthSeconds}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}