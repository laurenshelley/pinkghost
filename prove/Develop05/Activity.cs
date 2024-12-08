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
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
