using System;

class Program
{
    static void Main(string[] args)
    {   
        DisplayWelcome();
        string name = PromptUserName();
        int favNumber = UserNumber();
        int square = SquareNumber(favNumber);
        DisplayResult(name, square);

        static string DisplayWelcome ()
        {
            string welcome = "Welcome to the Program";
            return welcome;
        
        }

        static string PromptUserName ()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int UserNumber ()
        {
            Console.Write("What is your favorite number? ");
            int favNumber = int.Parse(Console.ReadLine());
            return favNumber;
        }
        static int SquareNumber (int favNumber)
        {
            int square = favNumber * favNumber;
            return square;
        }
        static void DisplayResult (string userName, int square)
        {
            Console.WriteLine($"{userName}, your number squared is {square}.");
        }



    }
}
