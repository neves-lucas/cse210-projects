// EXCEEDS CORE REQUIREMENTS - Creativity Features:
// 1. LEVEL SYSTEM: The program tracks the player's level based on their score.
//    Levels include Beginner, Bronze, Silver, Gold, Diamond, and Legend.
//    The current level is displayed alongside the score and after recording events.
// 2. NEGATIVE GOALS: A new goal type called "Negative Goal" allows the user to
//    track bad habits. When a negative event is recorded, points are deducted
//    from the player's score instead of added. These goals are never marked complete.
// 3. ALREADY COMPLETED CHECK: When recording an event, the program checks if a
//    simple or checklist goal is already completed and informs the user instead
//    of awarding duplicate points.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}