/*
Problem 16. Decimal to Hexadecimal Number

Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
*/

using System;
using System.Linq;

class TheTransformation
{
    static void Main()
    {
        int input = 0;
        bool isInputNumber = int.TryParse(Console.ReadLine(), out input);

        char[] binary = new char[Convert.ToString(input, 16).Length];
        int counter = 0;

        if (isInputNumber && input > -1)
        {
            for (int i = input; i >= 1; )
            {

                switch (input % 16)
                {
                    case 0:
                        binary[counter] = '0';
                        break;

                    case 1:
                        binary[counter] = '1';
                        break;

                    case 2:
                        binary[counter] = '2';
                        break;

                    case 3:
                        binary[counter] = '3';
                        break;

                    case 4:
                        binary[counter] = '4';
                        break;

                    case 5:
                        binary[counter] = '5';
                        break;

                    case 6:
                        binary[counter] = '6';
                        break;

                    case 7:
                        binary[counter] = '7';
                        break;

                    case 8:
                        binary[counter] = '8';
                        break;

                    case 9:
                        binary[counter] = '9';
                        break;

                    case 10:
                        binary[counter] = 'A';
                        break;

                    case 11:
                        binary[counter] = 'B';
                        break;

                    case 12:
                        binary[counter] = 'C';
                        break;

                    case 13:
                        binary[counter] = 'D';
                        break;

                    case 14:
                        binary[counter] = 'E';
                        break;

                    case 15:
                        binary[counter] = 'F';
                        break;
                }

                counter++;
                input /= 16;
                i /= 16;
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



