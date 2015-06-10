using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Start
    {
        static void Main()
        {
            Person goshko = new Person();
            goshko.Name = "Goshko Goshkov";

            Console.WriteLine(goshko);
            Console.WriteLine();

            goshko.Age = 6;
            Console.WriteLine(goshko);
        }
    }
}
