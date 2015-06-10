/*
Problem 18. Extract e-mails

Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Extract
{
    static void Main()
    {
        string[] inputText = Console.ReadLine().Split(' ');

        List<string> emails = new List<string>();

        for (int i = 0; i < inputText.Length; i++)
        {
            if (inputText[i].Contains('@'))
            {
                if (inputText[i][inputText[i].Length - 1] == '.' || inputText[i][inputText[i].Length -1] == ',')
                {
                    inputText[i] = inputText[i].Substring(0, inputText[i].Length - 1);
                }

                if (inputText[i].Contains("."))
                {
                    if (inputText[i].IndexOf('@') < inputText[i].IndexOf('.'))
                    {
                        emails.Add(inputText[i]);
                    }
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine(string.Join("\n", emails));

    }
}

