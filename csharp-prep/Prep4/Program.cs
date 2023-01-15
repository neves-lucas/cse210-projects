using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            numbers.Add(number);

        }

        int sumAll = numbers.Sum();
        double average = numbers.Average();
        int largestNumber = numbers.Max();
        Console.WriteLine($"The sum is: {sumAll}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}