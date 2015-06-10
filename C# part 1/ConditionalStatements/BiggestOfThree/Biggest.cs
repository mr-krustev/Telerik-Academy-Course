/*
Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.
*/

using System;

class Biggest
{
    static void Main()
    {
        Console.WindowWidth = 50;
        Console.WindowHeight = 20;

        double firstNumber = 0;
        double secondNumber = 0;
        double thirdNumber = 0;

        Console.Write("Enter the first number: ");
        bool isANumber = double.TryParse(Console.ReadLine(), out firstNumber);
        Console.Write("Enter the second number: ");
        bool isBnumber = double.TryParse(Console.ReadLine(), out secondNumber);
        Console.Write("Enter the third number: ");
        bool isCNumber = double.TryParse(Console.ReadLine(), out thirdNumber);

        if (isANumber & isBnumber & isCNumber)
        {
            Console.WriteLine(Math.Max(Math.Max(firstNumber,secondNumber), Math.Max(secondNumber,thirdNumber)));
        }
    }
}

