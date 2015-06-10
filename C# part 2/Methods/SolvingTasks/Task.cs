using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Task
{
    public static void ReverseNumber()
    {
        Console.Write("\nProvide your number: ");
        string input = Console.ReadLine();
        decimal number = 0;
        
        try 
        {
            number = decimal.Parse(input);
        }
        catch (FormatException) // Checks if the exception was due to ','
        {
            number = decimal.Parse(input.Replace(',','.'));          
        }

        if (number >= 0)
        {
            Console.WriteLine("\n" + string.Join("", number.ToString().Reverse()));
        }
        else
        {
            Console.WriteLine("\nNumber should be positive!");
        }
        Console.WriteLine(new string('-', 40));
    }

    public static void AverageOfSequence()
    {
        Console.Write("\nProvide size of sequence: ");
        int size = int.Parse(Console.ReadLine());
        decimal sum = 0.0M;


        if (size > 0)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("Number[{0]] = ");
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(new string('-', 40) + "\n" + sum / size);
        }
        else
        {
            throw new Exception();
        }
        
        Console.WriteLine(new string('-', 40));
    }

    public static void SolveLinear()
    {
        Console.Write("\nEnter number(a) = ");
        double a = int.Parse(Console.ReadLine());
        Console.Write("Enter number(b) = ");
        double b = int.Parse(Console.ReadLine());

        if (a != 0)
        {
            double x = (b / a) + 0.00;

            Console.WriteLine(new string('-', 40) + "\n{0} * x + {1} = {2}", a, b, x);
        }
        else
        {
            throw new Exception();
        }
        Console.WriteLine(new string('-', 40));

    }
}

