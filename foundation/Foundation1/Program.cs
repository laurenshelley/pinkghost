using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create some videos
        Video video1 = new Video("How to Cook Pasta", "Chef Salena", 300);
        Video video2 = new Video("Learn Python in 10 Minutes", "Code School", 600);
        Video video3 = new Video("Top 10 Travel Destinations", "Adventure is out there", 900);

        // Add comments to videos
        video1.AddComment(new Comment("Bob", "Great recipe!"));
        video1.AddComment(new Comment("Joe", "Tried it, loved it!"));
        video1.AddComment(new Comment("Carl", "Perfect for dinner parties."));

        video2.AddComment(new Comment("Jake", "Very concise and helpful!"));
        video2.AddComment(new Comment("Steve", "Can you make a video on advanced Python?"));
        video2.AddComment(new Comment("Ryan", "Best tutorial ever!"));

        video3.AddComment(new Comment("Rachel", "Adding these to my bucket list!"));
        video3.AddComment(new Comment("Tom", "Amazing places!"));
        video3.AddComment(new Comment("Heather", "I need to start traveling more."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
