using System;
using System.Collections.Generic;

class Video
{
    public string _title { get; set; }
    public string _author { get; set; }
    public int _length { get; set; } // Length in seconds
    private List<Comment> _comments { get; set; }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nNumber of Comments: {NumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"  {comment}");
        }
        Console.WriteLine("\n---\n");
    }
}