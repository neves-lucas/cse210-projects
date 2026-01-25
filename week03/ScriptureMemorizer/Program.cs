// Scripture Memorizer Program
// This program helps users memorize scriptures by progressively hiding words.
//
// EXCEEDING REQUIREMENTS:
// - The random word selection only selects from words that are not already hidden
//   (stretch challenge from the assignment).

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture with a reference and text
        // Using Proverbs 3:5-6 as an example with a verse range
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths";
        
        Scripture scripture = new Scripture(reference, scriptureText);

        // Main program loop
        while (!scripture.IsCompletelyHidden())
        {
            // Clear the console and display the scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            
            // Get user input
            string input = Console.ReadLine();
            
            // Check if user wants to quit
            if (input.ToLower() == "quit")
            {
                return;
            }

            // Hide a few random words (3 at a time)
            scripture.HideRandomWords(3);
        }

        // Display the final scripture with all words hidden
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("All words are now hidden. Great job memorizing!");
    }
}