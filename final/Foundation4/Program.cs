/* ************************************************************************************* */
/* Rosy Bertacchini
/* Final Project: POLIMORPHISIM
/*
/* This program apply the concept of POLIMORPHISIM in their classes
/* ************************************************************************************* */

using System;
using System.Data;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        // Instances
        List<Activity> activities = new List<Activity>();

        // Create some events 
        CreateEvents();

        // Get summary info of the of each event
        Console.Clear();
        Console.WriteLine("------------------------------------------------------------------------------------------------------");
        foreach(Activity a in activities){
            a.GetSummary();
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
        }


        // ************************************     CREATE DATA   ( 3 Events )   ***********************************************
        void CreateEvents(){
            //4th August 2021, 23:58:30:999 (hours:minutes:seconds:milliseconds)
            var eventDate1 = new DateTime(2022,8,4,23,12,01,001); 
            var eventDate2 = new DateTime(2023,10,10,12,01,001); 
            var eventDate3 = new DateTime(2024,11,4,12,01,001); 

            Running activityRunning = new( 4.8 , eventDate1 , 30 );  // distance, date, length (in minutes)
            Cycling activityCycling = new( 2 , eventDate2 , 45);     // speed, date, length (in minutes)
            Swimming activitySwimming = new( 10 , eventDate3 , 30 ); // numberOfLaps, date, length (in minutes)

            activities.Add(activityRunning);
            activities.Add(activityCycling);
            activities.Add(activitySwimming);
        }


    } // Main
} // Program