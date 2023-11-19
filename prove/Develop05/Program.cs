/* ********************************************************************************* */
// Rosy Bertacchini
// W10 Unit 05 Develop: Eternal Quest Program
// EXCEEDING REQUIREMENTS:  None.
//
//
/* ********************************************************************************* */

using System;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using Microsoft.Win32.SafeHandles;


class Program
{
    static void Main(string[] args)
    {
        // Instance
        List<Goal> goals  = new List<Goal>{};
        MyInterface i = new MyInterface();


        
        Global.totalPoints = 0;
        dynamic choice = "";
        Console.Clear();
        while (choice!= "6")  {
            DisplayTotalPoint();
            i.DisplayMenu();
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
                    PerformRecordEvent();
                    break;
                case "6": // Quit - End
                    // Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please select one option ");
                    break;
            }
        }


        // Functions for of the Menu options
        // ***************************************************************************
        void LoadTheGoals(){
            Console.WriteLine("");
            Console.Write("Please enter the name of the file to load ");// string fileName = Console.ReadLine();  AQUI y la siguiente
            string fileName = "goals.txt";
            while(i.ValidateStringInput(fileName)){
                Console.Write("Please enter the name of the file to load ");  fileName = Console.ReadLine();
            }

            string[] lines = System.IO.File.ReadAllLines(fileName);

            goals.Clear();
            Global.totalPoints = 0;

            int indexZero = 0;
            foreach (string line in lines) {
                string[] fields = line.Split(',');

                if (indexZero==0) {
                    Global.totalPoints = int.Parse(fields[0]);
                    indexZero = -1;
                }
                else { 
                    fields[0] =  fields[0].Remove(0,fields[0].IndexOf(":")+1);    // Remove the string that specify type of goal

                    string name = fields[0];
                    string desc = fields[1];
                    string amountPoints = fields[2];
                    Boolean  isCompleated = false;

                    switch ( line.Substring(0,line.IndexOf(":")) ) {
                        case "SimpleGoal" :
                            SimpleGoal sg = new SimpleGoal();

                            isCompleated = fields[3].Trim() == "true" ? true : false;                                     
                            sg.SetGoalName(name);
                            sg.SetGoalDescription(desc);
                            sg.SetAmountPoints(int.Parse(amountPoints));
                            sg.SetGoalIsCompleated(isCompleated);
                            goals.Add(sg);
                            break;
                        case "EternalGoal":
                            EternalGoal eg = new EternalGoal();

                            eg.SetGoalName(name);
                            eg.SetGoalDescription(desc);
                            eg.SetAmountPoints(int.Parse(amountPoints));
                            goals.Add(eg);
                            break;
                        case "CheckListGoal":
                            CheckListGoal clg = new CheckListGoal();
                             
                            isCompleated = fields[3] == "true" ? true : false;   
                            int timesForAccomplishGoal = int.Parse(fields[4]);
                            int timesAccomplished = int.Parse(fields[5]);
                            int bonus = int.Parse(fields[6]);

                            clg.SetGoalName(name);
                            clg.SetGoalDescription(desc);
                            clg.SetAmountPoints(int.Parse(amountPoints));
                            clg.SetGoalIsCompleated(isCompleated);
                            clg.SetTimesForAccomplishGoal(timesForAccomplishGoal);
                            clg.SetTimesAccomplished(timesAccomplished);
                            clg.SetBonus(bonus);
                            goals.Add(clg);

                            // if (isCompleated){
                            //     Global.totalPoints =  ((clg.GetAmountPoints() * clg.GetTimesAccomplished()) + clg.GetBonus())  ;
                            // } 
                            // else{
                            //     Global.totalPoints =  (clg.GetAmountPoints() * clg.GetTimesAccomplished());
                            // }                            

                            
                            break;
                        default:
                            Console.WriteLine("Cannot Identify type of goal! ");
                            break;
                    } // switch
                    
                }// else
            } // For Each
            Console.WriteLine($"The file {fileName} has been loaded!");
            Thread.Sleep(2000);
            Console.Clear();            
        } //LoadTheGoals
      
