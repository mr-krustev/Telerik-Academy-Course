/*
Problem 2. Reverse string

Write a program that reads a string, reverses it and prints the result at the console.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Reverse
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string inputText = ReverseText(Console.ReadLine());

        Console.WriteLine("Reversed text:");
        Console.WriteLine(inputText);
    }

    private static string ReverseText(string p)
    {
        string result = string.Join("",p.Reverse());
        return result;
    }
}

