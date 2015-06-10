using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractTextFromHtml
{
    class ExtractText
    {
        static void Main()
        {
            string input = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik " +
                           "Academy</a>aims to provide free real-world practical training for young people who want to " +
                           "turn into skilful .NET software engineers.</p></body></html>";

            string text = input.Replace("<title>", "Title: ").Replace("<body>", "\n\nText: ").Replace("</a>", " ");

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    do
                    {
                        result.Append("");
                        i++;
                    }
                    while (text[i] != '>');
                }
                else
                {
                    result.Append(text[i]);
                }
            }

            Console.WriteLine(result + "\n");
        }
    }
}
