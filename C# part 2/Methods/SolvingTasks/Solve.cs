/*
Problem 13. Solve tasks

Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solve
{

    static void Main()
    {
        string decision = "";
        while (decision != "end")
        {
            Console.WriteLine("Available commands: <Reverse, AverageOf, SolveLinear, End>");
            Console.Write("Task: ");
            decision = Console.ReadLine().ToLower();

            if (decision == "reverse" || decision == "1")
            {
                Task.ReverseNumber();
            }
            else if (decision == "averageof" || decision == "2")
            {
                try
                {
                    Task.AverageOfSequence();
                }
                catch (Exception)
                {
                    Console.WriteLine("\nCannot process empty sequence!");
                    Console.WriteLine(new string('-', 40));
                }
                
            }
            else if (decision == "solvelinear" || decision == "3")
            {
                try
                {
                    Task.SolveLinear();
                }
                catch (Exception)
                {                   
                    Console.WriteLine("A should not be equal to 0.");
                    Console.WriteLine(new string('-', 40));
                }               
            }
            else
            {
                Console.WriteLine(new string('-', 40));
            }
        }

        Console.WriteLine("Goodbye! :)");
    }
}

