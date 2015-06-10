/*
Problem 3. Decimal to hexadecimal

Write a program to convert decimal numbers to their hexadecimal representation.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Convert
{
    static StringBuilder hexadecimalNumber = new StringBuilder();

    static void GetHexadecimal(int number)
    {
        while (number > 0)
        {
            if (number % 16 >= 0 && number % 16 <= 9)
            {
                hexadecimalNumber.Insert(0, number%16);
            }
            else
            {
                hexadecimalNumber.Insert(0, (char)(55 + number % 16));
            }
            number /= 16;
        }    
    }

    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());

        GetHexadecimal(number);

        Console.WriteLine("Hexadecimal representation of your number({0}) = " + hexadecimalNumber, number);

    }
}

