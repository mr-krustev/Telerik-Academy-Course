namespace CSharpTasks.EvenDifferences
{
    using System;
    using System.Linq;

    public class Catgorithm
    {
        //private static void Main()
        //{
        //    long[] inputNumbers = Console.ReadLine()
        //        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        //        .Select(long.Parse)
        //        .ToArray();

        //    long sumOfEvenResults = GetSumOfEvenDifferences(inputNumbers);
        //    Console.WriteLine(sumOfEvenResults);
        //}

        private static long GetSumOfEvenDifferences(long[] numbers)
        {
            long sumOfEvenResults = 0;

            for (int currentNumber = 1; currentNumber < numbers.Length;)
            {
                long absoluteDifferenceResult = Math.Abs(numbers[currentNumber] - numbers[currentNumber - 1]);

                if (absoluteDifferenceResult % 2 == 0)
                {
                    sumOfEvenResults += absoluteDifferenceResult;
                    currentNumber += 2;
                }
                else if (absoluteDifferenceResult % 2 == 1)
                {
                    currentNumber++;
                }
            }

            return sumOfEvenResults;
        }
    }
}
