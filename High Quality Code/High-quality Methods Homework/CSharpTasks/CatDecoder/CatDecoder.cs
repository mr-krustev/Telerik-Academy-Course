namespace CSharpTasks.CatDecoder
{
    using System;
    using System.Linq;
    using System.Text;

    public class CatDecoder
    {
        private static long ConvertFromCatSystemToDecimalSystem(int system, string number)
        {
            char[] digitsAsChars = number.Reverse().ToArray();

            long decimalNumber = 0;
            int counter = 0;

            foreach (char item in digitsAsChars)
            {
                if (char.IsLetter(item) == true)
                {
                    decimalNumber += (long)((item - 'a') * Math.Pow(system, counter));
                }

                counter++;
            }

            return decimalNumber;
        }

        private static StringBuilder ConvertToHigherNumberSystem(int system, long number)
        {
            var currentNumber = number;
            StringBuilder convertedNumber = new StringBuilder();

            while (currentNumber > 0)
            {
                var currentSymbol = (char)(97 + (currentNumber % system));
                convertedNumber.Insert(0, currentSymbol);
                currentNumber /= system;
            }

            return convertedNumber;
        }

        //private static void Main()
        //{
        //    var inputText = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
        //    var catSystem = 23;
        //    long decodedNumber = 0;

        //    foreach (string item in inputText)
        //    {
        //        decodedNumber += ConvertFromCatSystemToDecimalSystem(catSystem, item);
        //    }

        //    StringBuilder encodedText = ConvertToHigherNumberSystem(23, decodedNumber);
        //    Console.WriteLine("{0} = {1}", encodedText, decodedNumber);
        //}
    }
}
