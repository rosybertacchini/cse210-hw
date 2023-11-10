using System.ComponentModel.DataAnnotations;

public class Goal {

// Attributes
// AQUI    ALGUNA VARIABLE DEBE SER PROTECTED

    protected string  _goalName = "";
	protected string  _goalDescription = "";
	protected int     _amountPoints = 0;
    protected  Boolean _goalCompleated = false;
    private int _totalAmountPoints= 0;  // AQUI verificar esto

// Constructors
    

// Setters and Getters
    public void SetGoalName(string goalName){
        _goalName = goalName;
    }
    public void SetGoalDescription(string goalDescription){
        _goalDescription = goalDescription;
    }
    public void SetAmountPoints(int amountPoints){
        _amountPoints = amountPoints;
    }
    public void SetGoalCompleated(Boolean goalCompleated){
             _goalCompleated = goalCompleated;

    }

    public string GetGoalName(){
        return _goalName ;
    }
    public string GetGoalDescription(){
        return _goalDescription;
    }
    public int  GetAmountPoints(){
        return _amountPoints;
        }
    public  Boolean GetGoalCompleated(){
            return _goalCompleated;
    }


//  Methods   

    public virtual int  CalculateTotalPoints(){
            return 0;
    }
    public void  RecordEvent(int typeOfGoal  ){

    }
    public virtual   void DisplayGoal(){
        string compleated = GetGoalCompleated() == true ? "X" : " ";
        Console.WriteLine($" [{compleated}] ->  {GetGoalName()} / {GetGoalDescription()} Points: {GetAmountPoints()}");
        Console.WriteLine("Yor total point are : 9999");   // AQUI calcular puntos
    }



} // End Class