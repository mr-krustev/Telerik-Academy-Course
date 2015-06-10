/*
Problem 8. Prime Number Check

Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
*/


using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Please enter an integer >= 2: ");
        int givenNumber = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;

        if (givenNumber > 0)
        {
            for (int i = 2; i <= Math.Sqrt(givenNumber); i++)
            {
                if (givenNumber % i == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(givenNumber + " is prime.");
            }
            else
            {
                Console.WriteLine(givenNumber + " is not prime.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer!");
        }

    }
}


