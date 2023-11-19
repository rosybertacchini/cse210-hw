using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

public  abstract   class Goal {

// Attributes

    protected string   _goalName = "";
	protected string   _goalDescription = "";
	protected int      _amountPoints = 0;  // All type og goals have an amount of point to be eraned

// Constructors
    public Goal(){ }

// Setters
    public void SetGoalName(string goalName){
        _goalName = goalName;
    }
    public void SetGoalDescription(string goalDescription){
        _goalDescription = goalDescription;
    }
    public void SetAmountPoints(int amountPoints){
        _amountPoints = amountPoints;
    }
  
// Getters
    public string GetGoalName(){
        return _goalName ;
    }
    public string GetGoalDescription(){
        return _goalDescription;
    }
    public  int  GetAmountPoints(){
        return _amountPoints;
    }

// Abstract Methods   
//******************************************************************************

    public abstract string BuildGoalString();
   // public abstract  int CalculatePoint();
    public  abstract  void RecordAnEvent();
    public abstract void DisplayGoal();
   
  
} // End Class