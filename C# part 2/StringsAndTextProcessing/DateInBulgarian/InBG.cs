/*
Problem 17. Date in Bulgarian

Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class InBG
{
    static void Main()
    {
        Console.WriteLine("Enter two dates in format day.month.year hour:minute:second.\n" + new string('-', 40));
        Console.Write("Enter your date: ");
        DateTime date;
        bool isDate = DateTime.TryParse(Console.ReadLine(), out date);       
        CultureInfo bgCult = new CultureInfo("bg-BG");

        Console.WriteLine("{0:dd.MM.yyyy} {1:hh:mm:ss} {2}", date,date.AddHours(6.5), date.ToString("dddd", bgCult));
    }
}

