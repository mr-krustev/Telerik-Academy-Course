/*
Problem 12. Index of letters

Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
*/

using System;
using System.Linq;

class Index
{
    static void fillLetters(char[] allLetters)
    {
        for (int i = 0; i < 26; i++)
        {
            allLetters[i] = (char)(65 + i);
        }

        int counter = 26;
        for (int i = 0; i < 26; i++,counter++)
        {
            allLetters[counter] = (char)(97 + i);
        }
    }

    static void printLetterAndIndex(string textFromConsole, char[] allLetters)
    {
        foreach (char symbol in textFromConsole)
        {
            for (int i = 0; i < 52; i++)
            {
                if (symbol == allLetters[i])
                {
                    Console.Write("{0} = {1}", symbol, i);
                }
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        char[] allLetters = new char[52];
        fillLetters(allLetters);


        string textFromConsole = Console.ReadLine();
        Console.WriteLine();
        printLetterAndIndex(textFromConsole, allLetters);

    }
}

