namespace Matrix.Logic
{
    using System;
    using Common;

    public class ConsoleInputProvider
    {
        public static int ReadMatrixSize()
        {
            Console.WriteLine(GlobalMessages.PositiveNumberInputMessage);
            var userInput = Console.ReadLine();

            var matrixSize = 0;
            while (!int.TryParse(userInput, out matrixSize) || !IsInRange(matrixSize, 1, 100))
            {
                Console.WriteLine(GlobalMessages.WrongInputMessage);
                Console.WriteLine(GlobalMessages.PositiveNumberInputMessage);
                userInput = Console.ReadLine();
            }

            return matrixSize;
        }

        private static bool IsInRange(int matrixSize, int minValue, int maxValue)
        {
            return minValue <= matrixSize && matrixSize <= maxValue;
        }
    }
}
