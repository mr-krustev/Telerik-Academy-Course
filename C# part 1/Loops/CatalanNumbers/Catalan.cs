/*
In combinatorics, the Catalan numbers are calculated by the following formula: 

Cn = (2n)! / (n+1)!n!

Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
*/

using System;
using System.Numerics;

class Catalan
{
    static void Main()
    {
        Console.WriteLine("0 <= n <= 100");
        Console.Write("n = ");
        int input = 0;
        bool isInputNumber = int.TryParse(Console.ReadLine(), out input);
        BigInteger sum = 0;
        BigInteger factorial = 1;
        BigInteger biggerFactorial = 1;
        BigInteger biggestFactorial = 1;


        if (isInputNumber & 0 <= input & input <= 100)
        {
            for (int i = 1; i <= input; i++)
            {
                factorial *= i;
            }

            for (int i = 1; i <= input + 1; i++)
            {
                biggerFactorial *= i;
            }
            for (int i = 1; i <= 2*input; i++)
            {
                biggestFactorial *= i;
            }

            sum = biggestFactorial / (biggerFactorial * factorial);

            Console.WriteLine("Cn = (2n)! / (n+1)!n! \nCn = {0}", sum);
        }
        else
        {
            Console.WriteLine("Invalind input!");
        }
    }
}

