/*
Problem 8. Extract sentences

Write a program that extracts from a given text all sentences containing given word.
Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sentences
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string inputText = Console.ReadLine();
        Console.WriteLine("Enter searched word: ");
        string searchedWord = Console.ReadLine();

        string result = Extract(inputText, searchedWord);

        Console.WriteLine(result.Trim());
    }

    private static string Extract(string inputText, string searchedWord)
    {
        StringBuilder builder = new StringBuilder();
        int index = 0;
        int startIndex = index;
        while (index < inputText.Length - 1)
        {
            
            for (int i = startIndex; i < inputText.IndexOf('.', startIndex + 1); i++)
            {
                if (inputText.Substring(i, searchedWord.Length) == searchedWord)
                {
                        if ((i -1 > 0 && !Char.IsLetter(inputText[i - 1])) || (!char.IsLetter(inputText[i+searchedWord.Length])))
                    {
                        builder.Append(inputText, startIndex, inputText.IndexOf('.', index + 1) + 1- startIndex );
                        break;
                    }                
                }

            }

            index = inputText.IndexOf('.', startIndex + 1);
            startIndex = index + 1;
        }

        return builder.ToString();
    }
}

