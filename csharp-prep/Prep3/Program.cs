// Author : Rosy Bertacchini

using System;

class Program
{
    static void Main(string[] args)
    {
        // generate random number between 0-10
        Random rnd = new Random();
        int magin_number = rnd.Next(11)   ;

        
        Console.WriteLine("Guessing the magic number between (0-10) ");
        Console.WriteLine("-------------------------");

        string response = "";
        do
        {
            int guess_number = 0;
            int guess_times = 0;
 
            do{
                // Ask user to guess the magic number
                Console.Write("What is your guess? ");
                string number_str = Console.ReadLine();
                guess_number = int.Parse(number_str);
                //Console.WriteLine($"you guess is {guess_number} - {magin_number}" );

                guess_times += 1;

                //Does the user guess the number?
                if (guess_number != magin_number)
                {
                    // Give to the user a clue to guess magic number
                    if (guess_number > magin_number) {
                        Console.WriteLine($"The magic number is less then {guess_number}");
                    }
                    else {
                        Console.WriteLine($"The magic number is grater then {guess_number}");
                    }
                }

            } while (guess_number != magin_number);

            Console.WriteLine($"Congratulations,  you guess in {guess_times} times");


            Console.Write("Do you want to continue? (yes/no) ");
            response = Console.ReadLine();
            Console.WriteLine("-------------------------");
        } while (response == "yes");
 
    }
}