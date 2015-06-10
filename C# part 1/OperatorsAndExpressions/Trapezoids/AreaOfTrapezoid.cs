/*
Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h.
*/


using System;

class AreaOftrapezoid
{
    static void Main()
    {
        Console.Write("Please write the first side of your trapezoid: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Please write the second side of your trapezoid: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Please write the height of your trapezoid: ");
        double height = double.Parse(Console.ReadLine());

        double area = (sideA + sideB)/2 * height;

        Console.WriteLine("Side A = {0} \nSide B = {1} \nHeight = {2} \nArea = {3}", sideA, sideB, height, area);

    }
}

