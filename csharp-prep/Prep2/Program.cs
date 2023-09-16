using System;

class Program
{
    static void Main(string[] args)
    {

        string letter = "";
        Console.Write("What is you grade percentage? ");
        string InputGradePercentage = Console.ReadLine();
        int gradePercentage = int.Parse(InputGradePercentage);
        if (gradePercentage >= 90 ) {
                letter = "A";
        } else if (gradePercentage >= 80 ) {
                    letter = "B";
            }  else if (gradePercentage >= 70  ) {
                        letter = "C";
                }  else if (gradePercentage >= 60  ) {
                             letter = "D";
                     }  else {
                                letter = "F";
                         } 
        Console.WriteLine($"You grade is {letter}");

        if (gradePercentage >= 70) {
                Console.WriteLine("Concratulations... you pass the class");
        } else { 
                Console.WriteLine("You did not pass the class... courage, keep going!");
             }
    }
}