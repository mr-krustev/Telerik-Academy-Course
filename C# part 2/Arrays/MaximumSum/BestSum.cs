/*
Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array.
*/

using System;
using System.Linq;

class BestSum
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());       
        int[] numbers = new int[arraySize];

        int sum = 0;
        int maxSum = 0;
        int beginingElement = 0;
        int lastElement = 0;

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Number [{0}] = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arraySize; i++)
        {
            sum = 0 + numbers[i];

            for (int j = i + 1; j < arraySize; j++)
            {
                sum += numbers[j];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    lastElement = j;
                    beginingElement = i;
                }
            }    
        }

        for (int i = beginingElement; i <= lastElement; i++)
        {
            if (i + 1 > lastElement)
            {
                Console.WriteLine(numbers[lastElement]);
            }
            else
            {
                Console.Write(numbers[i] + ", ");
            }
        }
        

    }
}

