using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Vid1
        Video v1 = new Video("How to code in C#", "TechGuy", 400);
        v1.AddComment(new Comment("Harry", "Great review, I will try it!"));
        v1.AddComment(new Comment("Bobby", "Very helpful."));
        v1.AddComment(new Comment("Xavier", "Thanks for explaining!"));
        videos.Add(v1);

        // Vid2
        Video v2 = new Video("Abstraction Explained", "TypingMaster", 650);
        v2.AddComment(new Comment("Estefania", "Now I understand how Abstraction works!"));
        v2.AddComment(new Comment("Luis", "Good examples, I will try them."));
        v2.AddComment(new Comment("Roberto", "Nice video, very well explained!"));
        videos.Add(v2);

        // Vid3
        Video v3 = new Video("Encapsulation Intro", "CodePro", 800);
        v3.AddComment(new Comment("Pedro", "Very clear explanation."));
        v3.AddComment(new Comment("Hugo", "Loved it!"));
        v3.AddComment(new Comment("Isabel", "Super useful."));
        videos.Add(v3);

        // Display all videos
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}