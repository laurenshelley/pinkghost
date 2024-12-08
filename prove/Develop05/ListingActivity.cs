using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private readonly string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many as you can.";
    }

    public override void Start()
    {
        base.Start();

        Random random = new();
        string prompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine(prompt);
        ShowSpinner(3);

        Console.WriteLine("Start listing items:");
        List<string> items = new();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
                items.Add(item);
        }

        Console.WriteLine($"You listed {items.Count} items!");
        base.End();
    }
}
