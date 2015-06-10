/*
Problem 12. Remove words

Write a program that removes from a text file all words listed in given another text file.
Handle all possible exceptions in your methods.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

class Remove
{
    static void Main()
    {
        try
        {
            using (StreamWriter removeForbWords = new StreamWriter("..\\..\\test.txt"))
            {
                using (StreamReader readTheText = new StreamReader("..\\..\\ImportantText.txt"))
                {
                    string line;
                    string regex = @"\b(" + String.Join("|", File.ReadAllLines("..\\..\\ForbiddenWords.txt")) + @")\b";
                    while ((line = readTheText.ReadLine()) != null)
                    {
                        line = line.ToLower();
                        line = Regex.Replace(line, regex, string.Empty);
                        removeForbWords.WriteLine(line);
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

