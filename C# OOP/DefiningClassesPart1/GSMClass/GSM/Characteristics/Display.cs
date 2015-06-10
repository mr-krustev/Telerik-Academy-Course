namespace GSMClass
{
    using System;

    public class Display
    {
        #region Problem 1. Define Class & Problem 5. Properties
        private double? size;
        private long? numberOfColors;

        public double? Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public long? NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }

        #endregion

        #region Problem 2. Constructors
        public Display()
        {
        }

        public Display(double size)
        {
            this.Size = size;
        }

        public Display(int numberOfColors)
        {
            this.NumberOfColors = numberOfColors;
        }

        public Display(double size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
        #endregion

        #region Problem 4. ToString
        public override string ToString()
        {
            return string.Format("{0} inches, {1} colors", this.size, this.numberOfColors);
        }
        #endregion
    }
}

