/*
Problem 13. Check a Bit at Given Position

Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
*/

using System;

class OrIsNot
{
    static void Main()
    {
        Console.Write("Please write your number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please write the position you want to check: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> p;

        bool isOne = true;

        if (bit == 0)
        {
            isOne = false;
            Console.WriteLine("\nBit has value of 1 ---> " + isOne); 
        }
        else
        {
            Console.WriteLine("\nBit has value of 1 ---> " + isOne);
        }
    }
}

