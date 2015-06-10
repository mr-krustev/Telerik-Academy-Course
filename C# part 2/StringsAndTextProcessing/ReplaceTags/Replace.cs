/*
Problem 15. Replace tags

Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Replace
{
    static void Main()
    {
        string html = Console.ReadLine();

        string html1 = "<a href=\"";
        string html2 = @""">";
        string html3 = "</a>";
        string url1 = "[URL=";
        string url2 = "]";
        string url3 = "[/URL]";

        while (html.Contains(html1))
        {
            html = html.Replace(html1, url1);
        }
        while (html.Contains(html2))
        {
            html = html.Replace(html2, url2);
        }
        while (html.Contains(html3))
        {
            html = html.Replace(html3, url3);
        }
            
        Console.WriteLine(html);
    }
}

