public class PromptGenerator
{

     // --------------------------------------------------------------
     // The C# convention is to start member variables with an underscore _
     // --------------------------------------------------------------- 

    // no atributes;

    // ---------------------------------------------------------------
    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    // ---------------------------------------------------------------
    public PromptGenerator()
    {
    }

    // ---------------------------------------------------------------
    // methods
    // ---------------------------------------------------------------

    public string GetPrompt()
{
         Random rnd = new Random();
         List<string> promptList = new  List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };
    
            return promptList[rnd.Next(5)];
}








}