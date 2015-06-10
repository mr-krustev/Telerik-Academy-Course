/*
Problem 2. Float or Double?

Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost.
*/

using System;

class FloatDouble
{
    static void Main()
    {
        double numberTypeDouble = 34.567839023;
        float numberTypeFloat = 12.345f;
        double NumberTypeDouble = 8923.1234857;
        float NumberTypeFloat = 3456.091f;

        bool checkNumber = (numberTypeDouble == 34.567839023);      // The bool checks if the numbers are printed correctly... again.
        bool checkSecondNumber = (numberTypeFloat == 12.345f);
        bool checkThirdNumber = (NumberTypeDouble == 8923.1234857);
        bool checkLastNumber = (NumberTypeFloat == 3456.091f);
        

        Console.WriteLine("34.567839023 equals {0}", numberTypeDouble + ".\n \t" + checkNumber);
        Console.WriteLine("12.345 equals {0}", numberTypeFloat + ".\n \t" + checkSecondNumber);
        Console.WriteLine("8923.1234857 equals {0}", NumberTypeDouble + ".\n \t" + checkThirdNumber);
        Console.WriteLine("3456.091 equals {0}", NumberTypeFloat + ".\n \t" + checkLastNumber);

        Console.ReadLine();

    }
}

