// EXCEEDS CORE REQUIREMENTS - Creativity Features:
// 1. ACTIVITY LOG: The program keeps track of how many times each activity
//    has been performed during the session and displays this information
//    in the menu. This helps users monitor their mindfulness progress.
// 2. VIEW ACTIVITY LOG OPTION: Users can view a summary of all activities
//    performed in the current session, including total time spent on each.
// 3. TOTAL SESSION TIME: The program tracks and displays the total time
//    spent across all activities in the current session.

using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        
        // Activity tracking for exceeding core requirements
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;
        int totalBreathingTime = 0;
        int totalReflectingTime = 0;
        int totalListingTime = 0;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine($"  1. Start breathing activity (completed {breathingCount} times)");
            Console.WriteLine($"  2. Start reflecting activity (completed {reflectingCount} times)");
            Console.WriteLine($"  3. Start listing activity (completed {listingCount} times)");
            Console.WriteLine("  4. View activity log");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    breathingCount++;
                    totalBreathingTime += breathingActivity.GetDuration();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    reflectingCount++;
                    totalReflectingTime += reflectingActivity.GetDuration();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    listingCount++;
                    totalListingTime += listingActivity.GetDuration();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("===== SESSION ACTIVITY LOG =====\n");
                    Console.WriteLine($"Breathing Activity:  {breathingCount} times, {totalBreathingTime} seconds total");
                    Console.WriteLine($"Reflecting Activity: {reflectingCount} times, {totalReflectingTime} seconds total");
                    Console.WriteLine($"Listing Activity:    {listingCount} times, {totalListingTime} seconds total");
                    Console.WriteLine($"\nTotal session time: {totalBreathingTime + totalReflectingTime + totalListingTime} seconds");
                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}