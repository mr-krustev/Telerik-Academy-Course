/*
Problem 11.* Number as Words

Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
*/


using System;


class Words
{
    static void Main()
    {
        string input = Console.ReadLine();
        int number = 0;
        bool isNumber = int.TryParse(input, out number);
        int container = number;

        string[] smallNumbers = new string[10] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        string[] theTenNumbers = new string[10] { "Ten", "Eleven", "Twelve", "Thirtee", "Fourteen", "Fifteen", "Sixteen", "Seventee", "Eighteen", "Nineteen" };
        string[] bigNumbers = new string[10] {null, null, "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
        string[] biggestNumbers = new string[10] {null, "One hundred", "Two hundred", "Three hundred", "Four hundred", "Five hundred", "Six hundred", "Seven hundred", "Eight Hundred", "Nine hundred"};

        if (isNumber && number>0 && number < 1000)
        {


            if (number >= 0 && number <10 || number >= 20 && number<100 )
            {
                int b = number % 10;
                number /= 10;
                int a = number;

                Console.WriteLine("{0} {1}", bigNumbers[a], smallNumbers[b]);
            }
            else if (number >= 10 && number <20)
            {
                Console.WriteLine("{0}", theTenNumbers[number-10]);
            }
            else if (number >= 100 && number < 1000)
            {


                int c = number % 10;
                number /= 10;
                int b = number % 10;
                number /= 10;
                int a = number;

                if (b == 1)
                {
                    Console.WriteLine("{0} and {1}", biggestNumbers[a], theTenNumbers[(container - (a*100)) - 10]);
                }
                else if (c == 0)
                {
                    if (b == 0)
                    {
                        Console.WriteLine("{0}", biggestNumbers[a]);
                    }
                    else
                    {
                        Console.WriteLine("{0} and {1}", biggestNumbers[a], bigNumbers[b]);
                    }
                    
                }
                else
                {
                    Console.WriteLine("{0} and {1} {2}", biggestNumbers[a], bigNumbers[b], smallNumbers[c]);
                }
                
            }

        }
        else
        {
            Console.WriteLine("The input is invalid.");
        }
    }
}