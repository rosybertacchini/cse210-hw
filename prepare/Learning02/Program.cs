// Rosy Bertacchini

using System;

class Program
{
    static void Main(string[] args)
    {

       Resume myResume = new Resume(); 
       myResume._name = "Rosy Bertacchini";
       myResume._jobs = new List<Job>();
       
       Job job1 = new Job();
       Job job2 = new Job();

       job1._jobTitle = "Software Engineer";
       job1._companyName = "Microsoft";
       job1._startYear = 2012;
       job1._endYear = 2018;

       job2._jobTitle = "Developer";
       job2._companyName = "Apple";
       job2._startYear = 2019;
       job2._endYear = 2023;

        myResume._jobs.Add(job1) ;
        myResume._jobs.Add(job2) ;

        Console.WriteLine("---------------------------------------------------------");
        myResume.Display();
        Console.WriteLine("---------------------------------------------------------");

    }
}