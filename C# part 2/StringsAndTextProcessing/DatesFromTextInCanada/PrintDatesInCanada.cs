/*
Problem 19. Dates from text in Canada

Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class PrintDatesInCanada
{
    static void Main()
    {
        string[] inputText = Console.ReadLine().Split(' ');
        List<DateTime> dates = new List<DateTime>();

        foreach (string text in inputText)
        {
            DateTime temp;
            bool isDate = DateTime.TryParse(text, out temp);
            if (isDate)
            {
                dates.Add(temp);
            }
        }

        foreach (var date in dates)
        {
            CultureInfo canCult = new CultureInfo("fr-CA");
            Console.WriteLine(date.ToString(canCult));
        }

    }
}

