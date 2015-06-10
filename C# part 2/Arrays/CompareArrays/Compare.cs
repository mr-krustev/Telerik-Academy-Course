/*
Problem 2. Compare arrays

    Write a program that reads two integer arrays from the console and compares them element by element.

*/

using System;
using System.Linq;

class Compare
{
    static void Main()
    {
        Console.Write("Size of first array<positive integer>: ");
        int sizeFirstArray = int.Parse(Console.ReadLine());
        int[] firstArray = new int[sizeFirstArray];

        Console.Write("Size of second array<positive integer>: ");
        int sizeSecondArray = int.Parse(Console.ReadLine());
        int[] secondArray = new int[sizeSecondArray];

        bool areEqual = false;

        Console.WriteLine(new string('-', 40));

        for (int i = 0; i < sizeFirstArray; i++)
        {
            Console.Write("First array, number[{0}] = ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(new string('-', 40));

        for (int i = 0; i < sizeSecondArray; i++)
        {
            Console.Write("Second array, number[{0}] = ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(new string('-', 40));

        for (int i = 0; i < Math.Min(sizeFirstArray,sizeSecondArray); i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                areEqual = true;
                Console.WriteLine("First array, number[{0}] = Second array, number [{0}] | ( {1} = {2} )\t {3}", i, firstArray[i], secondArray[i], areEqual);
            }
            else
            {
                areEqual = false;
                Console.WriteLine("First array, number[{0}] = Second array, number [{0}] | ( {1} = {2} )\t {3}", i, firstArray[i], secondArray[i], areEqual);
            }
        }




    }
}

