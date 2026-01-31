using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 10 Minutes", "CodeMaster", 600);
        video1.AddComment(new Comment("John Smith", "Great tutorial! Very helpful for beginners."));
        video1.AddComment(new Comment("Maria Garcia", "Finally I understand classes!"));
        video1.AddComment(new Comment("Alex Johnson", "Could you make a follow-up video on inheritance?"));
        video1.AddComment(new Comment("Sarah Lee", "Best C# content on YouTube!"));
        videos.Add(video1);

        Video video2 = new Video("Epic Gaming Moments Compilation", "GamerPro99", 903);
        video2.AddComment(new Comment("Mike Wilson", "That last clip was insane!"));
        video2.AddComment(new Comment("Emma Brown", "How do you record your gameplay?"));
        video2.AddComment(new Comment("Chris Davis", "Please do more videos like this!"));
        videos.Add(video2);

        Video video3 = new Video("How to Make Perfect Pasta", "Chef Antonio", 480);
        video3.AddComment(new Comment("Lisa Taylor", "Made this for dinner, my family loved it!"));
        video3.AddComment(new Comment("Tom Anderson", "What brand of pasta do you recommend?"));
        video3.AddComment(new Comment("Nina White", "The sauce recipe is amazing!"));
        video3.AddComment(new Comment("David Chen", "Tried this twice, turns out great every time."));
        videos.Add(video3);

        Video video4 = new Video("Exploring Tokyo: 48 Hours Adventure", "TravelWithMe", 1245);
        video4.AddComment(new Comment("Rachel Kim", "Adding this to my bucket list!"));
        video4.AddComment(new Comment("James Miller", "The cinematography is stunning."));
        video4.AddComment(new Comment("Yuki Tanaka", "As a local, I'm impressed you found these spots!"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine();
            Console.WriteLine("Comments:");
            Console.WriteLine("----------------------------------------");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetCommenterName()}: \"{comment.GetCommentText()}\"");
            }
            
            Console.WriteLine();
        }
    }
}