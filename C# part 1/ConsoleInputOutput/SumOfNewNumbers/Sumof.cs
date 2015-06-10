/*
Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
*/

using System;
using System.Linq;

class SumOf
{
    static void Main()
    {
        Console.Write("Enter the number of numbers you want to calculate: ");
        int numbers = 0;
        bool isNumbes = int.TryParse(Console.ReadLine(), out numbers);

        int[] numbersArray = new int[numbers];

        for (int i = 0; i < numbers; i++)
        {
            Console.Write("Number[{0}] = ", i);
            numbersArray[i] = int.Parse(Console.ReadLine());

       }

       
        Console.WriteLine("The sum = " + numbersArray.Sum());
        

    }
}

