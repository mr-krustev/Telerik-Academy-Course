/*
Problem 7. Timer

Using delegates write a class Timer that can execute certain method at each t seconds.
*/
namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;

    class TimedExecute
    {
        public delegate void ExecuteOnTime(string param);
        public static Random generator = new Random();

        static void Main()
        {
            var meetStrangeness = new ExecuteOnTime(SayHi);
            meetStrangeness += Introduce;
            meetStrangeness += SayBye;

            Console.WriteLine("What is your name, stranger?");
            string name = Console.ReadLine();

            while (Console.KeyAvailable != true)
            {
                meetStrangeness(name);

                Thread.Sleep(3000);
            }

        }

        public static void SayHi(string p)
        {
            Console.WriteLine("Hello, {0}!", p);
        }

        public static void Introduce(string p)
        {
            int[] charNumbers = new int[4];
            for (int i = 0; i < charNumbers.Length; i++)
            {
                charNumbers[i] = generator.Next(65, 91);
            }
            Console.WriteLine("My name is !{0}{1}{2}{3}! and I am grateful to meet you, {4}.", (char)charNumbers[0], (char)charNumbers[1],
                                                                                               (char)charNumbers[2], (char)charNumbers[3], p);
        }

        public static void SayBye(string p)
        {
            Console.WriteLine("I am leaving you now. Goodbye, {0}!\n", p);
        }
      
    }
}
