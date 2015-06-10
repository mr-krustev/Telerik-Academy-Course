/*
Problem 24. Order words

Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Order
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(' ', '.');

        List<string> sortedWords = new List<string>();

        foreach (string word in words)
        {
            sortedWords.Add(word);
        }
        sortedWords.Sort();

        Console.WriteLine(string.Join("\n", sortedWords));
    }
}

