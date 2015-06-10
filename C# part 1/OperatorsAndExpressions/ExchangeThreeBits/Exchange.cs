using System;


class Exchange
{
    static void Main()
    {
        Console.Write("Please enter a positive integer n: ");
        uint number = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine(number + " 32-bit binary: " + Convert.ToString(number, 2).PadLeft(32, '0'));

        for (int i = 3; i <= 5; i++)
        {
            int bit1 = (int)(number >> i) & 1;          // Moves the number to the right, so positions 0,1,2 -> 0,1,2,3 -> 0,1,2,3,4 disappear. Position 5(0/1) & 1 = 0/1
            int bit2 = (int)(number >> (21 + i)) & 1;   // Does the same thing but with the positions to 24 to 26.

            number = (uint)(number & (~(1 << (21+i))) | (bit1 << (21 + i))); // number & (~(1 << (21 + i))) makes the position

            number = (uint)(number & (~(1 << i)) | (bit2 << i));              // ~(1 << i)) | (bit2 << i) does the same thing here.
        }
        Console.WriteLine(number + " 32-bit binary: " + Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}

