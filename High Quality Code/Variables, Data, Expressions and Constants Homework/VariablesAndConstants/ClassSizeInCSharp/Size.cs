namespace CSharpTasks.TaskOne
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                this.height = value;
            }
        }

        public static Size GetRotatedSize(Size size, double angle)
        {
            var sinusTimeHeight = Math.Abs(Math.Sin(angle)) * size.Height;
            var cosinusTimesWidth = Math.Abs(Math.Cos(angle)) * size.Width;

            var sinusTimesWidth = Math.Abs(Math.Sin(angle)) * size.Width;
            var cosinusTimeHeight = Math.Abs(Math.Cos(angle)) * size.Height;

            var rotatedHeight = sinusTimeHeight + cosinusTimesWidth;
            var rotatedWidth = sinusTimesWidth + cosinusTimeHeight;

            return new Size(rotatedHeight, rotatedWidth);
        }
    }
}
