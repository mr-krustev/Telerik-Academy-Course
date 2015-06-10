/*
Problem 9. Forbidden words

We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PutAsteriks
{
    static void Main()
    {
        string[] forbiddenWords = Console.ReadLine().Split(' ').ToArray();
        string inputText = Console.ReadLine();

        string result = ReplaceForbiddenWords(inputText, forbiddenWords);

        Console.WriteLine(result);
    }

    private static string ReplaceForbiddenWords(string inputText, string[] forbiddenWords)
    {
        StringBuilder builder = new StringBuilder(inputText);

        foreach (string word in forbiddenWords)
        {
            for (int i = 0; i < inputText.Length - word.Length; i++)
            {
                if (inputText.Substring(i,word.Length) == word)
                {
                    builder.Replace(inputText.Substring(i, word.Length), new string('*', word.Length));
                    i = i + word.Length;
                }
            }
     
        }

        return builder.ToString();
    }
}

