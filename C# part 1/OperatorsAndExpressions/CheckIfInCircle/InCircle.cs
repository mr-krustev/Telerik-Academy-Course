/*
Problem 7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
*/


using System;

class InCircle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        int radius = 2;

       

        if ((Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2)) <= Math.Pow(radius, 2))
        {
            Console.WriteLine("The point you have specified is in the circle! "); 
        }
        else
            Console.WriteLine("The pont you have specified is not in the circle. :(");

        Console.ReadLine();
        }
}

