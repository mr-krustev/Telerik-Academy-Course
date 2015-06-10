/*
Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
*/


using System;
using System.Linq;

class KSum
{
    static void Main()
    {
        Console.Write("Please, enter the size of the array: ");
        int arraySize = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Note: the sequence size should not be bigger than the array size.");
        Console.Write("Please enter the size of the sequence: ");
        int sequenceSize = int.Parse(Console.ReadLine());

        int[] numbers = new int[arraySize];
        int[] highestNumbers = new int[sequenceSize];
        int sum = 0;
        Console.WriteLine(new string('-', 40));

        if (arraySize >= sequenceSize)
        {
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("Number [{0}] = ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < sequenceSize; i++)          // I find the K biggest numbers, since they will be producing THE MAXIMAL SUM. :)
            {
                int currentMaxNumber = numbers.Max();
                sum += currentMaxNumber;

                highestNumbers[i] = currentMaxNumber;

                numbers = numbers.Except(new int[] { numbers.Max() }).ToArray();
            }


            Console.WriteLine("The sum of the {0} biggest numbers = " +sum, sequenceSize);

            Console.Write("The {0} biggest numbers: ", sequenceSize);
            for (int i = 0; i < sequenceSize; i++)
            {
                if (i + 1 == sequenceSize)
                {
                    Console.WriteLine(highestNumbers[i]);
                }
                else
                {
                    Console.Write(highestNumbers[i] + ", ");
                }
            }
        }
        else
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Instructions were clear. Follow them, please!");
        }
        
    }
}

