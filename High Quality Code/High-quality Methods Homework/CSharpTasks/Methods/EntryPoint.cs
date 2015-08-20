namespace Methods
{
    using System;

    public class EntryPoint
    {
        private static void Main()
        {
            var triangleArea = Methods.CalcTriangleArea(3, 4, 5);
            Console.WriteLine(triangleArea);

            var digitAsWord = Methods.DigitToWord(5);
            Console.WriteLine(digitAsWord);

            var maxNumber = Methods.FindMax(5, -1, 3, 2, 14, 2, 3);
            Console.WriteLine(maxNumber);

            Methods.PrintNumberWithPrecision(1.3);
            Methods.PrintNumberAsPercentage(0.75);
            Methods.PrintNumberAlignedRight(2.30);

            var isHorizontal = Methods.IsLineHorizontal(-1, 2.5);
            var isVertical = Methods.IsLineVertical(3, 3);
            var distance = Methods.CalcDistance(3, -1, 3, 2.5);

            Console.WriteLine(distance);
            Console.WriteLine("Horizontal? " + isHorizontal);
            Console.WriteLine("Vertical? " + isVertical);

            var peter = new Student("Peter", "Ivanov", DateTime.Parse("17/03/1992"), "From Sofia");
            var stella = new Student("Stella", "Markova", DateTime.Parse("03/11/1993"), "From Vidin, gamer, high results.");

            Console.WriteLine(
                "{0} older than {1} -> {2}",
                peter.FirstName,
                stella.FirstName,
                peter.IsOlderThan(stella));
        }
    }
}
