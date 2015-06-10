/*
Problem 7. Replace sub-string

Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Replace
{
    static void Main()
    {
        StreamReader readText = new StreamReader(@"..\..\text.txt");
        StreamWriter writeText = new StreamWriter(@"..\..\Output.txt");

        using (writeText)
        {
            using (readText)
            {
                string line;
                while ((line = readText.ReadLine()) != null)
                {
                    line = line.ToLower();
                    line = line.Replace("start", "finish");
                    writeText.WriteLine(line);
                }
            }
        }
    }
}

