/* 
Problem 8. Square Root

Create a console application that calculates and prints the square root of the number 12345.
Find in Internet “how to calculate square root in C#”.   */


using System;

class Root

{
    static void Main()
    {
        double squareRootNumber = Math.Sqrt(12345);
        /* This way is better because we can use the result(squareRootNumber) in other statements. 
        For example " int numberMultiply = squareRootNumber*12345; ". And then apply the new result(numberMultiply) in a statement. 
        For example " Console.WriteLine("The multiplication of {0} by 12345 is {1}", squareNumber, numberMultiply); "
        */

        Console.WriteLine("The square root of 12345 is {0}.", squareRootNumber);

        Console.ReadLine();
    }
}

