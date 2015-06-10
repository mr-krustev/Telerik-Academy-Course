/*
Problem 12. Subtracting polynomials

Extend the previous program to support also subtraction and multiplication of polynomials.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PolynActions
{
    static int[] firstPolynomial;
    static int[] secondPolynomial;
    static int[] actionOfPolynomials;


    static int[] FillArray(int[] array)
    {
        Console.WriteLine(new string('-', 40));
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("x^{0} = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static void GetSum(int[] firstArray, int[] secondArray)
    {
        for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
        {
            actionOfPolynomials[i] = firstArray[i] + secondArray[i];
        }

        if (firstArray.Length != secondArray.Length)
        {
            for (int i = Math.Min(firstArray.Length, secondArray.Length); i < actionOfPolynomials.Length; i++)
            {
                if (firstArray.Length > secondArray.Length)
                {
                    actionOfPolynomials[i] = firstArray[i];
                }
                else
                {
                    actionOfPolynomials[i] = secondArray[i];
                }
            }
        }
    }

    static void GetSubtract(int[] firstArray, int[] secondArray)
    {
        for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
        {
            actionOfPolynomials[i] = firstArray[i] - secondArray[i];
        }

        if (firstArray.Length != secondArray.Length)
        {
            for (int i = Math.Min(firstArray.Length, secondArray.Length); i < actionOfPolynomials.Length; i++)
            {
                if (firstArray.Length > secondArray.Length)
                {
                    actionOfPolynomials[i] = firstArray[i];
                }
                else
                {
                    actionOfPolynomials[i] = secondArray[i];
                }
            }
        }
    }

    static void GetMultiplication(int[] firstArray,int[] secondArray)
    {
        for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
        {
            actionOfPolynomials[i] = firstArray[i] * secondArray[i];
        }

        if (firstArray.Length != secondArray.Length)
        {
            for (int i = Math.Min(firstArray.Length, secondArray.Length); i < actionOfPolynomials.Length; i++)
            {
                if (firstArray.Length > secondArray.Length)
                {
                    actionOfPolynomials[i] = firstArray[i];
                }
                else
                {
                    actionOfPolynomials[i] = secondArray[i];
                }
            }
        }
    }

    static void PrintArray(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (i - 1 < 0)
            {
                Console.WriteLine(array[i] + "x^{0}", i);
            }
            else
            {
                Console.Write(array[i] + "x^{0} + ", i);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter maximum degree(x^?) for the first polynomial: ");
        int firstPolynomSize = int.Parse(Console.ReadLine());
        firstPolynomial = new int[firstPolynomSize];
        firstPolynomial = FillArray(firstPolynomial);
        Console.WriteLine(new string('-', 40));

        Console.Write("Enter maximum degree(x^?) for the second polynomial: ");
        int secondPolynomSize = int.Parse(Console.ReadLine());
        secondPolynomial = new int[secondPolynomSize];
        secondPolynomial = FillArray(secondPolynomial);
        Console.WriteLine(new string('-', 40));

        actionOfPolynomials = new int[Math.Max(firstPolynomial.Length, secondPolynomial.Length)];

        Console.Write("Choose an action for the polynomials<sum,subtr,multip>: ");
        string actionTaken = Console.ReadLine();

        if (actionTaken == "sum")
        {
            GetSum(firstPolynomial, secondPolynomial);

            PrintArray(firstPolynomial);
            Console.WriteLine("+");
            PrintArray(secondPolynomial);
            Console.WriteLine(new string('-', 40));
            PrintArray(actionOfPolynomials);
        }
        else if (actionTaken == "subtr")
        {
            GetSubtract(firstPolynomial, secondPolynomial);

            PrintArray(firstPolynomial);
            Console.WriteLine("-");
            PrintArray(secondPolynomial);
            Console.WriteLine(new string('-', 40));
            PrintArray(actionOfPolynomials);
        }
        else if (actionTaken == "multip")
        {
            GetMultiplication(firstPolynomial, secondPolynomial);

            PrintArray(firstPolynomial);
            Console.WriteLine("*");
            PrintArray(secondPolynomial);
            Console.WriteLine(new string('-', 40));
            PrintArray(actionOfPolynomials);
        }
        else
        {
            Console.WriteLine("Wrong input, try again!");       
        }
    }
}
