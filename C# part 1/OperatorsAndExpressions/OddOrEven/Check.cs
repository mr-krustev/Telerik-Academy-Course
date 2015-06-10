/*
Problem 1. Odd or Even Integers

Write an expression that checks if given integer is odd or even.
*/

using System;

class Check
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool check = false;

        if (number % 2 == 0)
        {
            check = true;
            Console.WriteLine(check);
        }
        else
            Console.WriteLine(check);
    }
}

