/*
Problem 12. Extract Bit from Integer

Write an expression that extracts from given integer n the value of given bit at index p.
*/


using System;

class Extract
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

        Console.WriteLine("The bit @ p is : {0}", bit);
    }
}

