/*
Problem 10. Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/


using System;


class IsOutOfSquare

{
    static void Main()
    {
        Console.Write("Wrie the x coordinate:");
        double x = double.Parse(Console.ReadLine());
        Console.Write("write the y coordinate: ");
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = (Math.Pow((x-1), 2) + Math.Pow((y-1),2)) <= Math.Pow(1.5, 2);
        bool isInSquare = (x >= -1 && x <= 5) && (y >= -1 & y <= 1);

        if (isInCircle && !isInSquare)
        {
            Console.WriteLine("The given point ({0}, {1}) is in the circle and out of the rectangle.", x, y);
        }
        else
            Console.WriteLine("The given point ({0}, {1}) is either out of the circle or in the rectangle.", x, y);
    }
}

