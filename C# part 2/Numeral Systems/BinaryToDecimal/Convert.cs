/*
Problem 2. Binary to decimal

Write a program to convert binary numbers to their decimal representation.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Convert
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        char[] binaryNumber = Console.ReadLine().Reverse().ToArray();
        double decimalNumber = 0;

        int counter = 0;

        foreach (char number in binaryNumber)
        {
            decimalNumber += (number - '0') * Math.Pow(2, counter);
            counter++;
        }

        Console.WriteLine("Decimal representation of your number({0}) = " + decimalNumber, string.Join("",binaryNumber.Reverse()));

    }
}
