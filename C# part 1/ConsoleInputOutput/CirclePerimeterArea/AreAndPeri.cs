/*
Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
*/

using System;

class AriaAndPeri
{
    static void Main()
    {
        Console.Write("Write your radius: ");
        double radius = 0.0;
        bool isRadius = double.TryParse(Console.ReadLine(), out radius);

        if (isRadius)
        {
            Console.WriteLine("The perimeter of the circle with r = {0:0.00} is {1:0.00}", radius, 2*Math.PI*radius);
            Console.WriteLine("The are aof the circle with r = {0:0.00} is {1:0.00}", radius, Math.PI*Math.Pow(radius,2));
        }
        else
        {
            Console.WriteLine("The input you have provided is invalid!");
        }

    }
}
