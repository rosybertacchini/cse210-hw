public class SimpleGoal : Goal {

    protected  Boolean _goalIsCompleated ;

// Constructors
    public SimpleGoal(){ }        
    public SimpleGoal(string goalName, string goalDescription, int amountPoints, Boolean goalIsCompleated ){
        _goalName = goalName;
        _goalDescription = goalDescription;
        _amountPoints = amountPoints;
        _goalIsCompleated = goalIsCompleated;
    }
  
// Setters
    public void  SetGoalIsCompleated(Boolean goalIsCompleated){
            _goalIsCompleated = goalIsCompleated;
    }
// Getters
     public  Boolean GetGoalIsCompleated(){
            return _goalIsCompleated;
    } 


// Override ABSTRACT Methods  Methods

    //******************************************************************************
    public override string BuildGoalString(){
        return string.Concat(GetType().FullName,":", GetGoalName(),",", GetGoalDescription(),",", GetAmountPoints().ToString(),",", GetGoalIsCompleated() ? "true" : "false" );
    }
    /* - - - - - - - - - - - */
    public  override  void  RecordAnEvent(){
         if( !GetGoalIsCompleated() ) {
            SetGoalIsCompleated(true);
            Console.WriteLine($"Congratulation! You have earned {GetAmountPoints()} points!  ");  
            Global.totalPoints +=  GetAmountPoints();                      
        }    
         else {
            Console.WriteLine("That goal was already compleated!, select another goal!");
        }
    }  
    /* - - - - - - - - - - - */
    public override void DisplayGoal(){ //aqui quite virtual
        string compleated = GetGoalIsCompleated() == true ? "X" : " ";
        //Console.WriteLine($" [{compleated}]   {GetGoalName()} ({GetGoalDescription()}),  Points: {GetAmountPoints()}");
        Console.WriteLine($"[{compleated}] {GetGoalName()} ({GetGoalDescription()})({GetAmountPoints()}) -> ({GetType().FullName})");
    } 
    //******************************************************************************


} // End Class