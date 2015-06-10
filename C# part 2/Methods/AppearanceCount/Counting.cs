/*
Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Counting
{
    static int timesNumberAppears = 0;
    static int[] arrayOfNumbers;

    static void GiveArraySizeAndSearchedNumber()
    {
        Console.Write("Please provide size of one-dimensional array: ");
        int size = 0;
        bool isInputNumber = int.TryParse(Console.ReadLine(), out size);

        if (isInputNumber)
        {
        NewSearchedNumber:
            Console.Write("Please provide the number you are searching for: ");
            int number = 0;
            bool isNumberCorrect = int.TryParse(Console.ReadLine(), out number);

            if (isNumberCorrect)
            {
                FillArrayWithNumbers(size,number);
            }
            else
            {
                Console.WriteLine("Invalid searched number, provide a new one!\n" + new string('-',40) + "\n");
                goto NewSearchedNumber;
            } 
        }
        else
        {
            Console.WriteLine("Invalid array size, provide a new one!\n" + new string('-', 40) + "\n");
            GiveArraySizeAndSearchedNumber();
        }
    }

    static void FillArrayWithNumbers(int size, int searchedNumber)
    {
        arrayOfNumbers = new int[size];

        for (int i = 0; i < size; i++)
        {
        RefillArrayAti:
            Console.Write("Number[{0}] = ", i);
            bool correctInput = int.TryParse(Console.ReadLine(), out arrayOfNumbers[i]);

            if (correctInput == false)
            {
                Console.WriteLine(new string('-',40) + "\nInvalid number, provide new one.\n");
                goto RefillArrayAti;
            }
        }

        CheckForGivenNumber(arrayOfNumbers, searchedNumber);
    }

    static void CheckForGivenNumber(int[] array, int searchedNumber)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == searchedNumber)
            {
                timesNumberAppears++;
            }
        }

        Console.WriteLine("The number [{0}] appears {1} times. ", searchedNumber,timesNumberAppears);
    }

    static void Main()
    {
        GiveArraySizeAndSearchedNumber();
    }
}