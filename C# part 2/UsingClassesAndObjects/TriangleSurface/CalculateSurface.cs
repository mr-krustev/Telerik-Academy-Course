/*
Problem 4. Triangle surface

Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateSurface
{
    static double SideAndAltitude(double side, double altitude)
    {     
        double result = (side * altitude) / 2;
        return result;
    }

    static double ThreeSides(double sideA, double sideB, double sideC)
    {       
        double halfPerimeter = (sideA + sideB + sideC) / 2;
        double result = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

        return result;
    }   

    static double TwoSidesAndAngle(double sideA, double sideB, double angle)
    {
        

        double result = (sideA * sideB * Math.Cos(angle)) / 2;

        return result;
    }


    static void Main()
    {
        Console.WriteLine("Choose method to find area: \n1) Side and altitude \n2) Three sides \n3) Two sides and angle\n" + new string('-',40));

        Console.Write("Method: ");
        string input = Console.ReadLine().ToLower();
        Console.WriteLine();

        if (input == "1" || input == "side and altitude")
        {
            Console.Write("Side = ");
            double side = double.Parse(Console.ReadLine());

            Console.Write("Side = ");
            double altitude = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = {0}",SideAndAltitude(side, altitude)); 
        }
        else if (input == "2" || input == "three sides")
        {
            Console.Write("Side a = ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("Side b = ");
            double sideB = double.Parse(Console.ReadLine());

            Console.Write("Side c = ");
            double sideC = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = {0}", ThreeSides(sideA, sideB, sideC));
        }
        else if (input == "3" || input == "two sides and angle")
        {
            Console.Write("Side a = ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("Side b = ");
            double sideB = double.Parse(Console.ReadLine());

            Console.Write("Angle = ");
            double angle = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = {0}", TwoSidesAndAngle(sideA, sideB, angle));
        }
        else
        {
            Console.WriteLine("Wrong input.");
        }
    }
}

