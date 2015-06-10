/*
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

    public static class IEnumerableExtension
    {

        public static double Sum<T>(this IEnumerable<T> numbers)
        {
            var result = 0.0;

            foreach (var item in numbers)
            {
                result += Convert.ToDouble(item);
            }

            return result;
        }

        public static double Product<T>(this IEnumerable<T> numbers)
        {
            var result = 1.0;

            foreach (var item in numbers)
            {
                result *= Convert.ToDouble(item);
            }

            return result;
        }

        public static double Min<T>(this IEnumerable<T> numbers)
        {
            var minNumber = double.MaxValue;

            foreach (var item in numbers)
            {
                double number = Convert.ToDouble(item);
                
                if(number < minNumber)
                {
                    minNumber = number;
                }

            }

            return minNumber;
        }

        public static double Max<T>(this IEnumerable<T> numbers)
        {
            var maxNumber = double.MinValue;

            foreach (var item in numbers)
            {
                double number = Convert.ToDouble(item);

                if (number > maxNumber)
                {
                    maxNumber = number;
                }

            }

            return maxNumber;
        }

        public static double Average<T>(this IEnumerable<T> numbers)
        {
            var result = 0.0;
            var count = 0;

            foreach (var item in numbers)
            {
                result += Convert.ToDouble(item);
                count++;
            }

            return result/count;
        }
    }
}
