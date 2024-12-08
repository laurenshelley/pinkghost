using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalScore = 0;

        while (true)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Show total score");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Choose goal type:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    string type = Console.ReadLine();

                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter points: ");
                    int points = int.Parse(Console.ReadLine() ?? "0");

                    if (type == "1")
                    {
                        goals.Add(new SimpleGoal(name, description, points));
                    }
                    else if (type == "2")
                    {
                        goals.Add(new EternalGoal(name, description, points));
                    }
                    else if (type == "3")
                    {
                        Console.Write("Enter target count: ");
                        int targetCount = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Enter bonus points: ");
                        int bonusPoints = int.Parse(Console.ReadLine() ?? "0");
                        goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                    }
                    break;

                case "2":
                    Console.WriteLine("Select a goal to record:");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i]}");
                    }
                    int goalIndex = int.Parse(Console.ReadLine() ?? "0") - 1;
                    if (goalIndex >= 0 && goalIndex < goals.Count)
                    {
                        Goal goal = goals[goalIndex];
                        goal.RecordEvent();
                        totalScore += goal.GetPoints();

                        if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
                        {
                            totalScore += checklistGoal.GetBonusPoints();
                        }
                    }
                    break;

                case "3":
                    Console.WriteLine("Goals:");
                    foreach (Goal goal in goals)
                    {
                        Console.WriteLine(goal);
                    }
                    break;

                case "4":
                    Console.WriteLine($"Total Score: {totalScore}");
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
