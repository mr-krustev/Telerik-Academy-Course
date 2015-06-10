/*
Problem 5. Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7.
*/

using System;

class CheckIf
{
    static void Main()
    {
        Console.WriteLine("Please write your integer number: ");
        int a = int.Parse(Console.ReadLine());      // Note: If you put a number different from the range of –2,147,483,648 to 2,147,483,647 you can get system overflow.

        if (((a / 100) % 10) == 7)
        {
            Console.WriteLine("The given number has a 3rd digit from right-to-left equal to 7");
        }
        else
        {
            Console.WriteLine("The given number does not have a 3rd digit from right-to-left equal to 7");
        }

        Console.ReadLine();
    }
}

