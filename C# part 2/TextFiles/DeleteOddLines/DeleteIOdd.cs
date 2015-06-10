/*
Problem 9. Delete odd lines

Write a program that deletes from given text file all odd lines.
The result should be in the same file.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class DeleteOdd
{


    static void Main()
    {

        List<string> text = new List<string>();

        using (StreamReader readText = new StreamReader(@"..\..\text.txt"))
        {
            string line = readText.ReadLine();
            while (line != null)
            {
                text.Add(line);
                line = readText.ReadLine();
            }
        }

        using (StreamWriter writeText = new StreamWriter(@"..\..\text.txt"))
        {
            text.Reverse();
            for (int i = text.Count - 1; i >= 0; i--)
            {
                if (i % 2 == 1)
                {
                    text.RemoveAt(i);
                }
                else
                {
                    writeText.WriteLine(text[i]);
                }
            }
        }

    }
}
