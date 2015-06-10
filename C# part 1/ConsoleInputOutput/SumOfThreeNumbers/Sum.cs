/*
Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.
*/

using System;

class Sum
{
    static void Main()
    {
        Console.Write("Please write your first number: ");
        double firstNumber = 0;
        bool isFirstNumber = double.TryParse(Console.ReadLine(), out firstNumber);

        Console.Write("Please write your second number: ");
        double secondNumber = 0;
        bool isSecondNumber = double.TryParse(Console.ReadLine(), out secondNumber);

        Console.Write("Please write your last number: ");
        double thirdNumber = 0;
        bool isThirdNumber = double.TryParse(Console.ReadLine(), out thirdNumber);

        if (isFirstNumber && isSecondNumber && isThirdNumber)
        {
            Console.WriteLine(new string('-', 40) + "\nThe sum of {0}, {1} and {2} is {3}.", firstNumber, secondNumber, thirdNumber, firstNumber + secondNumber + thirdNumber);
        }
        else
        {
            Console.WriteLine(new string('-', 40) + "\nOne of the given numbers is not valid!");
        }

    }
}

