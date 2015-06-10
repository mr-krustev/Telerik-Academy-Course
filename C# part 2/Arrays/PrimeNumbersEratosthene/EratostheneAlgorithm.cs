/*
Problem 15. Prime numbers

Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
*/

using System;
using System.Linq;
using System.Collections.Generic;


class EratostheneAlgorithm
{
    public static List<long> allPrimeNumbers = new List<long>();

    static void fillArray(long[] arrayOfNumbers)
    {
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            arrayOfNumbers[i] = i + 1;
        }
    }

    static void findAllPrimeNumbers(long[] arrayOfNumbers)
    {
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            if ((arrayOfNumbers[i] != 1 && arrayOfNumbers[i] % 2 != 0 && arrayOfNumbers[i] % 3 != 0 && arrayOfNumbers[i] % 5 != 0 && arrayOfNumbers[i] % 7 != 0)
                || (arrayOfNumbers[i] == 2 || arrayOfNumbers[i] == 3 || arrayOfNumbers[i] == 5 || arrayOfNumbers[i] == 7))
            {
                allPrimeNumbers.Add(arrayOfNumbers[i]);
            }
        }
    }

    static void printAllPrimeNumbers(List<long> allPrimeNumbers)
    {
        for (int i = 0; i < allPrimeNumbers.Count(); i++)
        {
            if (i + 1 >= allPrimeNumbers.Count())
            {
                Console.WriteLine(allPrimeNumbers[i]);
            }
            else
            {
                Console.Write(allPrimeNumbers[i] + ", ");
            }
        }
    }


    static void Main()
    {
        long[] arrayOfNumbers = new long[10000000];
        
        fillArray(arrayOfNumbers);

        findAllPrimeNumbers(arrayOfNumbers);

        printAllPrimeNumbers(allPrimeNumbers);
        
        
        
    }
}

