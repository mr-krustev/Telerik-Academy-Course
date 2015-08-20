using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_Template
{
    class EntryPoint
    {
        static void Main()
        {
            var menu = new MainMenu();
            var props = typeof (MainMenu).GetProperties();

            foreach (var prop in props)
            {
                Console.WriteLine(prop);
                Console.WriteLine(prop.Name);
                Console.WriteLine(prop.GetValue(menu));
            }
        }
    }
}
