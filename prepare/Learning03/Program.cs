using System;

class Program
{
    static void Main(string[] args)
    {
        /* 1)  No parameters */
        // call the constructor with no prameters which will return defaul value  (1/1)     
        Fraction fraction1 = new Fraction();
        // call a getter that display result as a string
        Console.WriteLine(fraction1.GetFractionString());
        // call a getter taht display the decimal value of the division
        Console.WriteLine(fraction1.GetDecimalValue());

        /* 2)  Numerator as parameter */
        // call the constructor with the initial numerator as parameter, denominator is the defalut value (1)
        Fraction fraction2 = new Fraction(5);
        // call a getter that display result as a string 
        Console.WriteLine(fraction2.GetFractionString());
        // call a getter that display the decimal value of the division 
        Console.WriteLine(fraction2.GetDecimalValue());


        /* 3)  Numerator and denominator as parameters */
        // call the constructor with prameters to vige initial values to top and bottom
        Fraction fraction3 = new Fraction(3,4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

    }
}