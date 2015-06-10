/*
Problem 5. Formatting Numbers

Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.
*/

using System;

class Format
{
    static void Main()
    {
        int a = 0;
        bool isANumber = int.TryParse(Console.ReadLine(), out a);

        float b = 0f;
        bool isBNumber = float.TryParse(Console.ReadLine(), out b);

        float c = 0f;
        bool isCNumber = float.TryParse(Console.ReadLine(), out c);

        string AToString = Convert.ToString(a,2);

        if (isANumber && isBNumber && isCNumber)
        {
            Console.WriteLine("{0,-10}|{1}|{2,10:F2}|{3,-10:F2}|",Convert.ToString(a, 16), Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        }
    }
}

