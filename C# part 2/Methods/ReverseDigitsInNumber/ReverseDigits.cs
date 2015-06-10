/*
Problem 7. Reverse number

Write a method that reverses the digits of given decimal number.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseDigits
{
    static void ReverseNumbers(decimal input)
    {
        Console.WriteLine(string.Join("", input.ToString().Reverse()));
    }

    static void Main()
    {
        Console.Write("Enter your number: ");
        decimal input = decimal.Parse(Console.ReadLine());
        ReverseNumbers(input);
    }
}

