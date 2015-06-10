/*
Problem 1. Leap year

Write a program that reads a year from the console and checks whether it is a leap one.
Use System.DateTime.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckIfLeap
{
    static void Main()
    {
        Console.Write("Enter year in format<yyyy>: ");
        string input = Console.ReadLine();

        Console.WriteLine("Is year {0} leap? {1}.", input, DateTime.IsLeapYear(int.Parse(input)));
        
    }
}

