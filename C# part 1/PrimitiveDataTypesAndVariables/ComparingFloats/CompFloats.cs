/*
Problem 13.* Comparing Floats

Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic.
Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
*/

using System;

class FloatingPointNumbersComparison
{
    static void Main()
    {
        Console.WriteLine("Enter your first first number:");
        decimal firstNumber = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter your second number:");                     // On the console you must use coma for the number (ex. 12,000003)
        decimal secondNumber = decimal.Parse(Console.ReadLine());

        bool comparedValue = (Math.Abs(firstNumber - secondNumber) < 0.000001m);
        

        if (comparedValue == true)
        {
            Console.WriteLine("{0} and {1} are equal with precision of 0.000001", firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("{0} and {1} are not equal with precision of 0.000001", firstNumber, secondNumber);
        }
        
    }
}