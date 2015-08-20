namespace EntryPoint.Exceptions.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Validator
    {
        public static void CheckIfNull<T>(T arg, string variableName)
        {
            if (arg == null)
            {
                throw new NullReferenceException(variableName + " cannot be null.");
            }
        }

        public static void CheckIfPositiveIntegerNumber(int number, string variableName)
        {
            if (number < 0)
            {
                throw new ArgumentException(variableName + " cannot be a negative number.");
            }
        }

        public static void CheckIfEmptyString(string text, string variableName)
        {
            if (text == "")
            {
                throw new ArgumentException(variableName + " cannot be empty.");
            }
        }

        public static void CheckIfIntegerInRange(int number, int min, int max, string variableName)
        {
            if (number < min || number > max)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format(variableName + " is outside of given range {0}-{1}.", min, max));
            }
        }

        internal static void CheckIfEmptyArray<T>(T[] arr, string variableName)
        {
            if (arr.Length <= 0)
            {
                throw new ArgumentException(variableName + " cannot be empty.");
            }
        }
    }
}