        // ---------------------------
        void SaveTheGoals(){
            Console.WriteLine("");
            Console.Write("Please enter the name of the file "); string fileName = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                int indexZero = 0;
                foreach (Goal g in goals){
                    if (indexZero==0) {
                        outputFile.WriteLine($"{Global.totalPoints} ");
                        indexZero = -1;
                    }
                    outputFile.WriteLine($"{g.BuildGoalString()} ");
                }
            }
            Console.WriteLine($"The file {fileName} has been saved!");
            Thread.Sleep(2000);
            Console.Clear();
        }
        // ---------------------------
        void PerformRecordEvent(){
            ListTheGoals();
            Console.WriteLine();
            Console.Write("What goal did you accomplish? "); string goalIndex = Console.ReadLine();
            int index  = int.Parse(goalIndex); index--;
            if (index >= 0 && index < goals.Count()){
                goals[index].RecordAnEvent();
            }
            else{
                Console.WriteLine("Select the correct goal number!");
            }
        }
        // ---------------------------
        void DisplayTotalPoint(){
        
        
            Console.WriteLine("");
            Console.WriteLine("=======================");
            // int total = 0;
            // foreach(Goal g in goals){
            //      total += g.CalculateTotalPointsOfTheGoal();
            // }
            // Console.WriteLine($"* You have {total} points. ");


            Console.WriteLine($"* You have {Global.totalPoints} points. ");
            
            Console.WriteLine("=======================");
        }
        // ---------------------------
        // int CalculatePoint(Goal g){
        //     Console.WriteLine( g.GetType().ToString() );
        //     int points = 0;
        //     switch ( g.GetType().ToString() ) {
            
        //     case "SimpleGoal":
        //     case "EternalGoal":
        //         points = g.GetAmountPoints();
        //         break;
        //     case "CheckListGoal":
        //         CheckListGoal clg  =  g;
        //         if (g.GetGoalIsCompleated()){
        //             points =  ((g.GetAmountPoints() * g.GetTimesAccomplished()) + g.GetBonus())  ;
        //         } 
        //         else{
        //             points =  (g.GetAmountPoints() * g.GetTimesAccomplished());
        //         }
        //         break;                
        //     }
        //     return points;
        // }
        // ---------------------------
        void ListTheGoals() {
            Console.Clear();
            int  x = 1;
            foreach (Goal goal in goals){
                Console.Write($"{x}.- ")  ;
                goal.DisplayGoal();
                x++;
            };
        }
        // ---------------------------
        void  CraeteNewGoal(){
                string usr_typeOfGoal ="";
                string name = "";
                string desc = "";
                string amountPoints = "";
                string timesForAccomplishGoal ="";
                string bonus  = "";

                i.presentGoalsMenu();
                Console.WriteLine();
                Console.Write("Which type of goal would you like to create?  "); usr_typeOfGoal = Console.ReadLine();

                switch (usr_typeOfGoal)
                {
                                case "1": // Simple Goal
                                    i.askCommonGoalQuestions(usr_typeOfGoal, ref name , ref desc, ref amountPoints);
                                    goals.Add(new SimpleGoal( name ,  desc,  int.Parse(amountPoints), false));
                                    break;
                                case "2": // Eternal Goal
                                    i.askCommonGoalQuestions(usr_typeOfGoal, ref name , ref desc, ref amountPoints);
                                    goals.Add(new EternalGoal(name ,  desc, int.Parse(amountPoints)));
                                    break;
                                case "3": // Check List Goal
                                    i.askCommonGoalQuestions(usr_typeOfGoal, ref name , ref desc, ref amountPoints);
                                    i.askCheckListGoalQuestions(ref timesForAccomplishGoal ,ref bonus );
                                    goals.Add(new CheckListGoal(name ,  desc,  int.Parse(amountPoints), false, int.Parse(timesForAccomplishGoal) , 0 , int.Parse(bonus) ));
                                    break;
                                default:
                                    Console.WriteLine("Please select 1,2 or 3 ");
                                break;
                }
                Console.Clear();

        } // End creatNewGoal


    } // End Main
} // End Program
