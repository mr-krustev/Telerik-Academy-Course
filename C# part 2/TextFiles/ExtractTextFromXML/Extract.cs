using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class Extract
{
    static void Main(string[] args)
    {
        using (StreamReader sr = new StreamReader("..\\..\\TextInXML.xml"))
        {
            string line;
            string words = string.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '<')
                    {
                        while (line[i] != '>')
                        {
                            i++;
                            continue;
                        }
                    }
                    else
                    {
                        words += line[i];
                        if (line[i + 1] == '<')
                        {
                            Console.WriteLine(words);
                            words = "";
                        }
                    }
                }
            }
        }
    }
}

