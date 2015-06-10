/*
Problem 8. Binary short

Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ShowBinary
{
    static void Main()
    {
        short number = 0;
        bool numberIsNegative = false;

        Console.Write("Enter a number<-32768,32767>: ");
        try
        {
            number = short.Parse(Console.ReadLine());
        }
        catch (System.OverflowException)
        {
            Console.WriteLine("Type <short> cannot contain bigger numbers outside (-32,768,32,767).");
            return;
        }
       
        if (number < 0)
        {
            number = Math.Abs(number);
            numberIsNegative = true;
        }

        List<int> binaryNumber = new List<int>();
        while (number > 0)
        {

            binaryNumber.Insert(0, number % 2);
            number /= 2;
        }

        if (numberIsNegative)
        {
            Console.WriteLine("Binary representation of your number({0}) = -" + string.Join("", binaryNumber), number);
        }
        else
        {
            Console.WriteLine("Binary representation of your number({0}) = " + string.Join("", binaryNumber), number);
        }
        

    }
}

