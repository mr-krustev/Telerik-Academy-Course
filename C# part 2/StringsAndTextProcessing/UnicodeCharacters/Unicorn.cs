/*
Problem 10. Unicode characters

Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Unicorn
{
    static void Main()
    {
        string inputText = "Hi!";
        StringBuilder result = ConvertToUnicorn(inputText);

        Console.WriteLine(result.ToString());
        
    }

    private static StringBuilder ConvertToUnicorn(string inputText)
    {
        StringBuilder convertToUnicode = new StringBuilder();

        foreach (char ch in inputText)
        {
            convertToUnicode.AppendFormat("\\u{0:X4}", (int)ch);
        }

        return convertToUnicode;
    }
}

