/*
Problem 1. Decimal to binary

Write a program to convert decimal numbers to their binary representation.
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
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());
        List<int> binaryNumber = new List<int>();

        while (number > 0)
        {
            if (number% 2 == 0)
            {
                binaryNumber.Insert(0,0);
            }
            else if (number % 2 == 1)
            {
                binaryNumber.Insert(0,1);
            }

            number /= 2;
        }

        Console.WriteLine("Binary representation of your number({0}) = " + string.Join("",binaryNumber), number);

    }
}

