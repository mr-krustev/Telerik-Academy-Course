/*

*/

using System;

class Boolean
{
    static void Main()
    {
        bool isFemale;
        
        Console.WriteLine("Are you a female(f) or a male(m)?");

        char sex = char.Parse(Console.ReadLine());
        if (sex == 'f')
        {
            Console.WriteLine("Therefore, on the question \" Are you a female? \" the answer is {0}.", isFemale = true); 
        }
        else
        {
            Console.WriteLine("Therefore, on the question \" Are you a female? \" the answer is {0}.", isFemale = false);
        }
        Console.ReadLine();
    }
}

