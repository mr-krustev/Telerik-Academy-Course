using System;

namespace Matrix.Logic.Common
{
    internal class Validator
    {
        internal static void CheckIfValidPositiveNumber(int number, string variableName = "Value")
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(variableName + " cannot be equal or less than 0.");
            }
        }
    }
}
