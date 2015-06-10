using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class NumberOfZeroes
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger sum = 1;
        BigInteger counter = 0;


        if (n > 0)
        {
            for (BigInteger i = n; i > 0; i--)
            {
                sum *= i;
            }
        }
        else
        {
            for (BigInteger i = n; i < 0; i++)
            {
                sum *= i;
            }
        }

        while (sum % 10 == 0)
        {
            counter++;
            sum /= 10;
        }

        Console.WriteLine(counter);


    }
}

