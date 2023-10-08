using System.Threading.Tasks.Dataflow;
using System.IO;
using System.Diagnostics.CodeAnalysis;


public class Journal
    {// ---------------------------------------------------------------
     // The C# convention is to start member variables with an underscore _
     // ---------------------------------------------------------------
    //public string _owner;
    public List<Entry> _entries = new List<Entry>();
    string _owner = "Rosy Bertacchini";
    public PromptGenerator prompt = new PromptGenerator();
     

    



    // ---------------------------------------------------------------
    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    // ---------------------------------------------------------------
    public Journal()
    {
    }

    // ---------------------------------------------------------------
    // Methods
    // ---------------------------------------------------------------


    /* WirteEntry */
    public void WriteEntry() {

        /* Initialized and create class instances */
        Entry entry = new Entry();
        PromptGenerator prompt = new PromptGenerator();

        DateTime currentDateTime = DateTime.Now;
        string rndPromt = prompt.GetPrompt();

        Console.WriteLine(rndPromt);
        string promptResponse  = Console.ReadLine();

        // asign values to an entry object
        entry._entryDateTxt = currentDateTime.ToString();
        entry._entryPrompt  = rndPromt;
        entry._entryText = promptResponse;


        //myJournal._owner = name;
        _entries.Add(entry);
    }




    /* Display */ 
    public void DisplayEntries()
    {
        Console.WriteLine("**************************************");    
        Console.WriteLine($"{_owner} This is your Journal: ");       
        Console.WriteLine("");   

        foreach (Entry e in _entries)
        {
            e.Display();
        }
        Console.WriteLine("**************************************");    
    }


    /* Save */ 
    public void SaveEntries(string filename) {

        Console.WriteLine($"{_owner} we are saving your Journal: ");  
        Console.WriteLine("");   
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._entryDateTxt}*{e._entryPrompt}*{e._entryText } ");
            }
        }
    }


    /* Load */

    public void Load(string filename) {

        Console.WriteLine($"{_owner} we loaded your Journal: "); 
        Console.WriteLine("");     
        string[] lines = System.IO.File.ReadAllLines(filename);
        {
            foreach (string line in lines)
                {
                    Entry e = new Entry();
                    string[] parts = line.Split("*");
                    
                    e._entryDateTxt = parts[0];
                    e._entryPrompt = parts[1];
                    e._entryText = parts[2];
                    
                    _entries.Add(e);


                }

        }
    }













}