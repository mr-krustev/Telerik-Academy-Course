/*
Problem 1. Say Hello

Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SayHi
{
    static void GreetUser(string userName)
    {
        Console.WriteLine();
        Console.WriteLine("Hello, {0}!", userName);
    }

    static string EnterName()
    {
        Console.WriteLine(new string('-', 40));
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        CheckUserName(userName);
        return userName;
    }

    static void CheckUserName(string userName)
    {
        if (userName.Length > 0)
        {
            if (userName.Length == 1)
            {
            Answer:
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("You have provided a name with only ONE symbol. Is this your name?<y/n>");
                string check = Console.ReadLine();
                Console.WriteLine();
                if (check == "y")
                {
                    GreetUser(userName);
                }
                else if (check == "n")
                {
                    Console.WriteLine("Please enter your name correctly!");
                    EnterName();
                }
                else
                {
                    Console.WriteLine("Your answer should be either \"y\" or \"n\".");
                    goto Answer;
                }
            }
            else
            {
                GreetUser(userName);
            }

        }
        else
        {
            Console.WriteLine("Provide a name, please!");
            EnterName();
        }

    }

    static void Main()
    {
        string userName = EnterName();
    }
}

