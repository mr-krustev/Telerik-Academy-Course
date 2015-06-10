/*
Problem 4. Hexadecimal to decimal

Write a program to convert hexadecimal numbers to their decimal representation.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Convert
{
    static double decimalNumber = 0;

    static void GetDecimalNumber(char[] hexadecimalNumber)
    {
        int counter = 0;

        foreach (char number in hexadecimalNumber)
        {
            if (char.IsDigit(number) == true)
            {
                decimalNumber += (long)((number - '0') * Math.Pow(16, counter));
            }
            else if (char.IsLetter(number) == true)
            {
                decimalNumber += (long)((number - 'A' + 10) * Math.Pow(16, counter));
            }
            counter++;
        }

    }

    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        char[] hexadecimalNumber = Console.ReadLine().Reverse().ToArray();

        GetDecimalNumber(hexadecimalNumber);
        Console.WriteLine("Decimal representation of your number({0}) = " + decimalNumber, string.Join("", hexadecimalNumber.Reverse()));


    }
}
