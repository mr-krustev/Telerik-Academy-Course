/*
Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).
*/


using System;
using System.Linq;

class FindingSum
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        int[] numbers = new int[arraySize];
        int searchedSum = int.Parse(Console.ReadLine());

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Numbers[{0}] = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int[] firstElement = new int[arraySize/2] ;
        int[] lastElement = new int[arraySize/2];
        bool sumExists = false;
        int counterSum = 0;

        for (int i = 0; i < arraySize; i++)
        {
            int sum = 0;
            sum += numbers[i];
            for (int j = i + 1; j < arraySize; j++)
            {
                sum += numbers[j];
                if (sum == searchedSum)                 // This way we can see more than 1 sum.
                {
                    sumExists = true;
                    firstElement[counterSum] = i;
                    lastElement[counterSum] = j;
                    counterSum++;
                }
                else if (sum > searchedSum)
                {
                    break;
                }
            }
        }

        if (sumExists == true)
        {
            int useElement = 0;
            for (int i = 0; i < counterSum; i++)
            {                
                for (int j = firstElement[useElement]; j < lastElement[useElement] + 1; j++)
                {
                    if (j + 1 > lastElement[useElement])
                    {
                        Console.WriteLine(numbers[j]);
                    }
                    else
                    {
                        Console.Write(numbers[j] + ", ");
                    }
                    
                }
                if (useElement + 1 < counterSum)
                {
                    useElement++;
                }   
            }
        }
    }
}

