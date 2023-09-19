// Rosy Bertacchini

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.WriteLine("----------------------------------------------");
        int number = 0;

        List<int> numbers;
        numbers = new List<int>();
        int sum = 0;
        int largest = 0;
        int smallest_positive = 10000000;
       
        Console.Write("Enter a number ");
        string number_str = Console.ReadLine();
        number = int.Parse(number_str);


        while (number != 0 ) {
            numbers.Add(number);
            Console.WriteLine("Enter a number ");
            number_str = Console.ReadLine();
            number = int.Parse(number_str);
        } 
        Console.WriteLine("*************************************************");
  

        foreach (int num in numbers)
        {
            if (num > largest) {
                largest = num;
            } 
            if (num < smallest_positive) {
                smallest_positive = num;
            } 
            sum += num;
        }
        decimal average = (sum / numbers.Count()) ;
    

        // Display results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is:: {average}");
        Console.WriteLine($"The smallest positive number is: {smallest_positive}");
        Console.WriteLine("The sorted list is:");
        Console.WriteLine(" ");

        numbers.Sort();
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }


    }
}