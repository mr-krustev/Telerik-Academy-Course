/*
Problem 7. Print First and Last Name

Create console application that prints your first and last name, each at a separate line.       */


using System;

class Program
{
    static void Main()
    {
        var name = "Albus";
        var lastname = "Dumbledore";

        Console.WriteLine("Click Enter to see who I am!");
            Console.ReadLine();
        Console.WriteLine("My first name is {0}!", name);
        Console.WriteLine("And my last name is {0}!", lastname);
            Console.ReadLine();
    }
}

