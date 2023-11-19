
class MyInterface
{
    // ---------------------------
    public  void askCommonGoalQuestions(string usr_typeOfGoal, ref string  name , ref string desc, ref string amountPoints){
            Console.Write("\t What is the name of the Goal? "); name = Console.ReadLine();
            Console.Write("\t What is a short description of it? ");  desc= Console.ReadLine();
            Console.Write("\t What is the amount of point associated with this goal? ");  amountPoints =  Console.ReadLine();
        }
    // --------------------------- 
    public void askCheckListGoalQuestions(ref string  timesForAccomplishGoal ,ref string bonus ){
            Console.Write("\t How many times does this goal need to be accomplished for a bonus? "); timesForAccomplishGoal = Console.ReadLine();
            Console.Write("\t What is the bonus for acomplishing it many times? ");  bonus = Console.ReadLine();
        }
    // ---------------------------    
    public void  presentGoalsMenu(){
            Console.Clear();
            Console.WriteLine("\t 1) Simple Goal");
            Console.WriteLine("\t 2) Eternal Goal");
            Console.WriteLine("\t 3) Check List Goal\r");
        }
    // --------------------------- 
    public void DisplayMenu(){   
            Console.WriteLine("");     
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
    // ---------------------------
    public  bool ValidateStringInput( string input){ 
         return string.IsNullOrEmpty(input);
    }
    // ---------------------------
    public  bool ValidateIntInputRange( string input, int start ,int end ){ 
         return  (int.Parse(input) >= start && int.Parse(input) <= end); 
    }
    // ---------------------------
} // End Class







