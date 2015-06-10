/*
Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
*/

using System;
using System.Text;

class Equation
{
        static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;      // To see the superscript try chaning your console font.

        Console.Write("Write a = ");
        double coefficientA = 0;
        bool ifAIsNumber = double.TryParse(Console.ReadLine(), out coefficientA);

        Console.Write("Write b = ");
        double coefficientB = 0;
        bool ifBIsNumber = double.TryParse(Console.ReadLine(), out coefficientB);

        Console.Write("Write c = ");
        double coefficientC = 0;
        bool ifCIsNumber = double.TryParse(Console.ReadLine(), out coefficientC);

        if (ifAIsNumber && ifBIsNumber)
        {
            if (double.IsNaN((-coefficientB - Math.Sqrt(Math.Pow(coefficientB, 2) - (4 * coefficientA * coefficientC)))))
            {
                Console.WriteLine("There are no roots to this equation!");
            }
            else
            {
            Console.Clear();
            Console.WriteLine("{0}x\xB2 + {1}x + {2} = 0 \nThe roots are:", coefficientA, coefficientB, coefficientC);
            Console.WriteLine("x1 = " + (-coefficientB - Math.Sqrt(Math.Pow(coefficientB,2) - (4 * coefficientA * coefficientC)))/ (2 *coefficientA));
            Console.WriteLine("x2 = " + (-coefficientB + Math.Sqrt(Math.Pow(coefficientB, 2) - (4 * coefficientA * coefficientC)))/ (2*coefficientA));
            }

            

        }


    }
}

