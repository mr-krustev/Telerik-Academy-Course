/*
Problem 4. Compare text files

Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
Assume the files have equal number of lines.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Compare
{
    private static string EqualLines(StreamReader readFirst, StreamReader readSecond)
    {
        int numberOfEqualLines = 0;
        using(readFirst)
        {
            using (readSecond)
            {
                string firstTextLine = readFirst.ReadLine();
                string secondTextLine = readSecond.ReadLine();

                while (firstTextLine != null && secondTextLine != null)
                {
                    if (firstTextLine == secondTextLine)
                    {
                        numberOfEqualLines++;
                    }

                    firstTextLine = readFirst.ReadLine();
                    secondTextLine = readSecond.ReadLine();
                }
            }
        }
        return numberOfEqualLines.ToString();
    }

    static void Main()
    {
        StreamReader readFirst = new StreamReader(@"..\..\FirstText.txt");
        StreamReader readSecond = new StreamReader(@"..\..\SecondText.txt");

        Console.WriteLine(EqualLines(readFirst,readSecond));
    }


}

