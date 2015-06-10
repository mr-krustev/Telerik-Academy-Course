/*
Problem 1. Declare Variables

Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
*/



using System;

class Declare
{
    static void Main()
    {
        ushort uShortNumber = 52130;
        sbyte sByteNumber = -115;
        long longNumber = 4825932;
        byte byteNumber = 97;
        short shortNumber = -10000;

        bool equal = (uShortNumber == 52130);           // The bool checks if the numbers are printed correctly.
        bool equalTwo = (sByteNumber == -115);
        bool equalThree = (longNumber == 4825932);
        bool equalFour = (byteNumber == 97);
        bool equalLast = (shortNumber == -10000);

        Console.WriteLine("The first number is " + uShortNumber + ".\n" + "\t" + equal);
        Console.WriteLine("The second one is " + sByteNumber + ".\n" + "\t" + equalTwo);
        Console.WriteLine("Third number equals " + longNumber + ".\n" + "\t" + equalThree);
        Console.WriteLine("The fourth number is " + byteNumber + ".\n" + "\t" + equalFour);
        Console.WriteLine("The last one is " + shortNumber + ".\n" + "\t" + equalLast);

        Console.ReadLine();


    }
}
