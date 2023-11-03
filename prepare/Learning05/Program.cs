using System;
using System.ComponentModel;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape> { };

        Shape s1 = new Square("Red",3);
        shapes.Add(s1);
        Shape s2 = new Rectangle("Blue", 5, 10);
        shapes.Add(s2);
        Shape s3 = new Circle("Yellow",5);
        shapes.Add(s3);


       foreach(Shape s in shapes) {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($" el color es {color} y el shape tiene una area de {area}");
        }
    
   } // main
}