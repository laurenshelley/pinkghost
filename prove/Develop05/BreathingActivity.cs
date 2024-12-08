using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by guiding you through slow, deep breathing. Clear your mind and focus on your breathing.";
    }

    public override void Start()
    {
        base.Start();
        int timePerBreath = 4;
        int cycles = _duration / (timePerBreath * 2);

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(timePerBreath);
            Console.WriteLine("Breathe out...");
            ShowCountdown(timePerBreath);
        }
        base.End();
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}
