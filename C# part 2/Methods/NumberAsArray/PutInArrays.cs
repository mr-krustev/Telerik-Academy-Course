/*
Problem 8. Number as array

Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class PutInArrays
{
    static BigInteger[] firstNumberArray;
    static BigInteger[] secondNumberArray;
    static BigInteger sumOfTwoNumbersFromArrays = 0;

    static BigInteger[] AddNumberToArrays(BigInteger[] array)
    {
        Console.WriteLine(new string('-',40));
        if (array.Length <= 10000)
        {
            Console.WriteLine("Enter the digits one by one of your number from left to right!");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Number[{0}] = ", i);
                array[i] = BigInteger.Parse(Console.ReadLine());                
            }
        }
        else
        {
            throw new Exception("Size is too big!");
        }
        Console.Clear();
        return array;
    }

    static BigInteger GetSum(BigInteger[] firstNumberAsArray, BigInteger[] secondNumberAsArray)
    {
        BigInteger firstNumber = BigInteger.Parse(string.Join("", firstNumberAsArray));
        BigInteger secondNumber = BigInteger.Parse(string.Join("", secondNumberAsArray));

        sumOfTwoNumbersFromArrays = firstNumber + secondNumber;

        return sumOfTwoNumbersFromArrays;
    }

    static void Main()
    {
        Console.Write("Enter the size of your first number: ");
        int size = int.Parse(Console.ReadLine());
        firstNumberArray = new BigInteger[size];

        Console.Write("Enter the size of your second number: ");
        int sizeSecondArray = int.Parse(Console.ReadLine());
        secondNumberArray = new BigInteger[sizeSecondArray];

        firstNumberArray = AddNumberToArrays(firstNumberArray);
        Console.WriteLine("First number = {0}", string.Join("", firstNumberArray));

        secondNumberArray = AddNumberToArrays(secondNumberArray);
        Console.WriteLine("First number = {0}", string.Join("", firstNumberArray));
        Console.WriteLine("Second number = {0}", string.Join("", secondNumberArray));

        GetSum(firstNumberArray,secondNumberArray);
       
        
        Console.WriteLine(new string('-', 40) + "\nThe sum of both your numbers is: " + sumOfTwoNumbersFromArrays);

    }
}

