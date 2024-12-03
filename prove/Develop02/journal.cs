using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    class Journal
    {
        private List<Entry> _entries;
        private static readonly string[] _prompts =
        {
            "What is one positive thing that happened to you today?",
            "What challenge did you face today, and how did you deal with it?",
            "Who made an impact on your day, and why?",
            "What is something new you tried or learned today?",
            "Describe a moment that made you feel calm or happy today.",
            "What is one goal you achieved today?",
            "What is something you are looking forward to tomorrow?",
            "What was your favorite meal or snack today?",
            "If today was a color, what color would it be and why?",
            "What is one thing you would like to improve for tomorrow?"
        };

        public Journal()
        {
            _entries = new List<Entry>();
        }

        public void WriteEntry()
        {
            Random random = new Random();
            string prompt = _prompts[random.Next(_prompts.Length)];
            Console.WriteLine("\nPrompt: " + prompt);
            Console.Write("Your response: ");
            string response = Console.ReadLine();
            _entries.Add(new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response));
        }

        public void DisplayEntries()
        {
            Console.WriteLine("\nJournal Entries:");
            if (_entries.Count == 0)
            {
                Console.WriteLine("No entries to display.");
            }
            else
            {
                foreach (var entry in _entries)
                {
                    Console.WriteLine(entry);
                }
            }
        }

        public void SaveToFile()
        {
            Console.Write("\nEnter the filename to save to: ");
            string filename = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine(entry.ToFileString());
                }
            }
            Console.WriteLine("Journal saved to " + filename);
        }

        public void LoadFromFile()
        {
            Console.Write("\nEnter the filename to load from: ");
            string filename = Console.ReadLine();
            if (File.Exists(filename))
            {
                _entries.Clear();
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        _entries.Add(Entry.FromFileString(line));
                    }
                }
                Console.WriteLine("Journal loaded from " + filename);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}