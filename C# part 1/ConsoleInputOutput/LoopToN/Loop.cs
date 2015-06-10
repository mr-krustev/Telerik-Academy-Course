/*
Problem 8. Numbers from 1 to n

Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
Note: You may need to use a for-loop.
*/

using System;

    class Loop
    {
        static void Main()
        {
            Console.Write("Enter your number: ");
            int n = 0;
            bool isNNumber = int.TryParse(Console.ReadLine(), out n);

            Console.Clear();
            Console.WriteLine("Interval (1-{0})\n" + new string('-', 40), n);
            for (int i = 1; i <= n; i++)
            {
                
                Console.WriteLine(i);
            }

        }
    }

