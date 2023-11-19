public class EternalGoal : Goal {


// Constructors
    public EternalGoal(){ }   
    public EternalGoal(string goalName, string goalDescription, int amountPoints){
        _goalName = goalName;
        _goalDescription = goalDescription;
        _amountPoints = amountPoints;
    }


// Override ABSTRACT Methods  Methods

    //******************************************************************************
    public override string BuildGoalString(){
        return string.Concat(GetType().FullName,":", GetGoalName(), "," , GetGoalDescription(), ",", GetAmountPoints().ToString() );
    }
    /* - - - - - - - - - - - */
    public  override  void RecordAnEvent( ){
        Console.WriteLine($"Congratulation! You have earned {GetAmountPoints()} points!  ");   
         Global.totalPoints += GetAmountPoints();                     
    }    
    /* - - - - - - - - - - - */
    public override void DisplayGoal(){ //aqui quite virtual
        Console.WriteLine($"[ ] {GetGoalName()} ({GetGoalDescription()})({GetAmountPoints()}) -> ({GetType().FullName})");
    } 
    //******************************************************************************


}  // End Class