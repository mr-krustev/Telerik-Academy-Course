/*
Problem 13. Binary to Decimal Number
 
Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
*/

using System;
using System.Linq;

class Binary
{
    static void Main()
    {
        char[] input = Console.ReadLine().Reverse().ToArray();
        long numberDecimal = 0;
        double conversion = 0;


        for (int i = 0; i < input.Length; i++)
        {
            conversion = (input[i] - '0') * Math.Pow(2, i);
            numberDecimal += (long)conversion;

        }

        Console.WriteLine(numberDecimal);
    }
}