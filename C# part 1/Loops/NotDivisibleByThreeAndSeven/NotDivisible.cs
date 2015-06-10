/*
Problem 2. Numbers Not Divisible by 3 and 7

Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
*/

using System;

class NotDivisible
{
    static void Main()
    {
        int input = 10;
        bool isInputNumber = int.TryParse(Console.ReadLine(), out input);

        if (isInputNumber)
        {
            for (int i = 1; i <= input; i++)
            {
                if (i % 7 != 0 && i % 3 != 0)
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
}

