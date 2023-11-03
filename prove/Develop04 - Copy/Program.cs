using System;
using System.ComponentModel;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
       

        // instances
        BreathingActivity  breathingActivity  = new BreathingActivity(4,4);  //  the parameters are:  secodsToBreathIn and intsecodsToBreathOut
        ListingActivity    listingActivity    = new ListingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();



        String choice = "";
        Console.Clear();
        while (choice != "4") {

            DisplayMenu();

            choice = Console.ReadLine();
           
            switch(choice) 
            {
                case "1": // Start breathing activity
                    breathingActivity.RunActivity();
                   break;
                case "2": // Start reflecting activity
                    reflectingActivity.RunActivity();
                    break;
                case "3": // Start listing  activity
                    listingActivity.RunActivity();
                    break;
                case "4": // Quit - End
                    // Environment.Exit(0);
                     break;
                default:
                    Console.WriteLine("Please select the one option ");
                    break;
            }
        }
     

        void DisplayMenu()
        {
                Console.Clear();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Menu Options:"); 
                Console.WriteLine("");
                Console.WriteLine(" 1. Start breathing activity"); 
                Console.WriteLine(" 2. Start reflecting activity");                                           
                Console.WriteLine(" 3. Start listing  activity");    
                Console.WriteLine(" 4. Quity"); 
                Console.WriteLine("");                
                Console.WriteLine("----------------------------------");
                Console.WriteLine("");
                Console.Write("Select a choice from the menu:  ");
        }


    } // End Main
    
} // End Class