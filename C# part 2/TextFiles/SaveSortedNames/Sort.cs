/*
Problem 6. Save sorted names

Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Sort
{
    static void Main()
    {
        StreamReader readFile = new StreamReader(@"..\..\input.txt");
        StreamWriter writeFile = new StreamWriter(@"..\..\output.txt");

        WriteSortedNamesInFile(readFile, writeFile);
    }

    private static void WriteSortedNamesInFile(StreamReader readFile, StreamWriter writeFile)
    {

        using (writeFile)
        {
            List<string> sortedNames = new List<string>();

            using (readFile)
            {
                string line = readFile.ReadLine();
                while (line != null)
                {
                    sortedNames.Add(line);
                    line = readFile.ReadLine();
                }
            }

            sortedNames.Sort();

            for (int i = 0; i < sortedNames.Count; i++)
            {
                writeFile.WriteLine(sortedNames[i]);
            }
        }




    }
}
