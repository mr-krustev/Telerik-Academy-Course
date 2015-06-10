/*
Problem 2. Enter numbers

Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HandleNumbers
{
    static Random generator = new Random();
    static List<int> numbers = new List<int>();

    static void ReadNumber(int start,int end)
    {
        int number = int.Parse(Console.ReadLine());

        if (number >= start && number <= end)
        {
            numbers.Add(number);
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }


    static void Main()
    {
        Console.WriteLine("Define the range for numbers <start-end>: \n" + new string('-',40));
        Console.Write("Enter starting point: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter ending point: ");
        int end = int.Parse(Console.ReadLine());

        for (int i = 0; i < 10; i++)
        {
            try
            {
                ReadNumber(start, end);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nYou should enter a number.");
                break;
            }
            catch(OverflowException)
            {
                Console.WriteLine("Given number is too big for integer's capacity. Should be more than -2 million and less than 2 million");
                break;
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Given number is outside the given range.");
                break;
            }
        }
    }
}

