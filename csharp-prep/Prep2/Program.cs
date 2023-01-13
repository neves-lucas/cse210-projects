using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        string letter = "";
        string gradesign = "-";
        int grade_percentage = int.Parse(userInput);

        if (grade_percentage >= 90)
            {
                letter = "A";
            }
        else if (grade_percentage >= 80)
            {
                letter = "B";
            }
        else if (grade_percentage >= 70)
            {
                letter = "C";
            }
        else if (grade_percentage >= 60)
            {
                letter = "D";
            }
        else
            {
                letter = "F";
            }

        if (grade_percentage / 10 >= 7)
        {
            gradesign = "+";
        }
        else if (grade_percentage / 10 < 3)
        {
            gradesign = "-";
        }
        else
        {
            gradesign = "";
        }

        Console.WriteLine($"Your grade is {letter}{gradesign}");

        if (grade_percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you didn't pass. Keep determined and you will get it!");
        }
    }
}