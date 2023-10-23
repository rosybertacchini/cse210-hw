using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Rosy", "Sistemas");
        MathAssignment ma = new MathAssignment("section","1.2" , "problem Sistemas" , "15-19");
        WritingAssignment wa = new WritingAssignment("Eurpoean History", "The causes of the world war  II by Mary Waters");

        Console.WriteLine(a.GetSummary());
        Console.WriteLine(ma.GetHomeworkList());
        Console.WriteLine(a.GetStudentName() + wa.GetWritingAssignment());
    }
}
