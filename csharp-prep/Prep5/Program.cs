// Rosy Bertacchini 

using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // task for this program:
        // DisplayWelcome - Displays the message, "Welcome to the Program!"
        // PromptUserName - Asks for and returns the user's name (as a string)
        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        // DisplayResult - Accepts the user's name and the squared number and displays them.

        DisplayWelcome();
        DisplayResult( PromptUserName() , PromptUserNumber()) ;

        // ---------------------------------------------------
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        }
        // ---------------------------------------------------
        static string PromptUserName(){
            Console.Write("Enter your name ");
            string name = Console.ReadLine();
            return name;
        }
        // ---------------------------------------------------
        static int PromptUserNumber(){
            Console.Write("Enter your favorite number ");
            string number = Console.ReadLine();
            return int.Parse(number);
        }
        // ---------------------------------------------------
        static int SquareNumber(int number){
            return number * number;
        }
        // ---------------------------------------------------
        static void DisplayResult(string user_name, int number){
            int SquareNum = SquareNumber(number);
            Console.WriteLine();
            Console.WriteLine($"User's name is {user_name} and the square of the favorite number is {SquareNum} ");
        }
        // ---------------------------------------------------

    }
}