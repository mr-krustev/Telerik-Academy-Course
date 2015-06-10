/*
Problem 1. Square root

Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HandleSQRT
{
    static void Main()
    {
        try
        {
            Console.Write("Enter an integer number: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0)
            {
                Console.WriteLine("\nSquare root = " + Math.Sqrt(number));
            }
            else
            {
                
            }
            
        }
        catch (Exception)
        {
            Console.WriteLine("\nInvalid number!");
        }
        finally
        {
            Console.WriteLine("\nGoodbye! :)");    
        }
        
    }
}

