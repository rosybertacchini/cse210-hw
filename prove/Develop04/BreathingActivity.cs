
using System.Data;
using System.Security.AccessControl;

public class BreathingActivity : Activity {
 
       
// attributes 
       private int _seconds_for_breathing_in_activity = 0;
       private int _seconds_for_breathing_out_activity = 0;


// constructors
        public  BreathingActivity(){

        }
        public  BreathingActivity(int secodsToBreathIn , int intsecodsToBreathOut){
            this.SetSecondsForBreathingInActivity(secodsToBreathIn);
            this.SetSecondsForBreathingOutActivity(intsecodsToBreathOut);
        }        


// // setters and getters

        private void SetSecondsForBreathingInActivity(int secondsForBreathingInActivity){
             _seconds_for_breathing_in_activity = secondsForBreathingInActivity;
        }
        private void SetSecondsForBreathingOutActivity(int secondsForBreathingOutActivity){
             _seconds_for_breathing_out_activity = secondsForBreathingOutActivity;
        }

        private Int32 GetSecondsForBreathingInActivity(){
            return  _seconds_for_breathing_in_activity ;
        }
        private int GetSecondsForBreathingOutActivity(){
            return  _seconds_for_breathing_out_activity ;
        }        

//  methods

    public void RunActivity(){
        // set initial values
        this.SetActivityName("Breathing Activity");
        this.SetDescription("Ths activity will help you to relax by walking your through breathing in\r\n\t and out slowly. Clear your mind and focus  on your brathing.");
        this.SetSecondsForAnimation(3);  
        // SetSecondsForBreathingInActivity and  SetSecondsForBreathingOutActivity are parametters of one of the constructors
        // see instance in the  program.cs


        // wellcome      
        this.DisplayStartingMessage(this.GetActivityName(),this.GetDescription());

        // ask duration of activity
        string  durationActivity = "";
        Console.Write("\t How long in seconds, would you like for your session? ");
        durationActivity = Console.ReadLine();
        this.SetDurationInSeconds(Convert.ToInt16(durationActivity));
        
        //calculate time immediately
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(this.GetDurationInSeconds());

        // get ready
        Console.Clear();
        Console.Write("\t Be ready for the activity..... ");
        this.DisplayAnimation("numbers",GetSecondsForAnimation());

        //start activity
        Console.WriteLine("");
        while ( startTime <= futureTime){

            // startTime is varying according to the value of  _seconds_for_breathing_in_activity and  _seconds_for_breathing_out_activity
            // if the "left time" in startTime it is not enough for another breath in or out, the activity ends.

            if (startTime.AddSeconds(_seconds_for_breathing_in_activity) < futureTime) {
                Console.WriteLine("");
                Console.Write("\t\t Breath in ... ");
                this.DisplayAnimation("numbers",  GetSecondsForBreathingInActivity() );  
                startTime = startTime.AddSeconds( GetSecondsForBreathingInActivity() );
                if (startTime.AddSeconds( GetSecondsForBreathingOutActivity()) < futureTime) {
                    Console.WriteLine("");
                    Console.Write("\t\t Now Breath out ... ");
                    this.DisplayAnimation("numbers",  GetSecondsForBreathingOutActivity() );
                    startTime = startTime.AddSeconds( GetSecondsForBreathingOutActivity());
                } 
                else{
                    startTime = startTime.AddSeconds( GetSecondsForBreathingOutActivity());
                }
            }
            else{
                    startTime = startTime.AddSeconds( GetSecondsForBreathingInActivity() );
                }
        
        }    
        
        this.DisplayEndingMessage( this.GetEndingMsg() , this.GetActivityName() , this.GetDurationInSeconds());
        this.DisplayAnimation("spinners", GetSecondsForAnimation());

    } // End RunActivity



} // End class