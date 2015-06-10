/*
Problem 22. Words count

Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Count
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(' ', ',', '.', '!', '?');
        List<string> appearedWords = new List<string>();
        List<int> countedTimes = new List<int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (!appearedWords.Contains(words[i]))
            {
                appearedWords.Add(words[i]);
                countedTimes.Add(1);
            }
            else
            {
                countedTimes[appearedWords.IndexOf(words[i])]++;
            }
        }

        for (int i = 0; i < appearedWords.Count; i++)
        {
            Console.WriteLine("\"{0}\" appeared {1} times.", appearedWords[i], countedTimes[i]);
        }
    }
}

