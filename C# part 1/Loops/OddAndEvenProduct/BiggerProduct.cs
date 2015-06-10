/*
Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
*/

using System;
using System.Linq;

class BiggerProduct
{
    static void Main()
    {
        Console.Write("Enter your numbers: ");
        int[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        int counter = 1;
        int oddNumberProduct = 1;
        int evenNumberProduct = 1;


        foreach (int number in input)
        {

            if (counter % 2 != 0)
            {
                oddNumberProduct *= number;
            }
            else
            {
                evenNumberProduct *= number;
            }

            

            counter++;
        }

        Console.WriteLine("Is the even number's product bigger? ");
        if (evenNumberProduct >= oddNumberProduct)
        {
            Console.WriteLine("Yes!");
        }
        else
        {
            Console.WriteLine("No!");
        }


    }
}

