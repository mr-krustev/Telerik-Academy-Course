/*
Problem 3. Compare char arrays

    Write a program that compares two char arrays lexicographically (letter by letter).
*/

using System;
using System.Linq;

class Lexicographically
{
    static void Main()
    {
        Console.Write("Enter your first text: ");
        string[] firstText = Console.ReadLine().Trim().Split(' ', '?', '!', '-', '.'); // Trim removes front and back free spaces. Split removes the given characters.
        Console.Write("Enter your second text: ");
        string[] secondText = Console.ReadLine().Trim().Split(' ', '?', '!', '-', '.');

        char[] firstArray = new char[firstText.Length];
        char[] secondArray = new char[secondText.Length];

        string firstTextNoSpace = string.Join("", firstText);               // Since there are no spaces etc, joins the text ( Pesho kara ski => Peshokaraski)
        string secondTextNoSpace = string.Join("", secondText);

        firstArray = firstTextNoSpace.ToCharArray();                    // Gets each character in the joined text and puts in the Array. (0) P, (1) e, (2) s ...
        secondArray = secondTextNoSpace.ToCharArray();


        Console.WriteLine(new string('-', 40));

        // Using Math.Min to determine the end of the comparing. If first one is 3 and second one is 4, we could get an exception. Since the first one won't have a 4th element.

        for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("The letter \"{0}\" in the first text is the same as the letter \"{1}\" in the second text.", firstArray[i], secondArray[i]);
            }
            else
            {
                Console.WriteLine("The letter \"{0}\" in the first text is different from the letter \"{1}\" in the second text.", firstArray[i], secondArray[i]);
            }
        }


        // If one of the inputs is longer, some letters won't have a counterpart.

        if (firstArray.Length > secondArray.Length)
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("First text has more input characters, therefore all remaining characters have no counterparts.");
            Console.WriteLine("Remaining characters: ");

            // Starts from the last char that wasn't shown and ends before the end of the array.

            for (int i = Math.Min(firstArray.Length, secondArray.Length); i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i] + ", ");
            }
            Console.WriteLine();
        }
        else if (secondArray.Length > firstArray.Length)
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Second text has more input characters, therefore all remaining characters have no counterparts.");
            Console.WriteLine("Remaining characters: ");

            // Starts from the last char that wasn't shown and ends before the end of the array.

            for (int i = Math.Min(firstArray.Length, secondArray.Length); i < secondArray.Length; i++)
            {
                Console.Write(secondArray[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}

