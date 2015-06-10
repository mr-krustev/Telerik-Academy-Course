/*
Problem 15. Hexadecimal to Decimal Number

Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
*/

using System;
using System.Linq;

class ChangeIt
{
    static void Main()
    {
        begin:

        Console.WriteLine("Provide your positive hexadecimal number: ");
        char[] input = Console.ReadLine().Reverse().ToArray();
        int counter = 0;
        double[] numbers = new double[input.Length];
        int numberCounter = 0;
        long sum = 0;

        foreach (char symbol in input)
        {
            if (symbol == '-')
            {
                Console.WriteLine("Provide positive number.");
                Console.WriteLine("Press enter to return.");
                Console.ReadLine();
                goto begin;

            }
            else
            {
                if (char.IsDigit(symbol) == true)
                {

                    numbers[numberCounter] = (symbol - '0') * Math.Pow(16, counter);
                    numberCounter++;
                }
                else
                {
                    switch (symbol)
                    {
                        case 'a':
                        case 'A':
                            numbers[numberCounter] = 10 * Math.Pow(16, counter);
                            break;

                        case 'b':
                        case 'B':
                            numbers[numberCounter] = 11 * Math.Pow(16, counter);
                            break;

                        case 'c':
                        case 'C':
                            numbers[numberCounter] = 12 * Math.Pow(16, counter);
                            break;

                        case 'd':
                        case 'D':
                            numbers[numberCounter] = 13 * Math.Pow(16, counter);
                            break;

                        case 'e':
                        case 'E':
                            numbers[numberCounter] = 14 * Math.Pow(16, counter);
                            break;

                        case 'f':
                        case 'F':
                            numbers[numberCounter] = 15 * Math.Pow(16, counter);
                            break;
                    }



                    numberCounter++;
                }




                counter++;
            }
            
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += (long)numbers[i];
        }

        Console.WriteLine(sum);
        
    }
}

