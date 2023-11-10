public class CheckListGoal : Goal {

    protected int _timesForAccomplishGoal = 0;
    protected int _timesAccomplished = 0;




// Construtors
    public CheckListGoal(string goalName, string goalDescription, int amountPoints, Boolean  goalCompleated , int timesForAccomplishGoal, int timesAccomplished){
        _goalName = goalName;
        _goalDescription = goalDescription;
        _amountPoints = amountPoints;
        _goalCompleated = goalCompleated;
        _timesForAccomplishGoal = timesForAccomplishGoal;
        _timesAccomplished = timesAccomplished;
    }


// Setters and Getters




//  ListOfGoals.Add(new CheckListGoal(name, desc, int.Parse(points), false, int timesForAccomplishGoal , int timesAccomplished  ));
              
// Methods

    public   override  void  DisplayGoal(){
        string compleated = GetGoalCompleated() == true ? "X" : " ";
        Console.WriteLine($" [{compleated}] ->  {GetGoalName()} / {GetGoalDescription()} Points: {GetAmountPoints()}");
        Console.WriteLine("Yor total point are : 9999");   //calcular puntos
    }




}  // End Class