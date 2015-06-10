/*
Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
*/

using System;

class Playful
{
    static void Main()
    {
        Console.WindowWidth = 50;
        Console.WindowHeight = 20;
        
        Console.Write("1 ------> integer \n2 ------> double \n3 ------> string \nChoose one of the above for your input: ");
        byte input = 0;
        bool isInputNumber = byte.TryParse(Console.ReadLine(), out input);

        switch (input)
        {
            case 1:

                Console.Write("Please enter an integer: ");
                int number = 0;
                bool isNumber = int.TryParse(Console.ReadLine(), out number);

                if (isNumber)
                {
                    Console.WriteLine(number + 1);    
                }

                break;

            case 2:

                Console.Write("Please enter a number of type \"double\": ");
                double doubleNumber = 0;
                bool isDoubleNumber = double.TryParse(Console.ReadLine(), out doubleNumber);

                if (isDoubleNumber)
                {
                    Console.WriteLine(doubleNumber + 1);    
                }

                break;

            case 3:

                Console.Write("Enter your text: ");
                string text = Console.ReadLine();

                Console.WriteLine(text +'*');

                break;


            default:
                Console.WriteLine("Invalid input.");
                break;
        }
    }
}

