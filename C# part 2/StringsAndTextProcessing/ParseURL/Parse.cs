/*
Problem 12. Parse URL

Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
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
        string inputText = Console.ReadLine();

        string[] result = ExtractInfo(inputText);

        Console.WriteLine(result[0]);
        Console.WriteLine(result[1]);
        Console.WriteLine(result[2]);
    }

    private static string[] ExtractInfo(string inputText)
    {
        string[] stringArray = new string[3];

        stringArray[0] = inputText.Substring(0, inputText.IndexOf(':'));
        stringArray[1] = inputText.Substring(inputText.IndexOf("//") + 2, inputText.IndexOf('/', inputText.IndexOf("//") + 2) - (inputText.IndexOf("//") + 2));
        stringArray[2] = inputText.Substring(inputText.IndexOf('/', inputText.IndexOf("//") + 2), inputText.Length - inputText.IndexOf('/', inputText.IndexOf("//") + 2));

        return stringArray;
    }
}
