using System;
using System.Text;

class ASCIITable
{
    static void Main()
    {
        for (int i = 0; i < 128; i++)
        {
            Console.OutputEncoding =                // If you changed your font, you must return it now so you see the ASCII table. :)
                Encoding.ASCII;
            Console.Write((char)i + ", ");
        }
    }
}

