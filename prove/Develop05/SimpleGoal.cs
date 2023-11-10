public class SimpleGoal : Goal {

    protected int _totalAmountPoints= 0;

    
    public SimpleGoal(string goalName, string goalDescription, int amountPoints, Boolean  goalCompleated ){
        _goalName = goalName;
        _goalDescription = goalDescription;
        _amountPoints = amountPoints;
        _goalCompleated = goalCompleated;
    }




    protected int calculateTotalAmountPoints(){


        return 0;
    }






} // End Class