/*
Problem 14. Decimal to Binary Number

Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
*/

using System;
using System.Linq;

class Transform
{
    static void Main()
    {
        int input = 0;
        bool isInputNumber = int.TryParse(Console.ReadLine(), out input);
        char[] binary = new char[Convert.ToString(input, 2).Length];
        int counter = 0;

        if (isInputNumber && input > -1)
        {
            for (int i = input; i >= 1;)
            {
                if (input == 1)
                {
                    binary[counter] = '1';
                }

                else if (input % 2 == 1)
                {
                    binary[counter] = '1';
                }
                else if (input % 2 == 0)
                {
                    binary[counter] = '0';
                }


                counter++;
                input /= 2;
                i /= 2;
            }


            for (int i = binary.Length - 1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }

            Console.WriteLine();

        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
        }
        
}

