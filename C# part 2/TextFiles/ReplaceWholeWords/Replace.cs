/*
Problem 8. Replace whole word

Modify the solution of the previous problem to replace only whole words (not strings).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

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
                    line = Regex.Replace(line, @"\bstart\b", "finish");
                    writeText.WriteLine(line);
                }
            }
        }
    }
}