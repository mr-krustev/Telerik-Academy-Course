/*
Problem 14. Integer calculations

Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintResult
{
    static void Main()
    {
        char[] removeChars = { ' ', ',', '!', '?', ':', '+', '-', '*' };

        Console.WriteLine("Enter a sequence of integers, separated by spaces: ");
        int[] arrayOfNumbers = Console.ReadLine().Split(removeChars, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Console.WriteLine("\nMin: {0} \nMax: {1} \nAverage: {2} \nSum: {3} \nProduct: {4}",
            Calculate.Min(arrayOfNumbers), Calculate.Max(arrayOfNumbers), Calculate.AverageOf(arrayOfNumbers),
            Calculate.SumOf(arrayOfNumbers), Calculate.ProductOf(arrayOfNumbers));
    }
}

