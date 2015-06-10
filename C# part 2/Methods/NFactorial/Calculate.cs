/*
Problem 10. N Factorial

Write a program to calculate n! for each n in the range [1..100].
Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Calculate
{
    static int number;
    static BigInteger[] factorialsInArray;

    static void GetAllFactorials()
    {
        for (int i = 0; i < factorialsInArray.Length; i++)
        {
            BigInteger factorial = 1;
            for (int j = 1; j < i+2; j++)
            {
                factorial *= j;
            }

            factorialsInArray[i] = factorial;
        }
    }

    static void Main()
    {
        Console.Write("Enter the range of factorials you want me to calculate: ");
        number = int.Parse(Console.ReadLine());
        factorialsInArray = new BigInteger[number];
        GetAllFactorials();
        
        string stayInWhile = "";

        while (stayInWhile != "end")
        {
            Console.WriteLine(new string('-',40));
            Console.WriteLine("Write \"end\" to stop the program.");
            Console.Write("Check factorial of number: ");
            stayInWhile = Console.ReadLine();
            int checkPositionFactorial = 0;
            bool inputIsNumber = int.TryParse(stayInWhile, out checkPositionFactorial);

            if (inputIsNumber && checkPositionFactorial <= factorialsInArray.Length)
            {
                Console.WriteLine(factorialsInArray[checkPositionFactorial-1]);
            }
            else if (inputIsNumber && checkPositionFactorial > factorialsInArray.Length)
            {
                Console.WriteLine("This number does not have that factorial!");
            }
            
        }

        Console.WriteLine(new string('-',40) + "\nGoodbye! :)");
    }
}

