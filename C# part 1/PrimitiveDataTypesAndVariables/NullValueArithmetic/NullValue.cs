/*
Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
*/


using System;

class NullValue
{
    static void Main()
    {
        int? withANull = null;
        double? WithANull = null;

        Console.WriteLine("Does this int have a " + withANull + "?"); // yes
        Console.WriteLine("\nDoes this double have a" + WithANull + " too?"); // yes

        withANull = 25;
        WithANull = 12.5;

        Console.WriteLine(new string('-', 40) + "\nThis int now equals " + withANull + "!");
        Console.WriteLine("\nThis double now is " + WithANull + "!");

        Console.ReadLine();
    }
}

