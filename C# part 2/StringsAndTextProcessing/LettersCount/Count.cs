/*
Problem 21. Letters count

Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
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
        string[] inputText = Console.ReadLine().Split(' ','.',',');

        int[] letterCount = new int[26];
        

        for (int i = 0; i < inputText.Length; i++)
        {
            foreach (char letter in inputText[i])
            {
                char currentLetter = char.Parse(letter.ToString().ToLower());

                letterCount[currentLetter - 'a']++;
            }
        }

        for (int i = 0; i < letterCount.Length; i++)
        {
            Console.WriteLine((char)(((char)i) + 'a') + " appears: " + letterCount[i]);
        }
    }
}

