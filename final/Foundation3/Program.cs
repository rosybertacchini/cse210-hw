/* ************************************************************************************* */
/* Rosy Bertacchini
/* Final Project: INHERITANCE
/*
/* This program apply the concept of INHERITANCE in their classes
/* ************************************************************************************* */


using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // Instances
        List<Event> events = new List<Event>();
        
        // Create Events Data
        CreateDataEvents();

        // For each event call the 3 different methods,  to generete the three different messages.
        int i = 1;
        Console.Clear();
        Console.WriteLine("------------------------------------------------------------------------------");
        foreach(Event e in events){
                Console.ResetColor();
                Console.WriteLine($"[Event No {i}] [{e.GetType().ToString()}]\n\n");

                // Display standard message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"* STANDARD MESSAGAE:\n");
                e.DisplayStandardMessage();
                
                // Display full message
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\n\n* FULL DETAIL MESSAGAE:\n");
                e.DisplayFullMessage();

                // Display shotr message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\n* SHORT MESSAGAE:\n");
                e.DisplayShortShortMessage(e);
                Console.WriteLine("----------------------------------------------------------------------------");
                i++;
        } // foreach
        Console.ResetColor();
        


        // ************************************     CREATE DATA  ( 3 Activities )     ***********************************************
        void CreateDataEvents(){
            Address address1 = new Address("123 Main St", "Chula Vista", "CA", 12345, "US");
            Address address2 = new Address("456 Oak St", "Rigby", "ID", 67890, "US");
            Address address3 = new Address("381-383 Avenue Louise", "Brussels", "", 1050, "BELGIUM");
            
            Reception er = new Reception("18th Food Festival","The best local restaurants, chefs, and food vendors in one place! food and drinks to attendees","12/25/23","09:15 AM",address1,"rsvp@gmail.com");
            Lecutre   el = new Lecutre("BYUI Women's Conference, 2023","Annual conference for BYUI for all women's students","12/31/23","19:00",address2,"Brother Christian Russembeger",12000);
            Outdoor   eo = new Outdoor("Boy Scouts Camping 2023","Good opportunities for Cub Scouts through long-term camps","12/28/23","06:30 PM",address3,"Expecting snow storm, very Cold weather!!");
          
            events.Add(er);
            events.Add(eo);
            events.Add(el);
        }
        
    } // Main
}// Program