namespace CSharpTasks
{
    using System;
    using CSharpTasks.TaskOne;
    using CSharpTasks.TaskTwo;

    public class Start
    {
        public static void Main()
        {
            var testSize = new Size(5, 10);
            var testAngle = 30;
            var rotatedSize = Size.GetRotatedSize(testSize, testAngle);
            Console.WriteLine(
                "Size[{0},{1}] when rotated with angle of {2} has height ~ {3:F3} and width ~ {4:F3}.",
                testSize.Height,
                testSize.Width,
                testAngle,
                rotatedSize.Height,
                rotatedSize.Width);

            var testArray = new double[5] { 2.5, 3, 1.2, 4, 12 };
            Printer.PrintStatistics(testArray);
        }
    }
}
