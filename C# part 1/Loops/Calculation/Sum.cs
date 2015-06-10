/*
Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.
*/

using System;
using System.Linq;

class Sum
{
    static void Main()
    {
        Console.WriteLine("S = 1 + 1!/x + 2!/x2 + ... + n!/x^n.");
        Console.Write("n = ");
        int firstInput = 0;
        bool isFirstNumber = int.TryParse(Console.ReadLine(), out firstInput);

        Console.Write("k = ");
        int secondInput = 0;
        bool isSecondNumber = int.TryParse(Console.ReadLine(), out secondInput);

        double sum = 1;
        int factorial = 1;
        
        

        if (isFirstNumber && isSecondNumber)
        {
            for (int i = 1; i <= firstInput; i++)
            {
                double calculation = 0;

                factorial *= i;

                calculation = (double)factorial / Math.Pow(secondInput,i);
                sum += calculation;
            }

            Console.WriteLine("{0:f5}", sum);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}

