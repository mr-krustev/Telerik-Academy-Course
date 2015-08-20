using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntryPoint.Exceptions;

namespace EntryPoint
{
    public class EntryPoint
    {
        static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            AssertionTests.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            AssertionTests.SelectionSort(new int[0]); // Test sorting empty array
            AssertionTests.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(AssertionTests.BinarySearch(arr, -1000));
            Console.WriteLine(AssertionTests.BinarySearch(arr, 0));
            Console.WriteLine(AssertionTests.BinarySearch(arr, 17));
            Console.WriteLine(AssertionTests.BinarySearch(arr, 10));
            Console.WriteLine(AssertionTests.BinarySearch(arr, 1000));


            //Exceptions
            var substr = ExceptionsTests.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = ExceptionsTests.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = ExceptionsTests.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = ExceptionsTests.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            Console.WriteLine(ExceptionsTests.ExtractEnding("I love C#", 2));
            Console.WriteLine(ExceptionsTests.ExtractEnding("Nakov", 4));
            Console.WriteLine(ExceptionsTests.ExtractEnding("beer", 4));
            //Console.WriteLine(ExceptionsTests.ExtractEnding("Hi", 100));

            try
            {
                ExceptionsTests.CheckPrime(23);
                Console.WriteLine("23 is prime.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("23 is not prime");
            }

            try
            {
                ExceptionsTests.CheckPrime(33);
                Console.WriteLine("33 is prime.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("33 is not prime");
            }

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}
