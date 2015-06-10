/*
Problem 16. Date difference

Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GetDifference
{
    static void Main()
    {
        Console.WriteLine("Enter two dates in format day.month.year.\n" + new string('-',40));
        Console.Write("Enter first date: ");
        DateTime firstDate;
        bool isDate = DateTime.TryParse(Console.ReadLine(), out firstDate);

        if (!isDate)
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        Console.Write("Enter second date: ");
        DateTime secondDate;
        bool isSecondDate = DateTime.TryParse(Console.ReadLine(), out secondDate);

        if (!isSecondDate)
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        TimeSpan days = secondDate - firstDate;
        Console.WriteLine(Math.Abs(days.Days));
    }
}

