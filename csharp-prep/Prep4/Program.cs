using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter a list of numbers, type 0 when finished.");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
                break;

            numbers.Add(number);
        }

        // Compute the sum
        int totalSum = 0;
        foreach (int num in numbers)
        {
            totalSum += num;
        }
        Console.WriteLine("The sum is: " + totalSum);

        // Compute the average
        if (numbers.Count > 0)
        {
            double average = (double)totalSum / numbers.Count;
            Console.WriteLine("The average is: " + average);
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }

        // Find the maximum number
        if (numbers.Count > 0)
        {
            int maxNumber = numbers.Max();
            Console.WriteLine("The largest number is: " + maxNumber);
        }
    }
}