using System;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal= new Journal();
            string userInput;

            do
            {
                Console.WriteLine("\nJournal App Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option (1-5): ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        journal.WriteEntry();
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

            } while (userInput != "5");
        }
    }
}