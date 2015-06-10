/*
Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
*/

using System;

class WithNested
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
        {                                                                   // This also works: 
            if (firstNumber >= secondNumber & firstNumber >= thirdNumber)     //if (Math.Max(Math.Max(firstNumber,secondNumber), Math.Max(secondNumber,thirdNumber)) == firstNumber)
            {
                if ((thirdNumber>secondNumber & firstNumber >=thirdNumber) || (thirdNumber >= secondNumber))
                {
                    Console.WriteLine(firstNumber + " " + thirdNumber + " " + secondNumber);
                }
                else if ((secondNumber > thirdNumber & firstNumber >= secondNumber) || (firstNumber >= secondNumber & thirdNumber >= secondNumber))
                {
                    Console.WriteLine(firstNumber + " " + secondNumber + " " + thirdNumber);
                }
            }

            else if (secondNumber >= firstNumber & secondNumber >= thirdNumber)               
            {
                if (firstNumber>=thirdNumber)
                {
                    Console.WriteLine(secondNumber + " " + firstNumber + " " + thirdNumber);
                }
                else if (thirdNumber>firstNumber)
                {
                    Console.WriteLine(secondNumber + " " + thirdNumber + " " + firstNumber);
                }
            }

            else if (thirdNumber >= firstNumber & thirdNumber >= secondNumber)
            {
                if (firstNumber>= secondNumber)
                {
                    Console.WriteLine(thirdNumber + " " + firstNumber + " " + secondNumber);
                }
                else if (secondNumber>firstNumber)
                {
                    Console.WriteLine(thirdNumber + " " + secondNumber + " " + firstNumber);
                }
            }
        }
        else
        {
            Console.WriteLine("One of the three numbers is not a valid input!");
        }
    }
}

