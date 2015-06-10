/*
Problem 15.* Number calculations

Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
Use generic method (read in Internet about generic methods in C#).
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

        Console.Write("Choose a data type for numbers<integer,double,byte,long,decimal>: ");
        string dataChoice = Console.ReadLine().ToLower();

        if (dataChoice == "integer" || dataChoice == "1")
        {
            Console.WriteLine("Enter a sequence of integers, separated by spaces: ");
            int[] arrayOfNumbers = Console.ReadLine().Split(removeChars, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine("\nMin: {0} \nMax: {1} \nAverage: {2} \nSum: {3} \nProduct: {4}",
            Calculate.Min(arrayOfNumbers), Calculate.Max(arrayOfNumbers), Calculate.AverageOf(arrayOfNumbers),
            Calculate.SumOf(arrayOfNumbers), Calculate.ProductOf(arrayOfNumbers));
        }
        else if (dataChoice == "double" || dataChoice == "2")
        {
            Console.WriteLine("Enter a sequence of doubles, separated by spaces: ");
            double[] arrayOfNumbers = Console.ReadLine().Split(removeChars, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            Console.WriteLine("\nMin: {0} \nMax: {1} \nAverage: {2} \nSum: {3} \nProduct: {4}",
            Calculate.Min(arrayOfNumbers), Calculate.Max(arrayOfNumbers), Calculate.AverageOf(arrayOfNumbers),
            Calculate.SumOf(arrayOfNumbers), Calculate.ProductOf(arrayOfNumbers));
        }
        else if (dataChoice == "byte" || dataChoice == "3")
        {
            Console.WriteLine("Enter a sequence of bytes, separated by spaces: ");
            byte[] arrayOfNumbers = Console.ReadLine().Split(removeChars, StringSplitOptions.RemoveEmptyEntries).Select(byte.Parse).ToArray();

            Console.WriteLine("\nMin: {0} \nMax: {1} \nAverage: {2} \nSum: {3} \nProduct: {4}",
            Calculate.Min(arrayOfNumbers), Calculate.Max(arrayOfNumbers), Calculate.AverageOf(arrayOfNumbers),
            Calculate.SumOf(arrayOfNumbers), Calculate.ProductOf(arrayOfNumbers));
        }
        else if (dataChoice == "long" || dataChoice == "4")
        {
            Console.WriteLine("Enter a sequence of longs, separated by spaces: ");
            long[] arrayOfNumbers = Console.ReadLine().Split(removeChars, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            Console.WriteLine("\nMin: {0} \nMax: {1} \nAverage: {2} \nSum: {3} \nProduct: {4}",
            Calculate.Min(arrayOfNumbers), Calculate.Max(arrayOfNumbers), Calculate.AverageOf(arrayOfNumbers),
            Calculate.SumOf(arrayOfNumbers), Calculate.ProductOf(arrayOfNumbers));
        }
        else if (dataChoice == "decimal" || dataChoice == "5")
        {
            Console.WriteLine("Enter a sequence of decimals, separated by spaces: ");
            decimal[] arrayOfNumbers = Console.ReadLine().Split(removeChars, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();

            Console.WriteLine("\nMin: {0} \nMax: {1} \nAverage: {2} \nSum: {3} \nProduct: {4}",
            Calculate.Min(arrayOfNumbers), Calculate.Max(arrayOfNumbers), Calculate.AverageOf(arrayOfNumbers),
            Calculate.SumOf(arrayOfNumbers), Calculate.ProductOf(arrayOfNumbers));
        }      
    }
}

