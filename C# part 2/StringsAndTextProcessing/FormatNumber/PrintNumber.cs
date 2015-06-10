/*
Problem 11. Format number

Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintNumber
{
    static void Main()
    {
        string inputNumber = Console.ReadLine();

        Console.WriteLine("{0,15:D}", inputNumber);
        Console.WriteLine("{0,15:X}", int.Parse(inputNumber));
        Console.WriteLine("{0,15:E}",inputNumber);
        Console.WriteLine("{0,15:P}", double.Parse(inputNumber)/100);



    }

}

