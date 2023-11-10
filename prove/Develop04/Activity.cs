// **************************************************************************************
// Activity class is the BASE CLASS  for Breathing , Reflecting and Listing Activities
// **************************************************************************************

using System.Security.AccessControl;

public class Activity {

 //atributes
    private string _activityName  = "";
    private string _description = "";
    private string _endingMsg  = "";    
    private int _durationInSeconds = 0;  // OBSERVATION: you got 0 point because you did not make this variable PROTECTED
    private  string _animationType =  "";
    private int _seconds_for_animation = 0;



    // constructors

    public Activity(){

    }
    public Activity(string activityName, string description, int durationInSeconds, string animationType)
    {
        _activityName = activityName;
        _description = description;
        _durationInSeconds = durationInSeconds;
        _animationType = animationType;
    }


// setters and gettres
    public void SetActivityName(string activityName){
        _activityName = activityName;
    }
    public void SetDescription(string description){
        _description = description;
    }
    public void SetDurationInSeconds(int durationInSeconds){
        _durationInSeconds = durationInSeconds;
    }
    public void SetAnimationType(string animationType){
        _animationType = animationType;
    }

    public  void SetEndingMsg(string endingMsg)  {
         _endingMsg = endingMsg;
     }

    public void SetSecondsForAnimation(int secondsForAnimation){
             _seconds_for_animation = secondsForAnimation;
    }


    public string GetActivityName(){
        return _activityName ;
    }
    public string GetDescription(){
        return _description ;
    }
    public string GetEndingMsg(){
        return _endingMsg ;
    }
    public int GetDurationInSeconds(){
        return _durationInSeconds;
    }

     public int GetSecondsForAnimation(){
             return _seconds_for_animation;
     }  


//  methods
    public  void DisplayStartingMessage(string activityName , string description){
        Console.Clear();
        Console.WriteLine($"\t Welcome to {activityName} ");
        Console.WriteLine("");
        Console.WriteLine($"\t {description} ");
        Console.WriteLine("");
    }

    public void DisplayEndingMessage( string endingMsg,string activityName , int  durationInSeconds  ){
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write($"\tWell Done!\r\n\tYou have compleated another {endingMsg} {activityName} of {durationInSeconds} seconds ");
    }

    public  void DisplayAnimation( string animationType, int seconds ){

        switch (animationType) {
            case "numbers" :
                ;
                for(int i = seconds ; i > 0  ;i-- ){
                    Console.Write(i);
                    Thread.Sleep(1000);
                    if (i>9){  // two digits
                        Console.Write("\b\b  \b\b");   
                    }
                    else { // 1 digit
                        Console.Write("\b \b");        
                    }
                }
            break;

            case "spinners" :
                string spinner = "|/-|/-\\";
                int x = 0;
                while (x < seconds )  {
                    foreach(char c in spinner){
                        Console.Write(c);
                         Thread.Sleep(1000);
                        Console.Write("\b \b");
                        x++;
                    }
                    x++;  
                }
            break;
        }

    } // End DisplayAnimatio



} // End Class