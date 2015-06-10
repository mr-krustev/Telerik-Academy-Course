/*
Problem 7. Encode/decode

Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Coding
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        string cypher = Console.ReadLine();

        string encodedText = Encode(inputText, cypher);

        Console.WriteLine(encodedText);
    }

    private static string Encode(string inputText, string cypher)
    {
        StringBuilder builder = new StringBuilder();
        int maxLength = Math.Max(inputText.Length, cypher.Length);

        for (int i = 0; i < maxLength; i++)
        {
            char textSymbol = inputText[i % inputText.Length];
            char cypherSymbol = cypher[i % cypher.Length];

            builder.Append((char)(textSymbol ^ cypherSymbol));
        }

        return builder.ToString();
    }
}
