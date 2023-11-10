/* ********************************************************************************* */
// Rosy Bertacchini 
// W09 xxxxxxxxxxxxxxxxxxxxxxxxxxx
// EXCEEDING REQUIREMENTS: 
//    
//    
//   
/* ********************************************************************************* */

using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
// using System.IO.StreamWriter;    // to write into the file

class Program
{
    static void Main(string[] args)
    {
        // Instance  class Goal
        List<Goal> ListOfGoals = new List<Goal> { };

        String choice = "";
        Console.Clear();
        while (choice != "6")
        {
            DisplayMenu();
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1": // 1. Create New Goal 
                    CraeteNewGoal();
                    break;
                case "2": // 2. List Goals
                    ListTheGoals();
                    break;
                case "3": // 3. Save Goals
                    SaveTheGoals();
                    break;
                case "4": // 4. Load Goals
                    LoadTheGoals();
                    break;
                case "5": // 5. Record Event
                    RecordAnEvent();
                    break;
                case "6": // Quit - End
                        // Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please select the one option ");
                    break;
            }
        }


        // function for the main menu
         /* ************************************************************** */
         /* ************************************************************** */
        void RecordAnEvent(){
            
        }

        void SaveTheGoals(){

        }
   
        void LoadTheGoals(){

        }

        void ListTheGoals()
        {
            foreach (Goal g in ListOfGoals)
            {
                Console.Clear();
                g.DisplayGoal();
            };
        }

        void CraeteNewGoal(){

            String typeOfGoal = "";
            string name = "";
            string desc = "";
            string points = "";

            presentGoalsMenu();
            askCommonGoalQuestions(ref typeOfGoal, ref name, ref desc, ref points );
            switch (typeOfGoal)
            {
                case "1": // Simple Goal
                    ListOfGoals.Add(new SimpleGoal(name, desc, int.Parse(points), false));
                    break;
                case "2": // Eternal Goal
                    ListOfGoals.Add(new EternalGoal(name, desc, int.Parse(points)));
                    break; 
                case "3": // Check List Goal
                    string timesForAccomplishGoal = "";
                    string timesAccomplished = "";
                    Boolean goalCompleated  = false;

                    askCheckListGoalQuestions(ref timesForAccomplishGoal , ref timesAccomplished);
                    ListOfGoals.Add(new CheckListGoal(name, desc, int.Parse(points), goalCompleated  , int.Parse(timesForAccomplishGoal) ,  int.Parse(timesAccomplished  )));
                    break;
                default:
                    Console.WriteLine("Please select 1,2 or 3 ");
                    break;
            }
            Console.Clear();
        }
        /* ************************************************************** */
        /* ************************************************************** */        

        // other funtions 


        void askCheckListGoalQuestions(ref string timesForAccomplishGoal , ref string  timesAccomplished){
            Console.Write("\r\t How many times does this goal need to be accomplished for a bonus?  "); timesForAccomplishGoal = Console.ReadLine();
            Console.Write("\r\t What is the bonus for acomplishing it many times?  "); timesAccomplished = Console.ReadLine();

        }

        void  presentGoalsMenu(){
            Console.Clear();
            Console.WriteLine("\t 1) Simple Goal");
            Console.WriteLine("\t 2) Eternal Goal");
            Console.WriteLine("\t 3) Check List Goal\r");
        }
        void askCommonGoalQuestions(ref string typeOfGoal,ref  string name, ref string desc, ref  string points ){
            Console.Write("\r\t Which type of goal would you like to create?  "); typeOfGoal = Console.ReadLine();
            Console.Write("\t What is the name of the Goal? ");  name = Console.ReadLine();
            Console.Write("\t What is a short description of it? ");  desc = Console.ReadLine();
            Console.Write("\t What is the amount of point associated with this goal? ");  points = Console.ReadLine();
        }

        void DisplayMenu()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Envent");
            Console.WriteLine(" 6. Quit");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            Console.Write("Select a choice from the menu:  ");
        }



    } // End Main 

} // End Program
