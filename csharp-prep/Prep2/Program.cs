using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt user to enter their grade percentage on an assignment
        Console.Write("What percentage did you get on your assignment? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        // calculate the letter grade based on the percentage
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // output the letter grade
        Console.WriteLine($"You got a(n) {letter}!");
        
        // output a message based on the percentage
        if (percent >= 70)
        {
            Console.WriteLine("Congrats, you passed!");
        }
        else
        {
            Console.WriteLine("You failed, better luck next time!");
        }
    }
}