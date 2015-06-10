/*
Problem 11. Bitwise: Extract Bit #3

Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
*/

using System;

class ExtractBit
{
    static void Main()
    {
        int p = 3;
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> p;

        Console.WriteLine(bit);
    }
}

