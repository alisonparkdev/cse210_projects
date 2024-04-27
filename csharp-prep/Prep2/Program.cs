using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {   
        
        string letterGrade = "A";
        

        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int userPercent = int.Parse(userGrade);

        if (userPercent >= 90)
        {
           letterGrade = "A";
            
        }
        else if (userPercent >= 80 && userPercent < 90)
        {
            letterGrade = "B";
            
        }
            
        else if (userPercent >= 70 && userPercent < 80)
        {
            letterGrade = "C";
            
        }
        else if (userPercent >= 60 && userPercent < 70)
        {
            letterGrade = "D";
            
        }
        else
        {
            letterGrade = "F";
            
        }

        Console.WriteLine($"Your grade is {letterGrade}");

        if (letterGrade == "A" || letterGrade == "B" || letterGrade == "C")
        {
            Console.WriteLine("You are passing the class. Congratulations!");
        }
        else
        {
            Console.WriteLine("Your grade needs improvement to pass the class. Keep trying. You can do it.");
        }
    }
}