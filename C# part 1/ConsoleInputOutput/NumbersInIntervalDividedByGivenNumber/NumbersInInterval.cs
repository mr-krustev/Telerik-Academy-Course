/*
Problem 11.* Numbers in Interval Dividable by Given Number

Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
*/

using System;

class NumbersInInterval
{
    static void Main()
    {
        int a = 0;
        bool isANumber = int.TryParse(Console.ReadLine(), out a);

        int b = 0;
        bool isBNumber = int.TryParse(Console.ReadLine(), out b);

        if (isBNumber & isANumber)                              // Global "if" to check if imput is valid, if not says: "Invalid input!"
        {
            if (a >= b)                                         // a second "if" to check which number is bigger.
            {
                Console.Clear();
                Console.WriteLine("All numbers between {0} and {1} that are divisible by 5 are: ", a, b);
                for (int i = b; i <= a; i++)                    // for loop from the lower number to the bigger
                {
                    
                    if (i % 5 == 0)                             // if statement to check if disible by 5 with no reminder
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else if (b > a)
            {
                Console.Clear();
                Console.WriteLine("All numbers between {0} and {1} that are divisible by 5 are: ", b, a);
                for (int i = a; i <= b; i++)
                {
                    
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
        
    }
}

