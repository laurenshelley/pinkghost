using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public virtual void Start()
    {
        Console.WriteLine($"Starting: {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("How many seconds would you like to do this activity for?");
        _duration = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
    }

    public virtual void End()
    {
        Console.WriteLine($"Great job completing the {_name} for {_duration} seconds!");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "\\", "|", "/", "-" };
        int spinnerIndex = 0;

        for (int i = 0; i < seconds * 4; i++) // Show spinner for the total time in increments of 250ms
        {
            Console.Write($"\r{spinner[spinnerIndex]}");
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            Thread.Sleep(250); // Delay for 250ms
        }
        Console.Write("\r "); // Clear the spinner line
    }
}
