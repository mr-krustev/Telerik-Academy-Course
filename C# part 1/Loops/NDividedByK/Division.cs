/*
Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
*/

using System;
using System.Linq;

class Division
{
    static void Main()
    {
        Console.WriteLine("1 < k < n < 100");
        Console.Write("n = ");
        int firstNumber = 0;
        bool isFirstNumber = int.TryParse(Console.ReadLine(), out firstNumber);
        Console.Write("k = ");
        int secondNumber = 0;
        bool isSecondNumber = int.TryParse(Console.ReadLine(), out secondNumber);

        int factorialN = 1;
        int factorialK = 1;
        int sum = 0;

        if (isFirstNumber & isSecondNumber & 1 < secondNumber  & secondNumber < firstNumber & firstNumber < 100)
        {
            for (int i = 1; i <= firstNumber; i++)
            {
                if (i > secondNumber)
                {
                    factorialN *= i;
                }
                else
                {
                    factorialN *= i;
                    factorialK *= i;
                }
            }
            sum = factorialN / factorialK;

            Console.WriteLine("N! / K! = {0} ", sum);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }

    }
}

