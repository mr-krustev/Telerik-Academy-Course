/*
Problem 1. StringBuilder.Substring

Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.

Problem 2. IEnumerable extensions

Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
*/

namespace Extend
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Start
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder("DECATA SIGURNO SA POLUDELI");

            Console.WriteLine(text.Substring(7,7));

            List<int> testList = new List<int>();
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);

            Console.WriteLine(testList.Sum());
            Console.WriteLine(testList.Product());
            Console.WriteLine(testList.Average());
            Console.WriteLine(testList.Min());
            Console.WriteLine(testList.Max());

        }
    }
}
