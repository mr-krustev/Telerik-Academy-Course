/*
Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
*/

using System;

class RandomNumbers
{
    static void Main()
    {
        Console.Write("How many random numbers: ");
        int numbers = 0;
        bool isNumbers = int.TryParse(Console.ReadLine(), out numbers);

        Console.Write("Minimum number: ");
        int min = 0;
        bool isMinNumber = int.TryParse(Console.ReadLine(), out min);

        Console.Write("Maximum number: ");
        int max = 0;
        bool isMaxNumber = int.TryParse(Console.ReadLine(), out max);

        Random random = new Random();
        

         

        if (isNumbers & isMinNumber & isMaxNumber & min<max)
        {
            for (int i = 1; i <= numbers ; i++)
            {
                int generator = random.Next(min, max + 1);
                Console.WriteLine(generator);
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }


    }
}

