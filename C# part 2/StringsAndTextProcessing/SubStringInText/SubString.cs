/*
Problem 4. Sub-string in text

Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Example:

The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubString
{
    static void Main()
    {
        string inputText = Console.ReadLine().ToLower();

        string searchedSubString = Console.ReadLine().ToLower();

        int result = CountSubString(inputText, searchedSubString);

        Console.WriteLine("Found times: {0}", result);
    }

    private static int CountSubString(string inputText, string searchedSubString)
    {
        int result = 0;

        for (int i = 0; i < inputText.Length - searchedSubString.Length; i++)
        {
            if (inputText.Substring(i, searchedSubString.Length) == searchedSubString)
            {
                result++;
            }
        }

        return result;
    }
}

