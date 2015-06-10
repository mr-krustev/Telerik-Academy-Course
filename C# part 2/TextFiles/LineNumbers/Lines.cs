/*
Problem 3. Line numbers

Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Lines
{
    private static void WriteFile(StreamReader readText, StreamWriter writeText)
    {
        using (writeText)
        {
            using (readText)
            {
                string line = readText.ReadLine();
                int lineNumber = 1;
                while(line != null)
                {
                    writeText.WriteLine("{0}. {1}",lineNumber, line);
                    line = readText.ReadLine();
                    lineNumber++;
                }
            }
        }
    }

    static void Main()
    {
        // string filePath = Console.ReadLine();
        StreamReader readText = new StreamReader(@"..\..\Text.txt");    // @"{0}", filePath
        StreamWriter writeText = new StreamWriter(@"..\..\NewText.txt");
        // Creates the file in the program directory

        WriteFile(readText, writeText);
    }

}

