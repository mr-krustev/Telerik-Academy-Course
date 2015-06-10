/*
Problem 7. One system to any other

Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TotalConverter    // Hint: If you change the if in the Main method to <=36 and try to convert to d(secondSystem)= 36, it will work.
{
    static char[] number;


    static void AreSystemsDifferent(int firstSystem, int secondSystem)
    {
        if (firstSystem < secondSystem)
        {
            try
            {
                Console.WriteLine("Your number transformed is: {0}!\n", TransformToHigher(secondSystem, ConvertToDecimal(firstSystem, number)));
            }
            catch (Exception)
            {
                Console.WriteLine("Provided number's system is incorrect for the given number.\n");
            }
            
        }
        else if (firstSystem == secondSystem)
        {
            Console.WriteLine("Transforming from one system to the same system wouldn't bring a different result.\n");
        }
        else
        {
            try
            {
                Console.WriteLine("Your number transformed is: {0}\n!", TransformToLower(secondSystem, ConvertToDecimal(firstSystem, number)));
            }
            catch (Exception)
            {
                Console.WriteLine("Provided number's system is incorrect for the given number.\n");
            }           
        }
    }

    static long ConvertToDecimal(int system, char[] numberChars)
    {
        long decimalNumber = 0;
        int counter = 0;

        foreach (char item in numberChars)
        {
            if (item - '0' > system)
            {
                throw new Exception();
            }

            if (char.IsDigit(item) == true)
            {
                decimalNumber += (long)((item - '0') * Math.Pow(system, counter));
            }
            else if (char.IsLetter(item) == true)
            {
                decimalNumber += (long)((item - 'A' + 10) * Math.Pow(system, counter));
            }
            counter++;
        }
        return decimalNumber;
    }

    static StringBuilder TransformToHigher(int system, long number)
    {
        StringBuilder dTypeNumber = new StringBuilder();

        while (number > 0)
        {
            if (number % system >= 0 && number % system <= 9)
            {
                dTypeNumber.Insert(0, number % 16);
            }
            else
            {
                dTypeNumber.Insert(0, (char)(55 + number % system));        // Would work for system with all 26 letters.
            }
            number /= system;
        }

        return dTypeNumber;

    }

    static long TransformToLower(int system, long number)
    {
        List<long> binaryNumber = new List<long>();

        while (number > 0)
        {
            binaryNumber.Insert(0, number % system);
            number /= system;
        }

        long convertedNumber = long.Parse(string.Join("", binaryNumber));
        return convertedNumber;
    }

    static void Main()
    {
        Console.WriteLine("Number's system must be >= 2. Wanted system must be <= 16.\n" + new string('-',40));
        Console.Write("\nNumber to be transformed = ");
        number = Console.ReadLine().Reverse().ToArray();

        Console.WriteLine(new string('-',40));
        Console.Write("Please, enter number's system<ex. 2,8,10,16>: ");
        int firstSystem = int.Parse(Console.ReadLine());

        Console.Write("\nEnter wanted system<ex. 2,8,10,16): ");
        int secondSystem = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('-', 40));

        if (firstSystem >= 2 && secondSystem <= 16)
        {
            AreSystemsDifferent(firstSystem, secondSystem);
        }
        else
        {
            Console.WriteLine("One of the given systems is incorrect. Try again.\n");
        }
    }
}

