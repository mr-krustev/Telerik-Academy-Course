/*
Problem 17. Longest string

Write a program to return the string with maximum length from an array of strings.
Use LINQ.
*/
namespace LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    class FindString
    {
        public static string text = "";
        public static int maxLength = 0;

        static void Main()
        {
            using (StreamReader sr = new StreamReader(@"..\..\text.txt"))
            {
                text = sr.ReadToEnd();
            }

            string[] arrayOfStr = {"salam", "kartof", "neprotivodeistvai", "baluk"};

            var result =
                 from s in arrayOfStr
                 where GetLongestString(s)
                 select s;

            Console.WriteLine(result.Last());
        }

        private static bool GetLongestString(string s)
        {
            if (s.Length > maxLength)
            {
                maxLength = s.Length;
                return true;
            }

            return false;
        }
    }
}
