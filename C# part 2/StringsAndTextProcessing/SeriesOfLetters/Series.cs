/*
Problem 23. Series of letters

Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Series
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        StringBuilder text = new StringBuilder(inputText);

        for (int i = 1; i < text.Length; i++)
        {
            while (i < text.Length && text[i] == text[i-1])
            {
                text.Remove(i, 1);
            }
        }

        Console.WriteLine(text.ToString());
    }
}
