/*
Problem 6. String length

Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringTwentyChras
{
    static void Main()
    {
        string inputText = Console.ReadLine();

        if (inputText.Length > 20)
        {
            Console.WriteLine("Input should have less or equal to 20 symbols(including spaces)");
        }
        else if (inputText.Length == 20)
        {
            Console.WriteLine(inputText);
        }
        else
        {
            StringBuilder builder = new StringBuilder(inputText);

            for (int i = 0; i < 20 - builder.Length; i++)
            {
                builder.Append('*');
            }

            Console.WriteLine(builder.ToString());
        }
    }
}

