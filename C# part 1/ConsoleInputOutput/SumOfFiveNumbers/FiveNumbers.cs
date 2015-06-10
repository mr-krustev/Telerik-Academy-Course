/*
Problem 7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
*/

using System;
using System.Linq;

class FiveNumbers
{
    static void Main()
    {
        Console.Write("Enter your five numbers: ");
        double[] numbers = Console.ReadLine()
                        .Split(new char[] { ' ', ',', '\t', '\"', '\'', '+', '-', '*'}, StringSplitOptions.RemoveEmptyEntries) // Splits the given symbols, assigns them null and removes them.
                        .Select(x => double.Parse(x))                                                // All the remaining symbols are then parsed to doubles.
                        .ToArray();             // All the parsed doubles then become part of the array. If "1,2 3'4"5" => {1, 2, 3, 4, 5} - this is how the array will look.
                                                                                                    // Bro tip: Watch last year's video for arrays/ масиви.
        Console.WriteLine(numbers.Sum());           // Calculates the sum of all the collected double symbols and prints it.
    }
}


