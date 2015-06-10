/*
Problem 2. Concatenate text files

Write a program that concatenates two text files into another text file.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Concatenate
{
    private static void AddFirstText(List<string> bothTexts, StreamReader readFirst)
    {
        using (readFirst)
        {
            string tempLine = readFirst.ReadLine();
            while (tempLine != null)
            {
                bothTexts.Add(tempLine);
                tempLine = readFirst.ReadLine();
            }           
        }
    }

    private static void AddSecondText(List<string> bothTexts, StreamReader readSecond)
    {
        using (readSecond)
        {
            string tempLine = readSecond.ReadLine();
            while (tempLine != null)
            {
                bothTexts.Add(tempLine);
                tempLine = readSecond.ReadLine();
            }
        }
    }

    private static void WriteTextInFile(List<string> bothTexts, StreamWriter writeConcatenated)
    {
        using (writeConcatenated)
        {
            for (int i = 0; i < bothTexts.Count; i++)
            {
                writeConcatenated.WriteLine(bothTexts[i]);
            }
        }
    }

    static void Main()
    {
        // string filePath = Console.ReadLine();
        StreamReader readFirst = new StreamReader(@"..\..\FirstText.txt"); // @"{0}", filePath
        StreamReader readSecond = new StreamReader(@"..\..\SecondText.txt");
        StreamWriter writeConcatenated = new StreamWriter(@"..\..\Concatenated.txt");

        List<string> bothTexts = new List<string>();

        AddFirstText(bothTexts,readFirst);
        AddSecondText(bothTexts, readSecond);
        WriteTextInFile(bothTexts, writeConcatenated);
    }
}

