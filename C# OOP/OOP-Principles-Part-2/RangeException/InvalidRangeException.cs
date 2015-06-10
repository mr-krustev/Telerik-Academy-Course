namespace RangeException
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


//    Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
    public class InvalidRangeException<T> : Exception
    {
        private T bottomLimit;
        private T topLimit;

        public InvalidRangeException(string msg)
            :base(msg)
        {
        }

        public InvalidRangeException(string msg, Exception innerEx)
            :base(msg,innerEx)
        {
        }

        public InvalidRangeException(string msg, T lowerLimit, T upperLimit)
            : this(msg)
        {
            this.BottomLimit = lowerLimit;
            this.TopLimit = upperLimit;
        }

        public InvalidRangeException(string msg, Exception innerEx, T lowerLimit, T upperLimit)
            : this(msg, innerEx)
        {
            this.BottomLimit = lowerLimit;
            this.TopLimit = upperLimit;
        }

        public T BottomLimit
        {
            get { return this.bottomLimit; }
            private set { this.bottomLimit = value; }
        }

        public T TopLimit
        {
            get { return this.topLimit; }
            private set { this.topLimit = value; }
        }
    }
}
