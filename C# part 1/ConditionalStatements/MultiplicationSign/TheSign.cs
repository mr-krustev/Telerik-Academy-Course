/*
Problem 4. Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
*/

using System;

class TheSign
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
            if (firstNumber * secondNumber * thirdNumber > 0)
            {
                Console.WriteLine('+');
            }
            else if (firstNumber * secondNumber * thirdNumber == 0)
            {
                Console.WriteLine('0');
            }
            else if (firstNumber * secondNumber * thirdNumber < 0)
            {
                Console.WriteLine('-');
            }
        }
        else
        {
            Console.WriteLine("One of the given numbers is invalid!");
        }
        
    }
}

