using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the scripture with reference and text
        ScriptureReference reference = new ScriptureReference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, scriptureText);

        // Interactive loop
        while (true)
        {
            Console.Clear();
            scripture.Display();

            // Check if all words are hidden
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nGood job! You've memorized the scripture!");
                break;
            }

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideWords();
        }
    }
}

// Class for Scripture Reference
class ScriptureReference
{
    public string Book { get; private set; }
    public int StartChapter { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndVerse { get; private set; }

    // Constructor for single verse

    public ScriptureReference(string book, int chapter, int startVerse)
    {
        Book = book;
        StartChapter = chapter;
        StartVerse = startVerse;
        EndVerse = null;
    }

    // Constructor for verse range
    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        StartChapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse == null
            ? $"{Book} {StartChapter}:{StartVerse}"
            : $"{Book} {StartChapter}:{StartVerse}-{EndVerse}";
    }
}

// Class for individual words
class Word
{
    private string Text { get; }
    private bool IsHidden { get; set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    // Hide the word
    public void Hide()
    {
        IsHidden = true;
    }

    // Check if the word is hidden
    public bool Hidden => IsHidden;

    // Display the word, hidden or visible
    public override string ToString()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}

// Class for Scripture
class Scripture
{
    private ScriptureReference Reference { get; }
    private List<Word> Words { get; }

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Display the scripture
    public void Display()
    {
        Console.WriteLine(Reference);
        Console.WriteLine(string.Join(" ", Words));
    }

    // Hide a few random words
    public void HideWords()
    {
        Random random = new Random();
        var visibleWords = Words.Where(word => !word.Hidden).ToList();

        if (visibleWords.Count > 0)
        {
            int wordsToHide = Math.Min(3, visibleWords.Count); // Hide up to 3 words
            for (int i = 0; i < wordsToHide; i++)
            {
                Word wordToHide = visibleWords[random.Next(visibleWords.Count)];
                wordToHide.Hide();
                visibleWords.Remove(wordToHide);
            }
        }
    }

    // Check if all words are hidden
    public bool AllWordsHidden()
    {
        return Words.All(word => word.Hidden);
    }
}


