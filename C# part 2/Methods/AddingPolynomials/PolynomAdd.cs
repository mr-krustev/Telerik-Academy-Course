/*
Problem 11. Adding polynomials

Write a method that adds two polynomials.
Represent them as arrays of their coefficients.
Example:

x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AddPolynom
{
    static int[] firstPolynomial;
    static int[] secondPolynomial;
    static int[] sumOfPolynomials;


    static int[] FillArray(int[] array)
    {
        Console.WriteLine(new string('-',40));
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
            sumOfPolynomials[i] = firstArray[i] + secondArray[i];
        }

        if (firstArray.Length != secondArray.Length)
        {
            for (int i = Math.Min(firstArray.Length, secondArray.Length); i < sumOfPolynomials.Length; i++)
            {
                if (firstArray.Length > secondArray.Length)
                {
                    sumOfPolynomials[i] = firstArray[i];
                }
                else
                {
                    sumOfPolynomials[i] = secondArray[i];
                }
            }
        }
    }

    static void PrintArray(int[] array)
    {
        for (int i = array.Length - 1; i >= 0 ; i--)
        {
            if (i - 1 < 0)
            {
                Console.WriteLine(array[i] + "x^{0}",i);
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

        sumOfPolynomials = new int[Math.Max(firstPolynomial.Length, secondPolynomial.Length)];
        GetSum(firstPolynomial, secondPolynomial);

        PrintArray(firstPolynomial);
        Console.WriteLine("+");
        PrintArray(secondPolynomial);
        Console.WriteLine(new string('-', 40));
        PrintArray(sumOfPolynomials);
    }
}

