/*
Problem 20. Palindromes

Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class GetPalindromes
{
    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        string[] wordsFromText = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> palindromes = new List<string>();

        for (int i = 0; i < wordsFromText.Length; i++)
        {
            bool isPalindrome = true;
            for (int j = 0; j < wordsFromText[i].Length / 2; j++)
            {
                if (wordsFromText[i][j] != wordsFromText[i][wordsFromText[i].Length - 1 - j])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome && wordsFromText[i].Length > 1)
            {
                palindromes.Add(wordsFromText[i]);
            }
        }
        Console.WriteLine("\nPalindromes\n" + new string('-', 40), "\n");
        int counter = 0;
        foreach (var item in palindromes)
        {
            counter++;
            Console.WriteLine("{0}." + item, counter);
        }
    }
}

