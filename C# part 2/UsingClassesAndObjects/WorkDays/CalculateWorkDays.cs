/*
Problem 5. Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

class CalculateWorkDays
{
    public static double GetWorkingDays(DateTime startD, DateTime endD)
    {
        double calcBusinessDays =
            1 + ((endD - startD).TotalDays * 5 -
            (startD.DayOfWeek - endD.DayOfWeek) * 2) / 7;

        if ((int)endD.DayOfWeek == 6) calcBusinessDays--;
        if ((int)startD.DayOfWeek == 0) calcBusinessDays--;

        return calcBusinessDays;
    }

    static void Main()
    {
        DateTime today = DateTime.Today;
        Console.Write("Enter the date to which you want working days calculated: ");
        DateTime givenDate = DateTime.Parse(Console.ReadLine());

        if (today<givenDate)
        {
            Console.WriteLine("There are {0} working days till {1:dd,MM,yyyy}.", GetWorkingDays(today, givenDate), givenDate);
        }
        else
        {
            Console.WriteLine("There were {0} working days between {1:dd,MM,yyyy} and {2:dd,MM,yyyy}", -GetWorkingDays(today, givenDate), givenDate, today);
        }

    }
}

