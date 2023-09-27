public class Job
{
        // The C# convention is to start member variables with an underscore _
        public string _companyName = "";
        public string _jobTitle = "";
        public int _startYear = 0;
        public int _endYear = 0;


        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Job()
        {
        }

        // A method that displays the job information
        public void Display()
        {
            //"Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
            Console.WriteLine($"{_jobTitle}, ({_companyName}) {_startYear}-{_endYear}");
        }

     

}