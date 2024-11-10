using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt user to select a random number between 1 and 100
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        // Generate a random number between 1 and 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What do you think the magic number is? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher, guess again");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower, guess again");
            }
            else
            {
                Console.WriteLine("Wohoo! You guessed it right!");
            }
        }
    }
}