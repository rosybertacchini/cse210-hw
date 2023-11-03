
using System.Data;
using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity : Activity{

// attributes 
        private int _seconds_for_reflecting_activity = 0;

        private List<string> _prompts = new List<string>
       {
            "\t --- Think of a time when you stood up for someone else ----",
            "\t --- Think of a time when you did something really difficult. ----" ,
            "\t --- Think of a time when you helped someone in need. ----",
            "\t --- Think of a time when you did something truly selfless. ----",
            "\t --- Think a story about a time when you stepped out of your comfort zone and grew as a result. ----",
            "\t --- Think a moment when you faced a tough decision and how you handled it. ----",
            "\t --- Recall a story of an obstacle you overcame that made you feel proud. ----",
            "\t --- Think of an experience that required you to be resourceful and creative in finding a solution. ----",
            "\t --- Think a difficult task or project you undertook and the lessons you learned from it. ----",
            "\t --- Think about a time when you persevered through adversity and emerged stronger. ----"

        };
       private List<string> _questions = new List<string>
       {
            "\t\t How did you feel when it was complete? ",
            "\t\t Why was this experience meaningful to you? " ,
            "\t\t Have you ever done anything like this before? ",
            "\t\t How did you get started? ",
            "\t\t What made this time different than other times when you were not as successful? ",
            "\t\t What is your favorite thing about this experience? ",
            "\t\t What could you learn from this experience that applies to other situations? ",
            "\t\t What did you learn about yourself through this experience? ",
            "\t\t How can you keep this experience in mind in the future? ",
            "\t\t Did your resilience and determination grow? ",
            "\t\t how did your problem-solving skills come into play? "
        };

        private List<int> _promptsUsedInTheSession = new List<int> {};
        private List<int> _questionsUsedInTheSession = new List<int> {};


// constructors
        public ReflectingActivity() {

        }


// setters and getters

        private void SetSecondsForReflectingActivity(int secondsForReflectingActivity){
             _seconds_for_reflecting_activity = secondsForReflectingActivity;
        }
        private string GetPrompt(){
                return _prompts[GetRandomNumbrer(_prompts.Count())];
        }
        private string GetQuestion(){
                return   _questions[GetRandomNumbrer(_questions.Count())];
        } 
        private int GetSecondsForReflectingActivity(){
         return _seconds_for_reflecting_activity ;
        }       


//  methods

        private int GetRandomNumbrer(int maxNum){
            Random rnd = new Random();
            //int num = rnd.Next(0,12) ;
            int num = rnd.Next(0,maxNum--) ;
            return num;
        }

        // This code is to meet Exceeding Requirements on the following option:
        // “Make sure no random prompts/questions are selected until
        // they have all been used at least once in that session.”
        //**************************************************************************

        // FOR PROMPTS
       private void AddIndexPromptUsedInTheSession(int indexPrompt) {
                _promptsUsedInTheSession.Add(indexPrompt);
       }
        private Boolean  IsThisPromptIndexUsed(int indexPrompt ){
                int indexFound = _promptsUsedInTheSession.FindIndex(i => i == indexPrompt);
                return  indexFound < 0 ?  false : true;
        }
        private Boolean  allPromtsHasBeenUsed(){
                return  _promptsUsedInTheSession.Count() == _prompts.Count() ?  true : false;
        }


        // FOR QUESTIONS
       private void AddIndexQuestionUsedInTheSession(int indexQuestion) {
                _questionsUsedInTheSession.Add(indexQuestion);
       }
        private Boolean  IsThisQuestionIndexUsed(int indexQuestion ){
                int indexFound = _questionsUsedInTheSession.FindIndex(i => i == indexQuestion);
                return  indexFound < 0 ?  false : true;
        }
        private Boolean  allQuestionsHasBeenUsed(){
                return  _questionsUsedInTheSession.Count() == _questions.Count() ?  true : false;
        }

        //**************************************************************************


        public void RunActivity(){

                // set initial values
                this.SetActivityName("Refleacting Activity");
                this.SetDescription("This activity will help you to reflect on times in  your life  when you have shown \r\n\t strength and resiliance. This will help you to recognize the power you have and how you\r\n\t can you it in other aspects of your life");
                this.SetSecondsForAnimation(3);     
                this.SetSecondsForReflectingActivity(2);
                // initial values for _prompts and  _questions are in the declaration


                 // wellcome         
                this.DisplayStartingMessage(this.GetActivityName(),this.GetDescription());

                // ask duraation of activity
                Console.Write("\t How long in seconds, would you like for your session? ");
                string durationActivity = Console.ReadLine();
                this.SetDurationInSeconds(Convert.ToInt16(durationActivity));
                while (Convert.ToInt16(durationActivity) < 0){
                        durationActivity = Console.ReadLine();
                        this.SetDurationInSeconds(Convert.ToInt16(durationActivity));
                }
                this.SetDurationInSeconds(Convert.ToInt16(durationActivity));

                //calculate time immediately
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(this.GetDurationInSeconds());

                // get ready
                Console.Clear();
                Console.Write("\t Be ready for the activity..... ");
                this.DisplayAnimation("numbers", this.GetSecondsForAnimation() );

                //start activity
                Console.Clear();
                 Console.WriteLine("\t Considerthe following prompt:");
                 Console.WriteLine("");
                // Console.WriteLine(GetPrompt());
                 Console.WriteLine("");



                // This code is to meet Exceeding Requirements on the following option:
                // “Make sure no random prompts/questions are selected until they have all been used at least once in that session.”
                // ***************************************************************************
                // PROMPTS
                
                string thePrompt = GetPrompt();
                int indexPrompt = _prompts.IndexOf(thePrompt);    

                if (allPromtsHasBeenUsed()) {
                                // if all prompts has been used, clean the list _promptsUsedInTheSession and start over selecting random prompt
                                _promptsUsedInTheSession.Clear();
                                Console.WriteLine("\t ***** Prompts will be re-used...");
                                AddIndexPromptUsedInTheSession(indexPrompt);
                }
                else{
                        while (IsThisPromptIndexUsed(indexPrompt)) {
                                thePrompt = GetPrompt();
                                indexPrompt = _prompts.IndexOf(thePrompt); 
                        }
                        AddIndexPromptUsedInTheSession(indexPrompt); 
                }

                Console.WriteLine($"{thePrompt}");
                Console.WriteLine("");
                // ***************************************************************************


                Console.Write("\t When you have something in mind , press enter to continue. ");
                string enter = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("\t Now ponder on each of the following questions as they realated to this experience. ");
                Console.Write("\t You may begin in: ");
                this.DisplayAnimation("numbers",  this.GetSecondsForAnimation() );


                while ( startTime < futureTime){
                        Console.WriteLine("");

                        // Console.Write($"\t\t {this.GetQuestion()}");
                    

                        // This code is to meet Exceeding Requirements on the following option:
                        // “Make sure no random prompts/questions are selected until they have all been used at least once in that session.”
                        // ***************************************************************************
                        // QUESTIONS
                    
                        string theQuestion = GetQuestion();
                        int indexQuestion = _questions.IndexOf(theQuestion);    

                        if (allQuestionsHasBeenUsed()) {
                                        // if all questions has been used, clean the list _questionsUsedInTheSession and start over selecting random question
                                        _questionsUsedInTheSession.Clear();
                                         Console.WriteLine("\t\t  ***** Quesitons will be re-used...");
                                        AddIndexQuestionUsedInTheSession(indexQuestion);
                        }
                        else{
                                while (IsThisQuestionIndexUsed(indexQuestion)) {
                                        theQuestion = GetQuestion();
                                        indexQuestion = _questions.IndexOf(theQuestion);
                                }
                                AddIndexQuestionUsedInTheSession(indexQuestion); 
                        }
                        Console.Write($"\t\t [{indexQuestion}]{theQuestion}  ");
                        // ***************************************************************************  

                        this.DisplayAnimation("numbers", GetSecondsForReflectingActivity() );
                        startTime = startTime.AddSeconds(GetSecondsForReflectingActivity());
                }

                this.DisplayEndingMessage( this.GetEndingMsg() , this.GetActivityName() , this.GetDurationInSeconds());
                this.DisplayAnimation("spinners", this.GetSecondsForAnimation());

        }// End RunActivity


} // End class