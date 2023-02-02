using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> entries = new List<string>();
        bool running = true;
        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine();
            Console.WriteLine("==============================");
            Console.WriteLine("1. Show all entries");
            Console.WriteLine("2. Add an entry");
            Console.WriteLine("3. Exit");

            Console.WriteLine("\nEnter a menu number: ");
            string menuOption = Console.ReadLine();

            switch (menuOption)
            {
                case "1":
                    ShowEntries(entries);
                    break;
                case "2":
                    AddEntry(entries);
                    break;
                case "3":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void ShowEntries(List<JournalEntry> entries)
    {
        Console.WriteLine("\nJournal Entries");
        Console.WriteLine("==============================");
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }
        else
        {
            for (int i = 0; i < entries.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + entries[i].Text);
                Console.WriteLine("   " + entries[i].Date.ToString());
            }
        }
    }
    
    static void AddEntry(List<string> entries)
{
        string[] prompts = new string[] {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "hat was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        Random rand = new Random();
        int randomIndex = rand.Next(0, prompts.Length);

        Console.WriteLine("\nPrompt: " + prompts[randomIndex]);
        Console.WriteLine("\nEnter a new journal entry: ");
        string newEntry = Console.ReadLine();
        entries.Add(new JournalEntry(newEntry, DateTime.Now));
        Console.WriteLine("\nEntry added.");
    }


        class JournalEntry
        {
            public string Text { get; set; }
            public DateTime Date { get; set; }

            public JournalEntry(string text, DateTime date)
            {
                Text = text;
                Date = date;
            }
        }
}