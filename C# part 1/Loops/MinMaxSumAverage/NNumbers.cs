/*
Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
*/

using System;
using System.Linq;

class NNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want: ");
        int howBigInput = 0;
        bool isInputNumber = int.TryParse(Console.ReadLine(), out howBigInput);

        int[] numbers = new int[howBigInput];

        if (isInputNumber)
        {
            for (int i = 0; i < howBigInput; i++)
            {
                Console.Write("Number [{0}] = ", i);
                numbers[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("{0:F2} \n{1:F2} \n{2:F2} \n{3:F2}", numbers.Min(), numbers.Max(), numbers.Sum(), numbers.Average());
        }


    }
}

