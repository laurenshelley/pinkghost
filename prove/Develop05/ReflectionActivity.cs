using System;

public class ReflectionActivity : Activity
{
    private readonly string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly string[] _questions = {
        "Why was this experience meaningful to you?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
    }

    public override void Start()
    {
        base.Start();

        Random random = new();
        string prompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine(prompt);
        ShowSpinner(3);

        for (int i = 0; i < _duration / 5; i++)
        {
            Console.WriteLine(_questions[random.Next(_questions.Length)]);
            ShowSpinner(5);
        }
        base.End();
    }
}
