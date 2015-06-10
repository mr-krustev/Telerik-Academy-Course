/*
Problem 4. Maximal sequence

    Write a program that finds the maximal sequence of equal elements in an array.
*/

using System;
using System.Linq;

class MaxLengthSequence
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] {' ', '.', '!', '?', ','},StringSplitOptions.RemoveEmptyEntries).ToArray();

        int[] numbers = input.Select(x => int.Parse(x)).ToArray();

        int currentElement = numbers[0];
        int currentLength = 1;
        int maxLength = 1;
        int minElement = 1;

        for (int i = 1; i < input.Length; i++)
        {

            if (currentElement + 1 == numbers[i])
            {
                currentLength++;
                currentElement++;
            }
            else
            {
                currentElement = numbers[i];
                currentLength = 1;
            }

            if (currentLength>maxLength)
            {
                maxLength = currentLength;
                minElement = (currentElement - maxLength) + 1;
            }
        }

        Console.WriteLine("The biggest sequence of equal elements is: ");

        for (int i = 0; i < maxLength; i++)
        {
            if (i + 1 == maxLength)
            {
                Console.Write(minElement + i);
            }
            else
            {
                Console.Write((minElement + i) + ", ");
            }
        }
        Console.WriteLine();      
    }
}

