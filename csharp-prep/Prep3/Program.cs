using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int chosenNumber = randomGenerator.Next(1, 11);
        int guessNumber = -1;

        while (guessNumber != chosenNumber)
        { 
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber < chosenNumber)
            {
            Console.WriteLine("Higher");
            }

            else if (guessNumber > chosenNumber)
            {
            Console.WriteLine("Lower");
            }
            else
            Console.WriteLine("You guessed it!");
        }

        
    }
}