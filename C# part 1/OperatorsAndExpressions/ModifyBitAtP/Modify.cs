/*
Problem 14. Modify a Bit at Given Position

We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p 
from the binary representation of n while preserving all other bits in n.
*/

using System;


class Modify
{
    static void Main()
    {
        Console.Write("Please write your number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number,2));

        Console.Write("Please write the position you want to check: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Please give your bit number <0/1>: ");
        byte v = byte.Parse(Console.ReadLine());

        int mask;
        int numberAndMask;

        if (v == 1)
        {
            mask = 1 << p;
            numberAndMask = mask | number;
            Console.WriteLine(numberAndMask);
            Console.WriteLine(Convert.ToString(numberAndMask,2));
        }
        else if (v == 0)
        {
            mask = ~(1 << p);
            numberAndMask = mask & number;
            Console.WriteLine(numberAndMask);
            Console.WriteLine(Convert.ToString(numberAndMask, 2));
        }
        else
        {
            Console.WriteLine("Invalid input for v.");
        }
    }
}