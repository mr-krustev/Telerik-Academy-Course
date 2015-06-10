/*
Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
*/

using System;
using System.Linq;

class Increasing
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ', '.', '!', '?', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        string currentElement = input[0];
        int currentLength = 1;
        string maxElement = "";
        int maxLength = 1;

        for (int i = 1; i < input.Length; i++)
        {

            if (currentElement == input[i])
            {
                currentLength++;
            }
            else
            {
                currentElement = input[i];
                currentLength = 1;
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                maxElement = currentElement;
            }
        }

        Console.WriteLine("The biggest sequence of equal elements is: ");

        for (int i = 0; i < maxLength; i++)
        {
            if (i + 1 == maxLength)
            {
                Console.Write(maxElement);
            }
            else
            {
                Console.Write(maxElement + ", ");
            }
        }
        Console.WriteLine();  

    }
}

