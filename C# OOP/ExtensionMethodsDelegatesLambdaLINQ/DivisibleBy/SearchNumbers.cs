/*
Problem 6. Divisible by 7 and 3

Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
*/

namespace DivisibleBy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SearchNumbers
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 3, 4, 5, 1, 3, 12, 3412, 5, 612, 34, 5, 7 };

            var selectedNumbers =
                from n in numbers
                where n % 7 == 0 || n % 3 == 0
                select n;

            var lambdaSelected = numbers.Where(n => n % 3 == 0 || n % 7 == 0);

            Print(selectedNumbers);
        }

        private static void Print(IEnumerable<int> selectedNumbers)
        {
            foreach (var n in selectedNumbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
        }
    }
}
