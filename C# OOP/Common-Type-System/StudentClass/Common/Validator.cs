using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass.Common
{
    public class Validator
    {
        public static void CheckIfStringIsNullOrEmpty(string input, string propertyName, string msg)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException(propertyName, msg);
            }
        }
    }
}
