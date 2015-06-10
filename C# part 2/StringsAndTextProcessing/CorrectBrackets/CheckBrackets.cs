/*
Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckBrackets
{
    static void Main()
    {
        string inputExperession = Console.ReadLine();
        bool areBracketsCorrect = Check(inputExperession);

        Console.WriteLine("Are brackets correct? {0}", areBracketsCorrect);
    }

    private static bool Check(string inputExperession)
    {
        bool areBracketsCorrect = true;
        int startBrackets = 0;
        int endBrackets = 0;

        if (inputExperession[0] == ')' || inputExperession[inputExperession.Length-1] == '(')
        {
            return areBracketsCorrect = false;
        }

        for (int i = 0; i < inputExperession.Length; i++)
        {
           if (inputExperession[i] == ')')
            {
                endBrackets++;
            }
            else if (inputExperession[i] == '(')
            {
                startBrackets++;
            }

           if (i + 1 < inputExperession.Length && inputExperession[i] == '(' && inputExperession[i+1] == ')') // if no expression between brackets ex. (()a +b)
           {
               return false;
           }
        }

        if (endBrackets != startBrackets)
        {
            areBracketsCorrect = false;
        }

        return areBracketsCorrect;
    } 


}

