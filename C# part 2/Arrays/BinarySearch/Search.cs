/*
Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
*/

using System;
using System.Linq;

class Search
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        int[] numbers = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Numbers [{0}] = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        int exactElement = int.Parse(Console.ReadLine());

        Console.WriteLine("Searched number({0}) is on position {1} in the sorted array!", exactElement, Array.BinarySearch(numbers, exactElement));


    }
}

