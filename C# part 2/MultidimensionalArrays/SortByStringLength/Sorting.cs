/*
Problem 5. Sort by string length

You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sorting
{
    static void Main()
    {
        Console.Write("Enter your text: ");
        string[] input = Console.ReadLine().Split(new char[] {' ', '!', '?', '.', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[i].Length > input[j].Length)
                {
                    string temporary = input[i];
                    input[i] = input[j];
                    input[j] = temporary;
                }
            }

        }
        Console.WriteLine(new string('-',40) + "\nSorted string by length of word: ");

        for (int i = 0; i < input.Length; i++)
        {
            Console.WriteLine("String[{0}] = {1}",i, input[i]);
        }

    }
}

