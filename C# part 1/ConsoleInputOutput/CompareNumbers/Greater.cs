/*
Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
*/


using System;

class Greater
{
    static void Main()
    {
        Console.Write("Provide a number: ");
        double firstNumber = 0;
        bool isFirstNumber = double.TryParse(Console.ReadLine(), out firstNumber);

        Console.Write("Provide a second number: ");
        double secondNumber = 0;
        bool isSecondNumber = double.TryParse(Console.ReadLine(), out secondNumber);

        Console.WriteLine("The bigger number is {0}!", Math.Max(firstNumber,secondNumber));

    }
}

