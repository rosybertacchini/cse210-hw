public class CheckListGoal : Goal {

    protected int _timesForAccomplishGoal = 0;
    protected int _timesAccomplished = 0;
    protected int _bonus = 0;
    protected  Boolean _goalIsCompleated ;

// Construtors
    public CheckListGoal(){ }
    
    public CheckListGoal(string goalName, string goalDescription, int amountPoints, Boolean goalIsCompleated ,  int timesForAccomplishGoal , int timesAccomplished , int  bonus )  {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _amountPoints = amountPoints;
        _goalIsCompleated = goalIsCompleated;

        _timesForAccomplishGoal = timesForAccomplishGoal;
        _timesAccomplished = timesAccomplished;
        _bonus = bonus;
    }

// Setters 
    public void SetTimesForAccomplishGoal(int timesForAccomplishGoal){
        _timesForAccomplishGoal = timesForAccomplishGoal;
    }
    public void SetTimesAccomplished(int timesAccomplished){

        _timesAccomplished += timesAccomplished;
    }
    public void SetBonus(int bonus){
        _bonus = bonus;
    }
    public void  SetGoalIsCompleated(Boolean goalIsCompleated){
            _goalIsCompleated = goalIsCompleated;
    }    

// Getters
    public int  GetTimesForAccomplishGoal(){
        return _timesForAccomplishGoal ;
    }
    public int  GetTimesAccomplished(){
        return _timesAccomplished ;
    }
    public int GetBonus(){
        return _bonus;
    }
    public  Boolean GetGoalIsCompleated(){
            return _goalIsCompleated;
    } 



// Override ABSTRACT Methods  Methods

    //******************************************************************************
    public override string BuildGoalString(){
        return string.Concat(GetType().FullName,":", GetGoalName(),",", GetGoalDescription(),",", GetAmountPoints().ToString(),",", GetGoalIsCompleated() ? "true" : "false",",", GetTimesForAccomplishGoal() ,",", GetTimesAccomplished(),",", GetBonus() );
    }
    /* - - - - - - - - - - - */
    public  override  void RecordAnEvent( ){
         if( !GetGoalIsCompleated() ) {
             SetTimesAccomplished(1);
            if (GetTimesAccomplished() == GetTimesForAccomplishGoal()) {
                    SetGoalIsCompleated(true);
                    Console.Write($"Congratulation! You have earned {GetAmountPoints()} points!  ");      
                    Console.WriteLine($"... and a Bonus of {GetBonus()} points!  ");  
                    Global.totalPoints += GetAmountPoints()  + GetBonus();
            }
            else {
                    Console.WriteLine($"Congratulation! You have earned {GetAmountPoints()} points!  "); 
                    Global.totalPoints +=  GetAmountPoints();  
            }
        }    
         else {
            Console.WriteLine("That goal was already compleated!, select another goal!");

        }
    }
    /* - - - - - - - - - - - */     
    public override void DisplayGoal(){ 
        string compleated = GetGoalIsCompleated() == true ? "X" : " ";
        Console.WriteLine($"[{compleated}] {GetGoalName()} ({GetGoalDescription()})({GetAmountPoints()})) -- Currently compleated: {GetTimesAccomplished()}/{GetTimesForAccomplishGoal()} -> ({GetType().FullName})");   
    }  
    //******************************************************************************  


}  // End Class