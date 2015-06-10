/*
Problem 5. Larger than neighbours

Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckIfLarger
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

    static void CheckNeighbours(int position, int[] array)
    {
        if (position > 0 && position < array.Length - 1)
        {
            if (array[position] > array[position-1] && array[position] > array[position+1])
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("The number {0} at position {1} is bigger than it's two neighbours.", array[position], position);
            }
            else
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("The number {0} at position {1} is either equal or smaller to one of it's neighbours.", array[position], position);
            }
        }
        else
        {
            Console.WriteLine(new string('-',40));
            Console.WriteLine("The provided position is either outside the range, or the number on that position does not have 2 neighbours.");
        }
    }

    static void Main()
    {
        arrayOfNumbers = FillArray(arrayOfNumbers);

        Console.WriteLine(new string('-', 40));
        Console.Write("Provide the position you want to check: ");
        int position = int.Parse(Console.ReadLine());
       
        CheckNeighbours(position, arrayOfNumbers);
    }
}

