/*
Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GetSum
{
    static double GetSumOf(string input)
    {
        char[] removedChars = { ' ', ',', '!', '+', '?' };
        double[] numbers = input.Split(removedChars, StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).ToArray();

        return numbers.Sum();
    }

    static void Main()
    {
        Console.Write("Enter numbers separated by space: ");
        string input = Console.ReadLine();

        Console.WriteLine("Sum = {0}", GetSumOf(input));
    }
}

