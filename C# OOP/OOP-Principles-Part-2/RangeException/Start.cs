using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeException
{
    class Start
    {
        static void Main()
        {
            Console.Write("Enter your bottom limit<integer>: ");
            int bottomLimit = int.Parse(Console.ReadLine());
            Console.Write("Enter your top limit<integer>: ");
            int topLimit = int.Parse(Console.ReadLine());
            
            if (bottomLimit > topLimit)
            {
                throw new ArgumentException("Top limit should NOT be less than bottom limit.");
            }

            Console.Write("Enter your number<integer>: ");
            int number = int.Parse(Console.ReadLine());

            try
            {
                if (number < bottomLimit || number > topLimit)
                {
                    throw new InvalidRangeException<int>("Outside of range.", bottomLimit, topLimit);
                }
                Console.WriteLine("Number is in the range.");
            }
            catch (InvalidRangeException<int> irex)
            {
                Console.WriteLine(irex.Message);
            }

            Console.Write("Enter your date bottom limit<dd/MM/yyyy>: ");
            DateTime dateBottomLimit = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter your date top limit<dd/MM/yyyy>: ");
            DateTime dateTopLimit = DateTime.Parse(Console.ReadLine());

            if (dateBottomLimit > dateTopLimit)
            {
                throw new ArgumentException("Top limit should NOT be less than bottom limit.");
            }

            Console.Write("Enter your number<dd/MM/yyyy>: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            try
            {
                if (date < dateBottomLimit || date > dateTopLimit)
                {
                    throw new InvalidRangeException<DateTime>("Outside of range.", dateBottomLimit, dateTopLimit);
                }
                Console.WriteLine("Date is in the range.");
            }
            catch (InvalidRangeException<DateTime> irex)
            {
                Console.WriteLine(irex.Message);
            }
        }
    }
}
