using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class AbuseList
    {
        static void Main(string[] args)
        {
            MyList<int> intTest = new MyList<int>();

            intTest.Add(5);
            intTest.Add(7);

            Console.WriteLine(intTest.IndexOf(5));
            Console.WriteLine();

            Console.WriteLine(intTest.Max());
            Console.WriteLine(intTest.Min());
            Console.WriteLine();

            intTest.RemoveAt(1);
            intTest.InsertAt(1, 6);
            
            for (int i = 0; i < intTest.Count; i++)
            {
                Console.WriteLine(intTest[i]);
            }

            Console.WriteLine();
            intTest.Clear();

            Console.WriteLine(intTest.Count);
        }
    }
}
