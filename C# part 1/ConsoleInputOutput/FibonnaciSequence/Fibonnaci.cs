/*
Problem 10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) :
0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.
*/

using System;


class Fibonnaci
{
    static void Main()                  // Since it's long if you want a lot of numbers at some point you will receive wrong data.
    {
        long n = 0;
        bool isNNumber = long.TryParse(Console.ReadLine(), out n);

        long firstNumber = -1;
        long secondNumber = 1;
        long sum = firstNumber + secondNumber;

        for (int i = 0; i < n; i++)
        {
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
           
            Console.Write(sum + ", ");
            
        }

    }
}
