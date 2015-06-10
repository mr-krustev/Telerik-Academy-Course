/*
Problem 9. Matrix of Numbers

Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.
*/

using System;

class TheMatrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("1 <= n <= 20");
        Console.Write("n = ");
        int input = 0;
        bool isInputNumber = int.TryParse(Console.ReadLine(), out input);

        if (isInputNumber & 1 <= input & input <= 20)
        {

            for (int i = 1; i <= input; i++)
            {
                Console.Write(i + " ");

                for (int j = i + 1; j < input + i; j++)
                {
                    Console.Write(j + " ");
                    
                }
                Console.WriteLine();
            }


        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

