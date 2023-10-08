// ***********************************************
// Rosy Bertacchini
// Unit 02 Develop: Journal Program
// ***********************************************

using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Initialized and create class instances
       
        Journal myJournal = new Journal();
       


        
        String choice = "";
        Console.Clear();
        while (choice != "5") {

            DisplayMenu();

            choice = Console.ReadLine();
           
            switch(choice) 
            {
                case "1": // Write
                    
                   myJournal.WriteEntry();
                   break;

                case "2": // Display
                   myJournal.DisplayEntries();
                    break;
                    
                case "3": // Load
                    Console.WriteLine("Please enter the name of the file ");
                    string fileNameLoad = Console.ReadLine();
                    myJournal.Load(fileNameLoad);

                    break;
                case "4": // Save

                    Console.WriteLine("Please enter the name of the file ");
                    string fileNameSave = Console.ReadLine();
                    myJournal.SaveEntries(fileNameSave);
                    break;

                case "5": // Quit - End
                    break;
                default:
                    Console.WriteLine("Please select the one option ");
                    break;
            }
        }
     



        // loop to ask


    void DisplayMenu()
    {

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Please select a choice");   
            Console.WriteLine("1.- Write");   
            Console.WriteLine("2.- Display");   
            Console.WriteLine("3.- Load");   
            Console.WriteLine("4.- Save");   
            Console.WriteLine("5.- Quit");  
            Console.WriteLine("");
            Console.WriteLine("What would you like to do? ");       
            Console.WriteLine("----------------------------------");
    }

    

    }
}