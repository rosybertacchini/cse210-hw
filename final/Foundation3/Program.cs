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
            
            Reception er = new Reception();
            Lecutre   el = new Lecutre();
            Outdoor   eo = new Outdoor();
            
            //  Reception type event
            er.SetTitle("18th Food Festival");
            er.SetDescription("The best local restaurants, chefs, and food vendors in one place! food and drinks to attendees");
            er.SetDate("12/25/23");
            er.SetTime("09:15 AM");
            er.SetAddress(address1); 
            er.SetEmailRSVP("rsvp@gmail.com");
            events.Add(er);

            //  Outdoor type event
            eo.SetTitle("Boy Scouts Camping 2023");
            eo.SetDescription("Good opportunities for Cub Scouts through long-term camps");
            eo.SetDate("12/28/23");
            eo.SetTime("06:30 PM");
            eo.SetAddress(address3); 
            eo.SetWeather("Expecting snow storm, very Cold weather!!");
            events.Add(eo);

            //  Lecutre type event
            el.SetTitle("BYUI Women's Conference, 2023");
            el.SetDescription("Annual conference for BYUI for all women's students");
            el.SetTime("19:00");
            el.SetDate("12/31/23");
            el.SetAddress(address2); 
            el.SetSpeaker("Brother Christian Russembeger");
            el.SetMaxCapacity(12000);
            events.Add(el);
        }
        
    } // Main
}// Program