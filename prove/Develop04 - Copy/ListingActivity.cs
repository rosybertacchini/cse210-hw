using System.Data;
using System.Security.AccessControl;

public class ListingActivity : Activity{

// attributes

        private List<string> _promptQuestions = new List<string>
       {
            "\t --- When have you felt the Holy Ghost in this month? ----",
            "\t --- When did you know that God love you? ----",
            "\t --- When you felt a deep spiritual connection or sense of divine presence in your life? ----",
            "\t --- How has your faith or spirituality played a role in providing comfort or guidance during challenging times in your life? ----",
            "\t --- Who are people that you appreciate? ----",
            "\t --- What are personal strengths of yours? ----",
            "\t --- Who are people that you have helped this week? ----",
            "\t --- When have you felt the Holy Ghost this month? ----",
            "\t --- Who are some of your personal heroes? ----"
        };
        private List<int> _promptQuestionsUsedInTheSession = new List<int> {};

    // constructors
        public ListingActivity (){

        }

    // setters and getters
        private string GetPromptQuestion(){
           return   _promptQuestions[GetRandomNumbrer(_promptQuestions.Count())];
        }

        // This code is to meet Exceeding Requirements on the following option:
        // “Make sure no random prompts/questions are selected until
        // they have all been used at least once in that session.”
        //**************************************************************************
        // For PromptsQuestion
       private void AddIndexPromptQuestionUsedInTheSession(int indexPrompt) {
                _promptQuestionsUsedInTheSession.Add(indexPrompt);
       }
        private Boolean  promptQuestionsIndexWasUsed(int indexPrompt ){
                int indexUsed = _promptQuestionsUsedInTheSession.FindIndex(i => i == indexPrompt);
                return  indexUsed < 0 ?  false : true;
        }
        private Boolean  allPromtQuestionsHasBeenUsed(){
                return  _promptQuestionsUsedInTheSession.Count() == _promptQuestions.Count() ?  true : false;
        }
        //**************************************************************************



    //methods

    
        private int GetRandomNumbrer(int maxNum){
            Random rnd = new Random();
            int num = rnd.Next(maxNum) ;
            return num;
        }


        public void  RunActivity(){
                // set initial values
                this.SetActivityName("Listing Activity");
                this.SetDescription("This activity will help you to reflect on the good things in your life by\r\n\t having you list as many things as you can in a certain area.");
                this.SetSecondsForAnimation(3);
                // initial values for _promptQuestionss are in the declaration                
                
                
                // wellcome
                this.DisplayStartingMessage(this.GetActivityName(),this.GetDescription());

                // ask duraation of activity
                Console.Write("\t How long in seconds, would you like for your session? ");
                string durationActivity = Console.ReadLine();
                this.SetDurationInSeconds(Convert.ToInt16(durationActivity));

                //calculate time immediately
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(this.GetDurationInSeconds());


                //start activity
                Console.Clear();
                Console.WriteLine("");
                
                Console.WriteLine("\t List as many responses you can to the following prompt:");
                Console.WriteLine("");
                //Console.WriteLine($"\t\t ->  {GetPromptQuestion()}");
                //Console.WriteLine("");


                // This code is to meet Exceeding Requirements on the following option:
                // “Make sure no random promptsQuestions are selected until they have all been used at least once in that session.”
                // ***************************************************************************
                // PROMPTS
                
                string thePrompt = GetPromptQuestion();
                int indexPrompt = _promptQuestions.IndexOf(thePrompt);    

                if (allPromtQuestionsHasBeenUsed()) {
                                // if all prompts has been used, clean the list _promptQuestionsUsedInTheSession and start over selecting random prompt
                                _promptQuestionsUsedInTheSession.Clear();
                                AddIndexPromptQuestionUsedInTheSession(indexPrompt);
                }
                else{
                        while (promptQuestionsIndexWasUsed(indexPrompt)) {
                                thePrompt = GetPromptQuestion();
                                indexPrompt = _promptQuestions.IndexOf(thePrompt); 
                        }
                        AddIndexPromptQuestionUsedInTheSession(indexPrompt); 
                }

                Console.WriteLine($"\t\t ->  {thePrompt}");
                Console.WriteLine("");
                // 
                // ***************************************************************************

                // get ready
                Console.Write("\t You may begin in ..... ");
                this.DisplayAnimation("numbers",GetSecondsForAnimation());

                String response = "";
                Console.WriteLine("");

               // startTime depends on how long the user inputs the response.
               // after each response, startTime is the current time\.

                while  (startTime < futureTime) {
                    Console.Write("\t\t > ");
                    response = Console.ReadLine();
                    startTime = DateTime.Now;
                }


                this.DisplayEndingMessage( this.GetEndingMsg() , this.GetActivityName() , this.GetDurationInSeconds());
                this.DisplayAnimation("spinners", GetSecondsForAnimation());


               
        } // End RunActivity


} // End Class