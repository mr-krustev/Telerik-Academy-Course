/*
Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DigitAsWord
{
    static void GetNumber()
    {
        int number = 0;
        bool isNumber = int.TryParse(Console.ReadLine(), out number);

        if (isNumber)
        {           
            PrintLastDigitAsWord(number);
            Console.WriteLine(new string('-', 40));
        }
        else
        {
            Console.WriteLine("Invalid input. Try again!");
            Console.WriteLine(new string('-',40));
            GetNumber();
        }
    }

    static void PrintLastDigitAsWord(int number)
    {
        switch (number % 10)
        {
            case 0:
                Console.WriteLine("Zero");
                break;

            case 1:
                Console.WriteLine("One");
                break;

            case 2:
                Console.WriteLine("Two");
                break;

            case 3:
                Console.WriteLine("Three");
                break;

            case 4:
                Console.WriteLine("Four");
                break;

            case 5:
                Console.WriteLine("Five");
                break;

            case 6:
                Console.WriteLine("Six");
                break;

            case 7:
                Console.WriteLine("Seven");
                break;

            case 8:
                Console.WriteLine("Eight");
                break;

            case 9:
                Console.WriteLine("Nine");
                break;

            default:
                break;
        }


    }


    static void Main()
    {
        GetNumber();
    }
}

