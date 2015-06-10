/*
Problem 4. Binary search

Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SearchByBinary
{
    static void Main()
    {
        Console.Write("Enter size of array: ");
        int arraySize = int.Parse(Console.ReadLine());

        Console.Write("Enter the searched number K = ");
        int searchedNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('-',40));

        int[] arrayOfNumbers = new int[arraySize];

        Console.WriteLine("Fill the array: ");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Number[{0}] = ", i);
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arrayOfNumbers);
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("The searched number {0} is on position {1} in the sorted array.", searchedNumber, Array.BinarySearch(arrayOfNumbers, searchedNumber));
        Console.WriteLine(new string('-', 40));
        string joinedArray = string.Join(", ", arrayOfNumbers);
        Console.WriteLine("Sorted array: \n" + joinedArray);
      
    }
}

