/*
Problem 3. Day of week

Write a program that prints to the console which day of the week is today.
Use System.DateTime.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

class PrintDay
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        DateTime now = DateTime.Now;

        Console.WriteLine("{0:dddd}", now);
    }
}

