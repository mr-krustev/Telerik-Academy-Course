/*
Problem 14. Quick sort

Write a program that sorts an array of integers using the Quick sort algorithm.
*/

using System;
using System.Linq;
using System.Collections.Generic;

class SortOut
{
    static void FillArrayWithNumbers(int[] arrayWithNumbers) // User can insert his own array.
    {
        for (int i = 0; i < arrayWithNumbers.Length; i++)
        {
            Console.Write("Number[{0}] = ", i);
            arrayWithNumbers[i] = int.Parse(Console.ReadLine());
        }
    }

    static void FillingListWithNumbers(int[] numbersInArray, List<int> numbersInList) // Transfers the array to List, easier to QuickSort.
    {
        for (int i = 0; i < numbersInArray.Length; i++)
        {
            numbersInList.Add(numbersInArray[i]);
        }
    }

    static List<int> QuickSort(List<int> numbersInList) // Quicksorts using recursion.
    {
        if (numbersInList.Count <= 1)
        {
            return numbersInList;
        }

        int pivot = numbersInList[numbersInList.Count / 2];
        List<int> less = new List<int>();
        List<int> greater = new List<int>();

        for (int i = 0; i < numbersInList.Count; i++)
        {
            if (numbersInList[i] != pivot)
            {
                if (numbersInList[i] < pivot)
                {
                    less.Add(numbersInList[i]);
                }
                else
                {
                    greater.Add(numbersInList[i]);
                }
            }
            else if (numbersInList[i] == pivot && i != numbersInList.Count/2) // Adds the numbers that are equal to the pivot.
            {
                greater.Add(numbersInList[i]);
            }
        }

        return Concatenate(QuickSort(less), QuickSort(greater), pivot); // If Concatenate(less, greater, pilot) => no recursion.
    }

    static List<int> Concatenate(List<int> less, List<int> greater,int pivot) // Concatenates the list after each QuickSort.
    {
        List<int> result = new List<int>();

        for (int i = 0; i < less.Count; i++)
        {
            result.Add(less[i]);
        }

        result.Add(pivot);

        for (int i = 0; i < greater.Count; i++)
        {
            result.Add(greater[i]);
        }

        return result;
    }

    static void Print(List<int> list)   // Prints the sorted array.
    {
        Console.Write("Sorted array: ");
        for (int i = 0; i < list.Count; i++)
        {
            if (i + 1 == list.Count)
            {
                Console.Write((list[i]));
            }
            else
            {
                Console.Write(list[i] + ", ");
            }           
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter size of array: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] numbersInArray = new int[arraySize];
        FillArrayWithNumbers(numbersInArray);

        List<int> numbersInList = new List<int>();
        FillingListWithNumbers(numbersInArray, numbersInList);

        List<int> sortedList = QuickSort(numbersInList);
        Print(sortedList);

    }
}

