using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Algorithm
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = 0;
        bool isANumber = int.TryParse(Console.ReadLine(), out a);

        Console.Write("Enter second number: ");
        int b = 0;
        bool isBNumber = int.TryParse(Console.ReadLine(), out b);

        a = Math.Abs(a);
        b = Math.Abs(b);


        while (a != 0 && b != 0)
        {
            if (a > b)
            {
                a = a % Math.Abs(b);
            } 
            else
            {
                b %= Math.Abs(a);
            }
                
        }

        if (a == 0)
        {
            Console.WriteLine("The GCD is: " + b);
        }
        else
        {
            Console.WriteLine("The GCD is: " + a);
        }


    }
}

