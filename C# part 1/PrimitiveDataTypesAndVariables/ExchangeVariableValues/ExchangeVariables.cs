/*
Problem 9. Exchange Variable Values

Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange.
*/

using System;

class ExchangeVariables
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        int c = a;

        Console.WriteLine("Before \n" + a +"\n");
        Console.WriteLine(b + "\n");

        a = b;
        b = c;

        Console.WriteLine("After \n" + a + "\n");
        Console.WriteLine(b);
        
        Console.ReadLine();
    }
}
