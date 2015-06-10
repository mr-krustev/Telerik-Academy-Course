/*
Problem 13. Reverse sentence

Write a program that reverses the words in given sentence.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseWords
{
    static void Main()
    {
        string inputSentence = Console.ReadLine();
        string[] noSignSentence = inputSentence.Substring(0,inputSentence.Length -1).Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
        char lastSign = inputSentence[inputSentence.Length - 1];

        List<int> signsInSentence = new List<int>();

        for (int i = 0; i < noSignSentence.Length; i++)
        {
            if (inputSentence[i] == ',')
            {
                signsInSentence.Add(i);
                noSignSentence[i] = noSignSentence[i].Substring(0, noSignSentence.Length - 1);
            }
            else if (inputSentence[i] == '-')
            {
                signsInSentence.Add(i);
                noSignSentence[i] = noSignSentence[i].Substring(0, noSignSentence.Length - 1);
            }
            else if (inputSentence[i] == ':')
            {
                signsInSentence.Add(i);
                noSignSentence[i] = noSignSentence[i].Substring(0, noSignSentence.Length - 1);
            }
        }


        if (signsInSentence.Count > 0)
        {
            for (int i = 0; i < signsInSentence.Count; i++)
            {
                noSignSentence[signsInSentence[i]] += ',';
            }
        }


        string reversedSentence = String.Join(" ", noSignSentence) + lastSign;
        Console.WriteLine(reversedSentence);
    }
}

