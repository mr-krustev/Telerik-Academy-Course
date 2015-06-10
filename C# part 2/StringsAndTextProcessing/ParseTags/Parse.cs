/*
Problem 5. Parse tags

You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Parse
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();

        string changedText = ChangeText(text);

        Console.WriteLine("Changed text: ");
        Console.WriteLine(changedText);
    }

    private static string ChangeText(string text)
    {
        StringBuilder builder = new StringBuilder();

        int index = 0;
        int beginingCaseLength = "<upcase>".Length;
        int endingCaseLength = "</upcase>".Length;

        for (int i = 0; i < text.Length; i++)
        {
            if (i + beginingCaseLength < text.Length && text.Substring(i,beginingCaseLength) == "<upcase>")
            {
                index = i + beginingCaseLength;
                builder.Append(text.Substring(index, text.IndexOf("</upcase>", index) - index).ToUpper());
                i = text.IndexOf("</upcase>", index) + beginingCaseLength;
            }
            else
            {
                builder.Append(text[i]);
            }
        }
        return builder.ToString();
    }
}
