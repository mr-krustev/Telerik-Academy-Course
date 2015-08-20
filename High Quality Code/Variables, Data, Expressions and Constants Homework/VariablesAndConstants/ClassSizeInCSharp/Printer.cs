namespace CSharpTasks.TaskTwo
{
    using System;
    using System.Linq;

    public class Printer
    {
        public static void PrintStatistics(double[] numbers)
        {
            double avg = numbers.Average();
            PrintMax(avg);

            double min = numbers.Min();
            PrintMin(min);

            double max = numbers.Max();
            PrintAvg(max);
        }

        private static void PrintAvg(double avg)
        {
            Console.WriteLine("The average of the numbers is {0}.", avg);
        }

        private static void PrintMin(double min)
        {
            Console.WriteLine("The smallest number is {0}.", min);
        }

        private static void PrintMax(double max)
        {
            Console.WriteLine("The largest number is {0}.", max);
        }
    }
}
