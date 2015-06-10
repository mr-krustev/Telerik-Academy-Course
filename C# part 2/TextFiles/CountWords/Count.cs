/*
Problem 13. Count words

Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
Handle all possible exceptions in your methods.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

class Count
{
    static void Main()
    {
        try
        {
            using (StreamWriter writeText = new StreamWriter("..\\..\\output.txt"))
            {
                using (StreamReader readText = new StreamReader("..\\..\\input.txt"))
                {
                    string line;
                    string[] words = File.ReadAllLines("..\\..\\words.txt");
                    int[] values = new int[words.Length];

                    while ((line = readText.ReadLine()) != null)
                    {
                        line = line.ToLower();
                        for (int i = 0; i < words.Length; i++)
                        {
                            values[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                        }
                    }
                    Array.Sort(values, words);
                    for (int i = words.Length - 1; i >= 0; i--)
                    {
                        writeText.WriteLine("{0}: {1}", words[i], values[i]);
                    }
                }
            }
        }
        catch (FieldAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

