public  class Resume {

    // The C# convention is to start member variables with an underscore _
    public string _name;
    public List<Job> _jobs = new List<Job>();


    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Resume()
    {
    }

    // A method that displays the job information
    public void Display()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine("Jobs:");
        foreach (Job j in _jobs)
        {
            j.Display();
        }
    }







    
}