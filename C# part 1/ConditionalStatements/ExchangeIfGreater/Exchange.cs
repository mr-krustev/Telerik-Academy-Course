/*
Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
*/


using System;

class Exchange
{
    static void Main()
    {
        Console.WindowWidth = 50;
        Console.WindowHeight = 20;

        Console.Write("Write your first number: ");
        double firstNumber = 0;
        bool isANumber = double.TryParse(Console.ReadLine(), out firstNumber);

        Console.Write("Write your second number: ");
        double secondNumber
            = 0;
        bool isBNumber = double.TryParse(Console.ReadLine(), out secondNumber);
        double container = 0;

        if (isANumber & isBNumber)
        {
            if (firstNumber >= secondNumber)
            {
                container = firstNumber;
                firstNumber = secondNumber;
                secondNumber = container;
                Console.WriteLine("{0} {1}", firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("{0} {1}", firstNumber, secondNumber);
            }
        }
        else
        {
            Console.WriteLine("At least one of the imputs is not valid.");
        }
        
    }
}
