/*
Problem 9. Sorting array

Write a method that returns the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sort
{
    static int[] arrayOfNumbers;
    static int highestNumber = int.MinValue;
    static int currentIndex = 0;

    static void FillArrayWithNumbers(int[] array)
    {
        Console.WriteLine(new string('-', 40));
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Number[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }


    }

    static int GetMaximalElement(int[] array, int startingIndex = 0, int endIndex = 0)
    {
        highestNumber = int.MinValue;
        for (int i = startingIndex; i < endIndex; i++)
        {
            if (array[i] > highestNumber)
            {
                highestNumber = array[i];
                currentIndex = i;
            }
        }
        return highestNumber;

    }

    static void SortArrayInDescending(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            GetMaximalElement(array, i, array.Length);
            int temp = highestNumber;
            array[currentIndex] = array[i];
            array[i] = highestNumber;
        }
    }

    static void SortArrayInAscending(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            GetMaximalElement(array, endIndex: array.Length - i);
            int temp = highestNumber;
            array[currentIndex] = array[array.Length-1-i];
            array[array.Length - 1 - i] = highestNumber;
        }
    }

    static void Main()
    {
        Console.Write("Enter the size of your array: ");
        int size = int.Parse(Console.ReadLine());
        
        arrayOfNumbers = new int[size];
        FillArrayWithNumbers(arrayOfNumbers);

        SortArrayInDescending(arrayOfNumbers);
        Console.WriteLine("\nDescend\n{0}\n{1}" ,new string('-',40),string.Join(", ", arrayOfNumbers));

        SortArrayInAscending(arrayOfNumbers);
        Console.WriteLine("\nAscend\n{0}\n{1}\n ", new string('-', 40), string.Join(", ", arrayOfNumbers));
    }
}

