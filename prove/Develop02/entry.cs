using System;

namespace JournalApp
{
    class Entry
    {
        public string Date { get; }
        public string Prompt { get; }
        public string Response { get; }

        public Entry(string date, string prompt, string response)
        {
            Date = date;
            Prompt = prompt;
            Response = response;
        }

        public override string ToString()
        {
            return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
        }

        public string ToFileString()
        {
            return $"{Date}~|~{Prompt}~|~{Response}";
        }

        public static Entry FromFileString(string fileString)
        {
            var parts = fileString.Split("~|~");
            if (parts.Length == 3)
            {
                return new Entry(parts[0], parts[1], parts[2]);
            }
            throw new FormatException("Invalid entry format in file.");
        }
    }
}