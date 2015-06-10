/*
Problem 6. First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FirstLarger
{
    static int[] arrayOfNumbers;

    static int[] FillArray(int[] array)
    {
        Console.Write("Enter size of array: ");
        int size = int.Parse(Console.ReadLine());
        array = new int[size];
        Console.WriteLine(new string('-', 40));
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Number[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static void CheckNeighbours(int[] array)
    {
        for (int position = 0; position < array.Length; position++)
        {
            if (position > 0 && position < array.Length - 1)
            {
                if (array[position] > array[position - 1] && array[position] > array[position + 1])
                {
                    Console.WriteLine(new string('-', 40));
                    Console.WriteLine("The number {0} at position {1} is the first number bigger than it's two neighbours.", array[position], position);
                    return;
                }
            }

        }
    }


    static void Main()
    {
        arrayOfNumbers = FillArray(arrayOfNumbers);
        CheckNeighbours(arrayOfNumbers);
    }
}

