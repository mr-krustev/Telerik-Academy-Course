namespace Methods
{
    using System;

    public class Methods
    {
        internal static double CalcTriangleArea(double sideA, double sideB, double sideC)
        {
            bool areAllSidesPositve = sideA > 0 && sideB > 0 && sideC > 0;
            if (!areAllSidesPositve)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            bool isSideAValid = sideA <= sideB + sideC;
            bool isSideBValid = sideB <= sideA + sideC;
            bool isSideCValid = sideC <= sideA + sideB;

            bool isTriangle = isSideAValid && isSideBValid && isSideCValid;
            if (!isTriangle)
            {
                throw new ArgumentException(string.Format("There can be no triangle with sides : {{0},{1},{2}}.", sideA, sideB, sideC));
            }

            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return area;
        }

        internal static string DigitToWord(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default:
                    throw new ArgumentException("Number is not a digit.");
            }
        }

        internal static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("Invalid array of elements.");
            }

            var maxElement = int.MinValue;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        internal static void PrintNumberWithPrecision(double number)
        {
            if (number == null)
            {
                throw new NullReferenceException("Number cannot be null.");
            }

            Console.WriteLine("{0:f2}", number);
        }

        internal static void PrintNumberAsPercentage(double number)
        {
            if (number == null)
            {
                throw new NullReferenceException("Number cannot be null.");
            }

            Console.WriteLine("{0:p0}", number);
        }

        internal static void PrintNumberAlignedRight(double number)
        {
            if (number == null)
            {
                throw new NullReferenceException("Number cannot be null.");
            }

            Console.WriteLine("{0,8}", number);
        }

        internal static double CalcDistance(
            double firstPointX, 
            double firstPointY, 
            double secondPointX, 
            double secondPointY)
        {
            double distance = Math.Sqrt(
                ((secondPointX - firstPointX) * (secondPointX - firstPointX)) + 
                ((secondPointY - firstPointY) * (secondPointY - firstPointY)));
            return distance;
        }

        internal static bool IsLineHorizontal(double firstPointY, double secondPointY)
        {
            const double AcceptableDifference = 0.000001;
            return Math.Abs(firstPointY - secondPointY) < AcceptableDifference;
        }

        internal static bool IsLineVertical(double firstPointX, double secondPointX)
        {
            const double AcceptableDifference = 0.000001;
            return Math.Abs(firstPointX - secondPointX) < AcceptableDifference;
        }
    }
}