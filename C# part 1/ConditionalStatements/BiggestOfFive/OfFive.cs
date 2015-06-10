/*
Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.
*/

using System;

class OfFive
{
    static void Main()
    {
        Console.WindowWidth = 50;
        Console.WindowHeight = 20;

        double firstNumber = 0;
        double secondNumber = 0;
        double thirdNumber = 0;
        double fourthNumber = 0;
        double fifthNumber = 0;

        Console.Write("Enter the first number: ");
        bool isANumber = double.TryParse(Console.ReadLine(), out firstNumber);
        Console.Write("Enter the second number: ");
        bool isBnumber = double.TryParse(Console.ReadLine(), out secondNumber);
        Console.Write("Enter the third number: ");
        bool isCNumber = double.TryParse(Console.ReadLine(), out thirdNumber);
        Console.Write("Enter the fourth number: ");
        bool isDNumber = double.TryParse(Console.ReadLine(), out fourthNumber);
        Console.Write("Enter the fifth number: ");
        bool isENumber = double.TryParse(Console.ReadLine(), out fifthNumber);


        if (firstNumber > secondNumber & firstNumber > thirdNumber & firstNumber > fourthNumber & firstNumber > fifthNumber)
        {
            Console.WriteLine("The biggest number is {0}", firstNumber);
        }
        else if (secondNumber > firstNumber & secondNumber > thirdNumber & secondNumber > fourthNumber & secondNumber > fifthNumber)
        {
            Console.WriteLine("The biggest number is {0}", secondNumber);
        }
        else if (thirdNumber > firstNumber & thirdNumber > secondNumber & thirdNumber > fourthNumber & thirdNumber > fifthNumber)
        {
            Console.WriteLine("The biggest number is {0}", thirdNumber);
        }
        else if (fourthNumber > firstNumber & fourthNumber > secondNumber & fourthNumber > thirdNumber & fourthNumber > fifthNumber)
        {
            Console.WriteLine("The biggest number is {0}", fourthNumber);
        }
        else if (fifthNumber > firstNumber & fifthNumber > secondNumber & fifthNumber > thirdNumber & fifthNumber > fourthNumber)
        {
            Console.WriteLine("The biggest number is {0}", fifthNumber);
        }
    }
}

