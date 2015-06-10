/*
Problem 1. Numbers from 1 to N

Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
*/

using System;

class ToN
{
    static void Main()
    {
        int input = 0;
        bool isInputNumber = int.TryParse(Console.ReadLine(), out input);

        if (isInputNumber)
        {
            for (int i = 1; i <= input; i++)
            {
                
                if (i == input)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }

    }
}
