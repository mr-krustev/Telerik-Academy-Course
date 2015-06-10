/*
Problem 7. Selection sort

Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
*/

using System;
using System.Linq;

class Selection
{
    static void selectionSort(int[] elements)
    {
        for (int i = 0; i < elements.Length; i++)
        {
            for (int j = i + 1; j < elements.Length; j++)
            {
                if (elements[j] < elements[i])
                {
                    int currentNumber = elements[i];
                    elements[i] = elements[j];
                    elements[j] = currentNumber;
                }
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter array size: ");
        int N = int.Parse(Console.ReadLine());
        int[] elements = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write("Number [{0}] = ", i);
            elements[i] = int.Parse(Console.ReadLine());
        }

        selectionSort(elements);
        string joinedNumbers = string.Join(", ", elements);

        Console.WriteLine("\nSorted array: " + joinedNumbers);
      
    }
}

