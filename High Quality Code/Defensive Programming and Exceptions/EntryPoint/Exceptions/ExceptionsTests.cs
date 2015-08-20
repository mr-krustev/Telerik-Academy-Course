using EntryPoint.Exceptions.Common;
using System;
using System.Collections.Generic;
using System.Text;

public class ExceptionsTests
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        Validator.CheckIfNull<T[]>(arr, "Array");
        Validator.CheckIfNull<int>(startIndex, "StartIndex");
        Validator.CheckIfNull<int>(count, "Count");
        Validator.CheckIfEmptyArray(arr, "Array");
        Validator.CheckIfPositiveIntegerNumber(startIndex, "StartIndex");
        Validator.CheckIfPositiveIntegerNumber(count, "Count");

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }
        return result.ToArray();
    }

    public static string ExtractEnding(string input, int count)
    {
        Validator.CheckIfNull(input, "Input");
        Validator.CheckIfNull(count, "Count");
        Validator.CheckIfPositiveIntegerNumber(count, "Count");

        if (count > input.Length)
        {
            throw new ArgumentException("Count cannot be bigger than string's length.");
        }

        StringBuilder result = new StringBuilder();
        for (int i = input.Length - count; i < input.Length; i++)
        {
            result.Append(input[i]);
        }
        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        Validator.CheckIfNull<int>(number, "Number");

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                throw new ArgumentException("The number is not prime!");
            }
        }
    }
}
