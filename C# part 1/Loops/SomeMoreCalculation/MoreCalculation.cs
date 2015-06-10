/*
Problem 7. Calculate N! / (K! * (N-K)!)

In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
*/

using System;

class MoreCalculation
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
        int commonFactorial = 1;
        int sum = 0;

        if (isFirstNumber & isSecondNumber & 1 < secondNumber & secondNumber < firstNumber & firstNumber < 100)
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
            for (int i = 1; i <= (firstNumber - secondNumber); i++)
            {
                commonFactorial *= i;
            }
            sum = factorialN / (factorialK * commonFactorial);

            Console.WriteLine("N! / K! = {0} ", sum);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }

    }
}
