public class Entry
{     // --------------------------------------------------------------
     // The C# convention is to start member variables with an underscore _
     // --------------------------------------------------------------- 
    public string _entryDateTxt;
    public string _entryPrompt ;
    public string _entryText;


    // ---------------------------------------------------------------
    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    // ---------------------------------------------------------------
    public Entry()
    {
    }

    // ---------------------------------------------------------------
    // methods
    // ---------------------------------------------------------------

    public void Display()
    {
        Console.WriteLine($"Date: {_entryDateTxt} ");
        Console.WriteLine($"Prompt: {_entryPrompt}");
        Console.WriteLine($"{_entryText}");
    }








}