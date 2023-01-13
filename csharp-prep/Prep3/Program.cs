using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 10);
        Console.WriteLine("The magic number is between 1 and 10. ");

        Console.WriteLine("What is your guess? ");
        string guessInput = Console.ReadLine();
        int guessNumber = int.Parse(guessInput);

        do
        {
            Console.WriteLine("Higher.");
            Console.WriteLine();
            Console.WriteLine("What is your guess? ");
            guessInput = Console.ReadLine();
            guessNumber = int.Parse(guessInput);

        }   while (guessNumber < magicNumber);

        do
        {
            Console.WriteLine("Lower.");
            Console.WriteLine();
            Console.WriteLine("What is your guess? ");
            guessInput = Console.ReadLine();
            guessNumber = int.Parse(guessInput);

        }   while (guessNumber > magicNumber);
  
        if (guessNumber == magicNumber)
        {
            Console.WriteLine("Congratulations! You guessed it!");
        }

    }
}