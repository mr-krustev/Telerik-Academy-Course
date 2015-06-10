/*
Problem 8. Digit as Word

Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid input.
Use a switch statement.
*/

using System;

class DigitWord
{
    static void Main()
    {
        Console.WindowWidth = 50;
        Console.WindowHeight = 20;


        Console.Write("Please write a number<0-9>:");
        string input = Console.ReadLine();
        

        switch (input)
        {
            case "0":
                Console.WriteLine("Zero");
                break;
            
            case "1":
                Console.WriteLine("One");
                break;

            case "2":
                Console.WriteLine("Two");
                break;

            case "3":
                Console.WriteLine("Three");
                break;

            case "4":
                Console.WriteLine("Four");
                break;

            case "5":
                Console.WriteLine("Five");
                break;

            case "6":
                Console.WriteLine("Six");
                break;

            case "7":
                Console.WriteLine("Seven");
                break;

            case "8":
                Console.WriteLine("Eight");
                break;

            case "9":
                Console.WriteLine("Nine");
                break;

            default:
                Console.WriteLine("Not a digit or outside the interval.");
                break;
        }

        // This was my initial solution. It uses a "bool-if" statement to check if the input is a number and then proceeds to "switch"
        // I had to use the "if" because the console counts letters as equal to 0. If you were to input "hi" the result would be "Zero". Which is wrong.
        
        //Console.Write("Please write a number<0-9>:");
        //byte input;
        //bool isInputNumber = byte.TryParse(Console.ReadLine(), out input);

        //if (isInputNumber)
        //{
        //    switch (input)
        //    {
        //        case 0:
        //            Console.WriteLine("Zero");
        //            break;

        //        case 1:
        //            Console.WriteLine("One");
        //            break;

        //        case 2:
        //            Console.WriteLine("Two");
        //            break;

        //        case 3:
        //            Console.WriteLine("Three");
        //            break;

        //        case 4:
        //            Console.WriteLine("Four");
        //            break;

        //        case 5:
        //            Console.WriteLine("Five");
        //            break;

        //        case 6:
        //            Console.WriteLine("Six");
        //            break;

        //        case 7:
        //            Console.WriteLine("Seven");
        //            break;

        //        case 8:
        //            Console.WriteLine("Eight");
        //            break;

        //        case 9:
        //            Console.WriteLine("Nine");
        //            break;

        //        default:
        //            Console.WriteLine("Outside the given interval.");
        //            break;
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Not a digit!");
        //}
    }
}

