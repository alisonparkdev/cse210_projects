using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = 1;

        while (newNumber != 0)
        {
    
            Console.Write("Type a number: ");
            string userNumber = Console.ReadLine();
            newNumber = int.Parse(userNumber);


            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
            
        }
     
    int sum = numbers.Sum();
    double avg = numbers.Average();
    int max = numbers.Max();

    Console.WriteLine($"The sum is {sum}.");
    Console.WriteLine($"The average is {avg}.");
    Console.WriteLine($"The largest number is {max}.");
    }
}